using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] buffer = new byte[9];
        if ((reading >= -9_223_372_036_854_775_808 ) && (reading <= -2_147_483_649))
        {
            buffer[0] = (byte)(256 - sizeof(long));
            var temp = BitConverter.GetBytes(reading);
            Array.Copy(temp, 0, buffer, 1, temp.Length);
            return buffer;
        }  
        else if ((reading >= -2_147_483_648) && (reading <= -32_769))
        {
            buffer[0] = 256 - (byte)sizeof(int);
            var temp = BitConverter.GetBytes((int)reading);
            Array.Copy(temp, 0, buffer, 1, temp.Length);
            return buffer;
            
        }
        else if ((reading >= -32_768) && (reading <= -1))
        {
            buffer[0] = 256 - (byte)sizeof(short);
            var temp = BitConverter.GetBytes((short)reading);
            Array.Copy(temp, 0, buffer, 1, temp.Length);
            return buffer;
        }
        else if ((reading >= 0) && (reading <= 	65_535))
        {
            buffer[0] = (byte)sizeof(ushort);
            var temp = BitConverter.GetBytes((ushort)reading);
            Array.Copy(temp, 0, buffer, 1, temp.Length);
            return buffer;
        }
        else if ((reading >= 65_536) && (reading <= 2_147_483_647))
        {
            buffer[0] = 256- (byte)sizeof(int);
            var temp = BitConverter.GetBytes((int)reading);
            Array.Copy(temp, 0, buffer, 1, temp.Length);
            return buffer;
        }
        else if ((reading >= 2_147_483_648) && (reading <= 4_294_967_295))
        {
            buffer[0] = (byte)sizeof(uint);
            var temp = BitConverter.GetBytes((uint)reading);
            Array.Copy(temp, 0, buffer, 1, temp.Length);
            return buffer;
        } 
        else if ((reading >= 4_294_967_296) && (reading <= 	9_223_372_036_854_775_807))
        {
            buffer[0] = 256- (byte)sizeof(long);
            var temp = BitConverter.GetBytes(reading);
            Array.Copy(temp, 0, buffer, 1, temp.Length);
            return buffer;
        }        
        throw new NotImplementedException("Please implement the static TelemetryBuffer.ToBuffer() method");
    }

    public static long FromBuffer(byte[] buffer)
    {
        var start = buffer[0];
        long result = 0;
        if (start == 248)
        {
            result = BitConverter.ToInt64(buffer, 1);
            
        }
        else if (start == 252)
        {
            result = BitConverter.ToInt32(buffer, 1);
        }
        else if (start == 254)
        {
            result = BitConverter.ToInt16(buffer, 1);
        }
        else if (start == 2)
        {
            result = BitConverter.ToUInt16(buffer, 1);
        }
        else if (start == 4)
        {
            result = BitConverter.ToUInt32(buffer, 1);
        }
        return result;


        return BitConverter.ToInt64(buffer, 1);


        throw new NotImplementedException("Please implement the static TelemetryBuffer.FromBuffer() method");
    }
/*
    static void Main()
    {
        Console.WriteLine(256 - sizeof(long));
        Console.WriteLine((byte)(248 - sizeof(long)));
        

    }
*/
}
