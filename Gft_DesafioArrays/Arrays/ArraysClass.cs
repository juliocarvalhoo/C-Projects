namespace ProjetoColecoes.Arrays
{
    public class ArraysClass
    {
        public void DesafioInicial()
        {
            // int n1,n2,n3,n4,n5;
            int[] n = new int[5]; //DECLARAR
            int[] num = new int[3]{55,77,99};
            int[] num2 = {0,1,2,3,4,5};
            n[0] = 111;
            n[1] = 222;
            n[2] = 333;
            n[3] = 444;
            n[4] = 555;
        }
        public void MatrizBidimensional()
        {
            int[,] num = new int[3,5];
            num[0,0]=10; num[0,1]=20; num[0,2]=30; num[0,3]=40; num[0,4]=50;
            num[1,0]=60; num[1,1]=70; num[1,2]=80; num[1,3]=90; num[1,4]=15;
            num[2,0]=25; num[2,1]=35; num[2,2]=45; num[2,3]=55; num[2,4]=60;

            // 10 20 30 40 50
            // 60 70 80 90 15
            // 25 35 45 55 60
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }
        

        
    }
}