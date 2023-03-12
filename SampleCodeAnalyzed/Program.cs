using System;
class PROGRAM
{
    static void Main(string[] args)
    {
        var random = new Random();
        int num = random.Next();
        Sample(num);
    }

    // ゲームのコードの場合複雑な関数に遭遇することをがある
    static void Sample(int num)
    {
        // numが0より大きく、10000より小さく、偶数の場合
        if (num > 0 && num < 10000 && num % 2 == 0)
        {
            // numが10, 5, 3の倍数の時
            if (num % 10 == 0 || num % 5 == 0 || num % 3 == 0)
            {
                // numが10 or 50 or 100のとき
                if(num == 10 || num == 50 || num == 100)
                {

                }
            }
        }
    }
}