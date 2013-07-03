namespace ProducerAndConsumer.Helper
{
    using System;
    using System.Security.Cryptography;

    public sealed class RandomHelper
    {
        /// <summary>
        /// 产生小于NumSides的随机数
        /// </summary>
        /// <param name="numSides">基准数</param>
        /// <returns></returns>
        public static int Next(int numSides)
        {
            byte[] randomNumber = new byte[1];

            RNGCryptoServiceProvider Gen = new RNGCryptoServiceProvider();
            Gen.GetBytes(randomNumber);

            int rand = Convert.ToInt32(randomNumber[0]);
            return rand % numSides + 1;
        }
    }
}