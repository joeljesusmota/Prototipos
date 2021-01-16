using System;

namespace CajeroCPE
{
    public class FakeData
    {
        int TargetaValida;
        public int ValidarTargeta(int id)
        {
            int[] NumTargeta = new int[] { 1,2,3 };
        

            for (int i = 0; i < NumTargeta.Length; i++)
            {
                if (id == NumTargeta[i])
                {
                    TargetaValida = NumTargeta[i];
                }
            }
                    return TargetaValida;
          
        }
    }
}
