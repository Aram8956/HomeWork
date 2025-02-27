namespace Project;

public class BigInt
{
    private char[] Number;

    public BigInt(string number)
    {
        Number = number.ToCharArray();
    }

    public BigInt(int number)
    {
        string num = number.ToString();
        Number = num.ToCharArray();
    }

    public BigInt(char[] number)
    {
        Number = number;
    }

    public int Length()
    {
        return Number.Length;
    }

    public override string ToString()
    {
        return new string(Number);
    }


    public string Abs()
    {
        if (Number[0] == '-')
        {
            return new string(Number, 1, Number.Length - 1);
        }
        return new string(Number);
    }

    public void CompareBig(BigInt other)
    {
        if (Number.Length > other.Length())
        {
            Console.WriteLine("Your number is bigger!");
            return;
        }

        else if (Number.Length < other.Length())
        {
            Console.WriteLine("Your number is smaller!");
        }

        else
        {
            bool big = false;
            bool equal = false;
            for (int i = 0; i < Number.Length; i++)
            {
                if (Number[i] > other.Number[i])
                {
                    big = true;
                    equal = false;
                    break;
                }
                else if (Number[i] == other.Number[i])
                {
                    big = false;
                    equal = true;
                }
            }

            if (big == true)
            {
                Console.WriteLine("Your number is bigger!");
                return;
            }
            else if (equal == true)
            {
                Console.WriteLine("Your numbers are equal!");
                return;
            }

            Console.WriteLine("Your number is smaller!");
        }
    }

    public static BigInt operator +(BigInt a, BigInt b)
    {
        int max = Math.Max(a.Length(), b.Length());
        char[] final = new char[max + 1];
        int k = max;
        int i = a.Length() - 1;
        int j = b.Length() - 1;
        int carry = 0;

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int num1 = (i >= 0) ? a.Number[i] - '0' : 0;
            int num2 = (j >= 0) ? b.Number[j] - '0' : 0;
            int sum = num1 + num2 + carry;
            carry = sum / 10;
            final[k] = (char)(sum % 10 + '0');
            i--;
            j--;
            k--;
        }
        return new BigInt(final);
    }
}

class Program
{
    static void Main(string[] args)
    {
        BigInt num1 = new BigInt("12345678");
        BigInt num2 = new BigInt("987654321");
        Console.WriteLine(num1.Abs());
        BigInt num3 = num1 + num2;
        Console.WriteLine(num3.ToString());
    }
}