using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Twelfth.Model
{

    class DICOMTag
    {
        int _groupNum, _elementNum;
        private String _VR;

        public void LoadTag(FileStream input)
        {
            byte[] value = new byte[4];

            input.Read(value, 0, 2);
            _groupNum = BitConverter.ToInt16(value);

            input.Read(value, 0, 2);
            _elementNum = BitConverter.ToInt16(value);

            input.Read(value, 0, 2);
            _VR = Encoding.Default.GetString(value, 0, 2);
        }

        public void GetTagValue(out int groupNum, out int elementNum)
        {
            groupNum = _groupNum;
            elementNum = _elementNum;
        }

        public bool IsEqual(int groupNum, int elementNum)
        {
            if ((_groupNum == groupNum) && (_elementNum == elementNum))
                return true;
            else
                return false;
        }

        public string GetVR()
        {
            return _VR;
        }
    }

    abstract class DICOMData
    {
        DICOMTag _dicomTag;

        public DICOMData(DICOMTag dicomTag)
        {
            _dicomTag = dicomTag;
        }

        public void GetTagValue(out int groupNum, out int elementNum)
        {
            _dicomTag.GetTagValue(out groupNum, out elementNum);
        }

        public bool IsEqual(int groupNum, int elementNum)
        {
            return _dicomTag.IsEqual(groupNum, elementNum);
        }

        public string GetVR()
        {
            return _dicomTag.GetVR();
        }

        public abstract string GetString();
        public abstract void LoadValue(FileStream input);
    }

    class StringData : DICOMData
    {
        private String _value;

        public StringData(DICOMTag dicomTag) : base(dicomTag)
        {
        }

        public override string GetString()
        {
            int groupNum, elementNum;
            GetTagValue(out groupNum, out elementNum);

            string VR = GetVR();

            return "(" + groupNum.ToString("X4") + "," + elementNum.ToString("X4") + ") " + VR + " " + _value;
        }

        public override void LoadValue(FileStream input)
        {
            byte[] lengthByte = new byte[2];
            input.Read(lengthByte, 0, 2);
            int length = BitConverter.ToInt16(lengthByte);

            byte[] value = new byte[length];
            input.Read(value, 0, length);

            _value = Encoding.Default.GetString(value, 0, length);
        }

        public string GetValue()
        {
            return _value;
        }
    }

    class DigitData : DICOMData
    {
        uint _value;

        public DigitData(DICOMTag dicomTag) : base(dicomTag)
        {
        }

        public override string GetString()
        {
            int groupNum, elementNum;
            GetTagValue(out groupNum, out elementNum);

            string VR = GetVR();

            return "(" + groupNum.ToString("X4") + "," + elementNum.ToString("X4") + ") " + VR + " " + _value.ToString();
        }

        public override void LoadValue(FileStream input)
        {
            byte[] lengthByte = new byte[2];
            input.Read(lengthByte, 0, 2);
            int length = BitConverter.ToInt16(lengthByte);

            byte[] value = new byte[length];
            input.Read(value, 0, length);

            if (length == 2)
                _value = BitConverter.ToUInt16(value);
            else if (length == 4)
                _value = BitConverter.ToUInt32(value);
            else
                _value = 0;
        }

        public uint GetValue()
        {
            return _value;
        }
    }

    class SQData : DICOMData
    {
        public SQData(DICOMTag dicomTag) : base(dicomTag)
        {
        }

        public override string GetString()
        {
            int groupNum, elementNum;
            GetTagValue(out groupNum, out elementNum);

            string VR = GetVR();

            return "(" + groupNum.ToString("X4") + "," + elementNum.ToString("X4") + ") " + VR + " SQ is not displayed";
        }

        public override void LoadValue(FileStream input)
        {
            input.Seek(2, SeekOrigin.Current);

            byte[] lengthByte = new byte[4];
            input.Read(lengthByte, 0, 4);
            int length = BitConverter.ToInt32(lengthByte);
            input.Seek(length, SeekOrigin.Current);
        }
    }

    class OBData : DICOMData
    {
        byte[] _value;

        public OBData(DICOMTag dicomTag) : base(dicomTag)
        {
        }

        public override string GetString()
        {
            int groupNum, elementNum;
            GetTagValue(out groupNum, out elementNum);

            string VR = GetVR();

            return "(" + groupNum.ToString("X4") + "," + elementNum.ToString("X4") + ") " + VR + " OB is not displayed";
        }

        public override void LoadValue(FileStream input)
        {
            input.Seek(2, SeekOrigin.Current);

            byte[] lengthByte = new byte[4];
            input.Read(lengthByte, 0, 4);
            int length = BitConverter.ToInt32(lengthByte);

            _value = new byte[length];
            input.Read(_value, 0, length);
        }

        public Bitmap GetBitmap(int row, int column)
        {
            byte[] value = new byte[_value.Length];

            _value.CopyTo(value, 0);

            byte swap;
            for (int i = 0; i < value.Length / 3; i++)
            {
                swap = value[i * 3];
                value[i * 3] = value[i * 3 + 2];
                value[i * 3 + 2] = swap;
            }

            Bitmap bitmap = new Bitmap(column, row, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Rectangle rect = new Rectangle(0, 0, column, row);

            BitmapData bmpData = bitmap.LockBits(rect, ImageLockMode.ReadWrite, bitmap.PixelFormat);

            IntPtr ptr = bmpData.Scan0;
            Marshal.Copy(value, 0, ptr, value.Length);

            bitmap.UnlockBits(bmpData);

            return bitmap;
        }
    }

    class DICOMDataManager
    {
        private List<DICOMData> _DataList = new List<DICOMData>();

        public DICOMDataManager()
        {
        }

        public int Length
        {
            get { return _DataList.Count; }
        }

        public DICOMData GetData(int group, int element)
        {
            foreach (DICOMData item in _DataList)
            {
                if (item.IsEqual(group, element))
                    return item;
            }

            return null;
        }

        public DICOMData this[int i]
        {
            get { return _DataList[i]; }
            set { _DataList[i] = value; }
        }

        private void SkipMetaInformation(FileStream input)
        {
            // skip preamble
            input.Seek(128, SeekOrigin.Current);

            // DICOM Prefix
            input.Seek(4, SeekOrigin.Current);
        }

        private DICOMData GetDICOMData(FileStream input)
        {
            DICOMTag dicomTag = new DICOMTag();
            dicomTag.LoadTag(input);

            DICOMData dicomData;

            switch (dicomTag.GetVR())
            {
                case "CS":
                case "UI":
                case "DA":
                case "TM":
                case "SH":
                case "DT":
                case "PN":
                case "LO":
                case "IS":
                case "DS":
                case "AE":
                    dicomData = new StringData(dicomTag);
                    break;
                case "US":
                case "UL":
                    dicomData = new DigitData(dicomTag);
                    break;
                case "SQ":
                    dicomData = new SQData(dicomTag);
                    break;
                case "OB":
                    dicomData = new OBData(dicomTag);
                    break;
                default:
                    dicomData = new StringData(dicomTag);
                    break;
            }

            dicomData.LoadValue(input);

            return dicomData;
        }

        public void LoadData(string fileName)
        {
            _DataList.Clear();
            FileStream dicomFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            SkipMetaInformation(dicomFile);

            while (dicomFile.Length != dicomFile.Position)
                _DataList.Add(GetDICOMData(dicomFile));

            dicomFile.Close();
        }

        public Bitmap GetBitmapImage()
        {
            DICOMData dicomData;
            dicomData = GetData(0x0028, 0x0010);
            DigitData row = dicomData as DigitData;

            dicomData = GetData(0x0028, 0x0011);
            DigitData column = dicomData as DigitData;

            dicomData = GetData(0x7fe0, 0x0010);
            OBData image = dicomData as OBData;

            Bitmap bitmap = image.GetBitmap((int)row.GetValue(), (int)column.GetValue());

            return bitmap;
        }
    }
}
