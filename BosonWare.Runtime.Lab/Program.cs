using BosonWare.Encoding;
using System.Text;

var data = Encoding.UTF8.GetBytes("Hello, World!");

var base58 = Base58.EncodeData(data);

Console.WriteLine($"Base58: {base58} Message: {data}");

Console.WriteLine($"Int32: {print(BitConverter.GetBytes(-800))}");
Console.WriteLine($"Int64: {print(BitConverter.GetBytes(-800L))}");
Console.WriteLine($"Double: {print(BitConverter.GetBytes(-800.5))}");
Console.WriteLine($"Float: {print(BitConverter.GetBytes(-800.5f))}");

Console.ReadKey();

static string print(byte[] bytes)
{
    var buf = new StringBuilder();

    buf.Append('[');
    for (int i = 0; i < bytes.Length; i++) {
        byte b = bytes[i];

        buf.Append(b);

        if (i < bytes.Length - 1) {
            buf.Append(", ");
        }
    }
    buf.Append(']');

    return buf.ToString();
}