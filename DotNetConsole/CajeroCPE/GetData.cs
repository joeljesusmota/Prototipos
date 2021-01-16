using System;

namespace CajeroCPE
{
    public class GetData
    { 
        public void GetTargeta (int NumTargeta)
        {
            FakeData GetNumTargeta = new FakeData();
            NumTargeta = GetNumTargeta.Targeta();
        }
    }

}