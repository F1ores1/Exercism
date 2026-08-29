public static class VariableLengthQuantity
{
    public static uint[] Encode(uint[] numbers)
    {
        
        // throw new Exception($"Print: {numbers}");


        List<uint> encodeList = new List<uint>();


        for (int i = 0; i < numbers.Length; i++)
        {
            var number = numbers[i];
            // var binary = Convert.ToString(number, 2);
            // int byteCount = binary.Length / 7;
            // int bitRemainder = binary.Length % 7;
            List<uint> byteList = new List<uint>();
            uint returnByte = 0;
            uint compare = 0;
            if (number == 0)
                byteList.Insert(0, 0);
            while (number > 0)
            {
                returnByte = (number & 0x7F) | compare;
                number >>= 7;
                compare = 0x80;
                byteList.Insert(0, returnByte);
            }


            // if (bitRemainder > 0)
            // {
            //     byteCount = byteCount + 1;
            //     int addZero = 7 - bitRemainder;
            //     for (int k = 0; k < addZero; k++)
            //     {
            //         binary = "0" + binary;
            //     }
            // }
            // for (int j = 0; j < byteCount; j++)
            // {
            //     var subBinary = binary.Substring(binary.Length - j*7 -7, 7);
            //     if (j == 0)
            //     {
            //         subBinary = "0" + subBinary;
            //     }
            //     else
            //     {
            //         subBinary = "1" + subBinary;
            //     }
            //     var newInt = Convert.ToUInt32(subBinary, 2);
            //     byteList.Insert(0, newInt);
            // }
            encodeList.AddRange(byteList);
        }
        return encodeList.ToArray();
    }

    public static uint[] Decode(uint[] bytes)
    {
        List<uint> decodeList = new List<uint>();

        var binaryNumber = "";

        for (int i = 0; i < bytes.Length; i++)
        {
            var byteBinary = Convert.ToString(bytes[i], 2).PadLeft(8, '0');


            if (byteBinary[0] == '1')
            {
                binaryNumber = binaryNumber + byteBinary.Substring(1,7);
            }
            else
            {
                binaryNumber = binaryNumber + byteBinary.Substring(1,7);
                decodeList.Add(Convert.ToUInt32(binaryNumber, 2));
                binaryNumber = "";
            }
            
        }
        if (decodeList.ToArray().Length == 0)
            throw new InvalidOperationException();

        return decodeList.ToArray();

    }
}