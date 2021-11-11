using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decrypition
{
    class team6_MaHoaDes
    {
        static FileStream file = null;

        int[,] IP = new int[8, 8];
        int[,] IP_1 = new int[8, 8];
        int[,] PC_1 = new int[8, 7];
        int[,] PC_2 = new int[8, 6];
        int[,] EMoRong = new int[8, 6];
        int[,] P = new int[8, 4];
        int[,] S1 = new int[4, 16];
        int[,] S2 = new int[4, 16];
        int[,] S3 = new int[4, 16];
        int[,] S4 = new int[4, 16];
        int[,] S5 = new int[4, 16];
        int[,] S6 = new int[4, 16];
        int[,] S7 = new int[4, 16];
        int[,] S8 = new int[4, 16];
        int[][,] Sbox = new int[8][,];//mảng 1 chiều chứa các mảng 2 chiều
        int[,] DichCD = new int[2, 16];

        string _ptChuyenDoi = "";

        void khoiTaoDES(string ptKhoiTao)
        {
            file = new FileStream(@"" + ptKhoiTao + "", FileMode.Open, FileAccess.Read, FileShare.None);

            StreamReader doc = new StreamReader(file);

            string Temp = "";

            //đọc dòng thừa
            Temp = doc.ReadLine();
            //======================khởi tạo cho mảng IP
            docDuLieu(IP.GetLength(0), IP, doc);

            //đọc 2 dòng thừa
            Temp = doc.ReadLine();
            Temp = doc.ReadLine();
            //======================khởi tạo cho mảng IP-1
            docDuLieu(IP_1.GetLength(0), IP_1, doc);

            //đọc 2 dòng thừa
            Temp = doc.ReadLine();
            Temp = doc.ReadLine();
            //======================khởi tạo cho mảng PC-1
            docDuLieu(PC_1.GetLength(0), PC_1, doc);

            //đọc 2 dòng thừa
            Temp = doc.ReadLine();
            Temp = doc.ReadLine();
            //======================khởi tạo cho mảng PC-2
            docDuLieu(PC_2.GetLength(0), PC_2, doc);

            //đọc 2 dòng thừa
            Temp = doc.ReadLine();
            Temp = doc.ReadLine();
            //=====================khởi tạo cho mảng PC-1
            docDuLieu(EMoRong.GetLength(0), EMoRong, doc);

            //đọc 2 dòng thừa
            Temp = doc.ReadLine();
            Temp = doc.ReadLine();
            //=======================khởi tạo cho mảng P
            docDuLieu(P.GetLength(0), P, doc);

            //đọc 2 dòng thừa
            Temp = doc.ReadLine();
            Temp = doc.ReadLine();
            //=======================khởi tạo cho mảng S1
            docDuLieu(S1.GetLength(0), S1, doc);

            //đọc 2 dòng thừa
            Temp = doc.ReadLine();
            Temp = doc.ReadLine();
            //=======================khởi tạo cho mảng S2
            docDuLieu(S2.GetLength(0), S2, doc);

            //đọc 2 dòng thừa
            Temp = doc.ReadLine();
            Temp = doc.ReadLine();
            //=======================khởi tạo cho mảng S3
            docDuLieu(S3.GetLength(0), S3, doc);

            //đọc 2 dòng thừa
            Temp = doc.ReadLine();
            Temp = doc.ReadLine();
            //=======================khởi tạo cho mảng S4
            docDuLieu(S4.GetLength(0), S4, doc);

            //đọc 2 dòng thừa
            Temp = doc.ReadLine();
            Temp = doc.ReadLine();
            //=======================khởi tạo cho mảng S5
            docDuLieu(S5.GetLength(0), S5, doc);

            //đọc 2 dòng thừa
            Temp = doc.ReadLine();
            Temp = doc.ReadLine();
            //=======================khởi tạo cho mảng S6
            docDuLieu(S6.GetLength(0), S6, doc);

            //đọc 2 dòng thừa
            Temp = doc.ReadLine();
            Temp = doc.ReadLine();
            //=======================khởi tạo cho mảng S7
            docDuLieu(S7.GetLength(0), S7, doc);

            //đọc 2 dòng thừa
            Temp = doc.ReadLine();
            Temp = doc.ReadLine();
            //=======================khởi tạo cho mảng S8
            docDuLieu(S8.GetLength(0), S8, doc);

            //đọc 2 dòng thừa
            Temp = doc.ReadLine();
            Temp = doc.ReadLine();
            //======================khởi tạo cho mảng PC-1
            docDuLieu(DichCD.GetLength(0), DichCD, doc);

            // gán các bảng S vào 1 mảng Sbox để dễ truy xuất đến từng hôp;
            Sbox[0] = S1;
            Sbox[1] = S2;
            Sbox[2] = S3;
            Sbox[3] = S4;
            Sbox[4] = S5;
            Sbox[5] = S6;
            Sbox[6] = S7;
            Sbox[7] = S8;

            file.Dispose();
            file.Close();

        }

        public team6_MaHoaDes(string ptKhoiTao, string ptChuyenDoi)
        {
            _ptChuyenDoi = ptChuyenDoi;
            khoiTaoDES(ptKhoiTao);
        }

        string ChuyenNhiPhanSangASC(string Input)
        {

            file = new FileStream(@"" + _ptChuyenDoi + "", FileMode.Open, FileAccess.Read, FileShare.None);

            StreamReader doc = new StreamReader(file);


            string Temp, NhiPhan, ThapPhan, Hex, ASC;

            string Output = "";

            //đọc từng dòng một
            Temp = doc.ReadLine();

            while (Temp != null)
            {

                NhiPhan = Temp.Substring(0, 8).ToString();
                ThapPhan = Temp.Substring(9, 3).ToString().Trim();
                Hex = Temp.Substring(13, 2).ToString();
                ASC = Temp.Substring(16, 1);

                if (NhiPhan == Input)
                {
                    Output = ASC;
                    break;
                }

                Temp = doc.ReadLine();
            }

            doc.Close();
            file.Close();

            return Output;
        }

        string ChuyenASCsangNhiPhan(string BanRo)
        {

            file = new FileStream(@"" + _ptChuyenDoi + "", FileMode.Open, FileAccess.Read, FileShare.None);

            StreamReader doc = new StreamReader(file);

            //đọc từng dòng một
            string Temp = "", NhiPhan = "", ThapPhan = "", Hex = "", ASC = "";

            string[] MangNhiPhan = new string[BanRo.Length];

            Temp = doc.ReadLine();
            int t = 0;

            while (Temp != null)
            {

                NhiPhan = Temp.Substring(0, 8).ToString();
                ThapPhan = Temp.Substring(9, 3).ToString().Trim();
                Hex = Temp.Substring(13, 2).ToString();
                ASC = Temp.Substring(16, 1);

                for (int i = 0; i < BanRo.Length; i++)
                {
                    if (ASC == BanRo[i].ToString())
                    {
                        MangNhiPhan[i] = NhiPhan;
                        t++;
                    }
                }

                if (t == BanRo.Length) break;

                Temp = doc.ReadLine();
            }

            string ChuoiNhiPhan = "";

            for (int i = 0; i < BanRo.Length; i++)
            {
                ChuoiNhiPhan += MangNhiPhan[i];
            }

            doc.Close();
            file.Close();

            return ChuoiNhiPhan;
        }

        //đọc dữ liệu của bảng gán vào mảng tương ứng
        void docDuLieu(int Hang, int[,] Mang, StreamReader doc)
        {

            string Temp = "";
            //====================================================khởi tạo cho Mảng
            for (int i = 0; i < Hang; i++)
            {
                Temp = doc.ReadLine();

                string str = "";
                int c = 0;

                // quét từng kí tự của 1 hàng sau đó tách thành từng cột
                for (int j = 0; j < Temp.Length; j++)
                {
                    if (Temp[j].ToString() != "\t")
                    {
                        str += Temp[j];
                    }
                    else
                    {
                        Mang[i, c] = Convert.ToInt32(str);
                        str = "";
                        c++;
                    }

                    //trường hợp cuối không có kí tự \t để đánh dấu gán vào mảng nên phải tự gán
                    if (j == Temp.Length - 1)
                        Mang[i, c] = Convert.ToInt32(str);

                }
            }
        }

        string boBitPanity(string K)
        {
            string str = "";

            int stat = 0;

            for (int i = 0; i < 8; i++)
            {
                str += K.Substring(stat, 7);
                stat += 8;
            }

            return str;
        }

        string hoanViPC_1(string K)
        {
            string str = "";

            for (int i = 0; i < PC_1.GetLength(0); i++)
                for (int j = 0; j < PC_1.GetLength(1); j++)
                {
                    str += K[PC_1[i, j] - 1];
                }

            return str;
        }

        string hoanViPC_2(string K)
        {
            string str = "";

            for (int i = 0; i < PC_2.GetLength(0); i++)
                for (int j = 0; j < PC_2.GetLength(1); j++)
                {
                    str += K[PC_2[i, j] - 1];
                }

            return str;
        }

        string hoanViIP(string K)
        {
            string str = "";

            for (int i = 0; i < IP.GetLength(0); i++)
                for (int j = 0; j < IP.GetLength(1); j++)
                {
                    str += K[IP[i, j] - 1];
                }

            return str;
        }

        string hoanViIP_1(string K)
        {
            string str = "";

            for (int i = 0; i < IP_1.GetLength(0); i++)
                for (int j = 0; j < IP_1.GetLength(1); j++)
                {
                    str += K[IP_1[i, j] - 1];
                }

            return str;
        }

        string hoanViP(string K)
        {
            string str = "";

            for (int i = 0; i < P.GetLength(0); i++)
                for (int j = 0; j < P.GetLength(1); j++)
                {
                    str += K[P[i, j] - 1];
                }

            return str;
        }

        string dichBitTrai(string input, int n)
        {
            string str1, str2;

            str1 = input.Substring(0, n);

            str2 = input.Substring(n, input.Length - n);

            return str2 + str1;
        }

        string MoRongR(string input)
        {
            string str = "";

            for (int i = 0; i < EMoRong.GetLength(0); i++)
                for (int j = 0; j < EMoRong.GetLength(1); j++)
                {
                    str += input[EMoRong[i, j] - 1];
                }

            return str;
        }

        string XOR(string input1, string input2)
        {
            string str = "";

            for (int i = 0; i < input1.Length; i++)
            {
                str += KiemTraBit(input1[i].ToString(), input2[i].ToString());
            }

            return str;
        }

        string KiemTraBit(string input1, string input2)
        {
            if (input1 == "0" && input2 == "0")
                return "0";
            if (input1 == "1" && input2 == "1")
                return "0";
            if (input1 == "1" && input2 == "0")
                return "1";
            if (input1 == "0" && input2 == "1")
                return "1";

            return "0";
        }

        public static string thaoTac = "";
        public string DES(string BanRo, string Khoa)
        {
            string Output = "";

            //nếu chưa đủ kí tự để chia thành các khổi 64 bit thì thêm kí tự z vào cuối
            if (BanRo.Length % 8 != 0)
            {
                while (BanRo.Length % 8 != 0)
                {
                    BanRo += "z";
                }
            }

            StringBuilder strB = new StringBuilder("");

            strB.AppendLine("Bản rõ: " + BanRo);

            string[] MangBanRo = new string[BanRo.Length / 8];

            strB.AppendLine("Chia bản rõ làm " + MangBanRo.Length + " khối");

            int st = 0;

            for (int t = 0; t < MangBanRo.Length; t++)
            {
                MangBanRo[t] = BanRo.Substring(st, 8);
                st += 8;
                strB.AppendLine("Khối " + (t + 1) + " = " + MangBanRo[t]);
            }

            strB.AppendLine();

            for (int k = 0; k < MangBanRo.Length; k++)
            {
                BanRo = MangBanRo[k];

                strB.AppendLine("Mã hóa khối " + (k + 1) + ": " + BanRo);

                string MaHoa = "", L0 = "", R0 = "", C0 = "", D0 = "", K0 = Khoa;


                //==============================bản rõ
                BanRo = ChuyenASCsangNhiPhan(BanRo);//chuyển bản rõ sang nhị phân

                strB.AppendLine("Bản rõ nhị phân: " + BanRo);

                BanRo = hoanViIP(BanRo);// hoán vị ip bản rõ

                strB.AppendLine("Hoán vị IP= " + BanRo);

                L0 = BanRo.Substring(0, 32);// 1 nửa đầu

                strB.AppendLine("L0= " + L0);

                R0 = BanRo.Substring(32, 32);// nửa cuối

                strB.AppendLine("R0= " + R0);

                strB.AppendLine("Khóa K= " + K0);

                //=============================khóa
                K0 = ChuyenASCsangNhiPhan(K0);//chuyển khóa sang hệ nhị phân

                strB.AppendLine("Chuyển K sang hệ nhị phân = " + K0);

                //Khoa = boBitPanity(Khoa);//loại bỏ bit Panity còn 56 bit

                K0 = hoanViPC_1(K0);//hoán vị thành 48 bit

                strB.AppendLine("Khóa K hoán vị PC-1 = " + K0);

                C0 = K0.Substring(0, 28);

                strB.AppendLine("C0 = " + C0);

                D0 = K0.Substring(28, 28);

                strB.AppendLine("D0 = " + D0);

                string R = R0, L = "", K = K0, ER, temp, SboxOut, HamF, C = C0, D = D0;

                for (int i = 0; i < 16; i++)
                {
                    C = dichBitTrai(C, DichCD[1, i]);
                    D = dichBitTrai(D, DichCD[1, i]);

                    L = R;

                    K = hoanViPC_2(C + D);

                    ER = MoRongR(R);

                    temp = XOR(ER, K);

                    SboxOut = Sbox_Out(temp);

                    HamF = hoanViP(SboxOut);

                    R = XOR(L, HamF);

                    strB.AppendLine("Vòng " + (i + 1) + "==============================================");
                    strB.AppendLine("C" + (i + 1) + "= " + C + " (Dịch trái " + DichCD[1, i] + ")");
                    strB.AppendLine("D" + (i + 1) + "= " + D + " (Dịch trái " + DichCD[1, i] + ")");
                    strB.AppendLine("K" + (i + 1) + "= " + K);
                    strB.AppendLine("E(R" + i + ")= " + ER);
                    strB.AppendLine("E(R" + i + ") XOR K" + (i + 1) + ")= " + temp);
                    strB.AppendLine("S-box output " + (i + 1) + "= " + SboxOut);
                    strB.AppendLine("f(R" + i + ", K" + (i + 1) + ")= " + HamF);
                    strB.AppendLine("L" + (i + 1) + "= " + L);
                    strB.AppendLine("R" + (i + 1) + "= " + R);
                }

                MaHoa = hoanViIP_1(R + L);

                strB.AppendLine("R16+L16= " + R + L);
                strB.AppendLine("Hoán vị R16 L16 trong IP-1 ta được bản mã khối " + (k + 1) + ": " + MaHoa);

                int stat = 0;
                string str = "";
                string OutTemp = "";

                for (int i = 0; i < 8; i++)
                {
                    str = MaHoa.Substring(stat, 8);
                    stat += 8;

                    OutTemp += Nhi_Hex(str);
                }

                strB.AppendLine("Bản mã hóa khối " + (k + 1) + ": " + OutTemp);

                Output += OutTemp;

                OutTemp = "";

                strB.AppendLine();
            }

            strB.AppendLine("BẢN MÃ HÓA CUỐI: " + Output);

            thaoTac = strB.ToString();

            return Output;
        }


        string Sbox_Out(string input)
        {
            string str;
            int stat = 0;

            string Output = "";

            for (int i = 0; i < 8; i++)
            {
                str = input.Substring(stat, 6);
                stat += 6;

                int Hang = Convert.ToInt32(Nhi_Thap(str[0].ToString() + str[5].ToString()));
                int Cot = Convert.ToInt32(Nhi_Thap(str.Substring(1, 4)));

                int temp = Sbox[i][Hang, Cot];

                Output += Thap_Nhi_4Bit(temp);
            }

            return Output;
        }

        string Nhi_Thap(string str)
        {
            int i, n;
            double a = 0;

            for (i = 0, n = str.Length - 1; i < str.Length; i++, n--)
            {
                a += double.Parse(str[i].ToString()) * Math.Pow(2, n);
            }

            return a.ToString();
        }

        string Thap_Nhi_4Bit(int n)
        {
            string strNhiPhan = "";

            Stack<int> np = new Stack<int>();

            while (n != 0)
            {
                np.Push(n % 2);
                n /= 2;
            }

            while (np.Count > 0)
            {
                strNhiPhan += np.Pop().ToString();
            }


            while (strNhiPhan.Length < 8)
                strNhiPhan = "0" + strNhiPhan;

            return strNhiPhan.Substring(4, 4);
        }

        string Thap_Nhi(int n)
        {
            string strNhiPhan = "";

            Stack<int> np = new Stack<int>();

            while (n != 0)
            {
                np.Push(n % 2);
                n /= 2;
            }

            while (np.Count > 0)
            {
                strNhiPhan += np.Pop().ToString();
            }


            while (strNhiPhan.Length < 8)
                strNhiPhan = "0" + strNhiPhan;

            return strNhiPhan;
        }
        string Thap_Hex(string str)
        {
            string strNhiPhan;

            strNhiPhan = Thap_Nhi(Int32.Parse(str));

            while (strNhiPhan.Length % 4 != 0)
                strNhiPhan = "0" + strNhiPhan;

            int i = 0, t;
            string temp = "", mau = "0123456789ABCDEF";
            string strHex = "";

            while (i < strNhiPhan.Length)
            {
                temp = strNhiPhan.Substring(i, 4).ToString();
                t = Int32.Parse(Nhi_Thap(temp));
                strHex += mau[t].ToString();

                i += 4;
            }

            return strHex;
        }

        string Nhi_Hex(string str)
        {
            string strHex = "";
            string p = Nhi_Thap(str);

            strHex = Thap_Hex(Nhi_Thap(str));

            return strHex;
        }
    }
}

