using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;


namespace 西门子S7协议
{
    class Program
    {
       static Plc s7_plc;
        static void Main(string[] args)
        {            
            byte[] data = new byte[2];
            Console.WriteLine("主进程开始");
            //try
            //{
            //    //s7_plc.Open();
            //    //s7_plc.OpenAsync();
            //    //data = s7_plc.ReadBytes(DataType.DataBlock, 10, 0, 1);//读取DB10，从0开始的2个bytes

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //    Console.WriteLine("----111----");
            //    Console.ReadKey();
            //}   
            Plc_conn();
            Console.WriteLine("主进程结束");
            Console.ReadKey();

        }
        public static async void  Plc_conn()// async await 异步连接PLC
        {
            s7_plc = new Plc(CpuType.S71200, "192.168.0.1", 0, 1);
            try
            {
              Console.WriteLine("start open---");
              await  s7_plc.OpenAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("----2222----");               
            }
        }

    }
}
