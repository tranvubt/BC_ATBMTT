using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoATBMTT.Ults
{
    class DESConstants
    {
        public DataTable[] s = new DataTable[8] ;
        public  string[] ip  = "58 50 42 34 26 18 10 02 60 52 44 36 28 20 12 04 62 54 46 38 30 22 14 06 64 56 48 40 32 24 16 08 57 49 41 33 25 17 09 01 59 51 43 35 27 19 11 03 61 53 45 37 29 21 13 05 63 55 47 39 31 23 15 07".Split(" ");
        public string[]  E = "32 01 02 03 04 05 04 05 06 07 08 09 08 09 10 11 12 13 12 13 14 15 16 17 16 17 18 19 20 21 20 21 22 23 24 25 24 25 26 27 28 29 28 29 30 31 32 01".Split(" ");
        public string[]  p = "16 07 20 21 29 12 28 17 01 15 23 26 05 18 31 10 02 08 24 14 32 27 03 09 19 13 30 06 22 11 04 25".Split(" ");
        public  string[]  pc1 = "57 49 41 33 25 17 09 01 58 50 42 34 26 18 10 02 59 51 43 35 27 19 11 03 60 52 44 36 63 55 47 39 31 23 15 07 62 54 46 38 30 22 14 06 61 53 45 37 29 21 13 05 28 20 12 04".Split(" ");
        public string[] pc2 = "14 17 11 24 01 05 03 28 15 06 21 10 23 19 12 04 26 08 16 07 27 20 13 02 41 52 31 37 47 55 30 40 51 45 33 48 44 49 39 56 34 53 46 42 50 36 29 32".Split(" ");

        public DESConstants()
        {
            khoitao_s0();
            khoitao_s1();
            khoitao_s2();
            khoitao_s3();
            khoitao_s4();
            khoitao_s5();
            khoitao_s6();
            khoitao_s7();
        }

        private void khoitao_s0()
        {
            int i;
            s[0] = new DataTable();
            for (i = 0; i <= 15; i++)
            {
                DataColumn col = new DataColumn();
                s[0].Columns.Add(col);
            }
            for (i = 0; i <= 3; i++)
            {
                DataRow row = s[0].NewRow();
                s[0].Rows.Add(row);
            }
            s[0].Rows[0][0] = 14;
            s[0].Rows[0][1] = 4;
            s[0].Rows[0][2] = 13;
            s[0].Rows[0][3] = 1;
            s[0].Rows[0][4] = 2;
            s[0].Rows[0][5] = 15;
            s[0].Rows[0][6] = 11;
            s[0].Rows[0][7] = 8;
            s[0].Rows[0][8] = 3;
            s[0].Rows[0][9] = 10;
            s[0].Rows[0][10] = 6;
            s[0].Rows[0][11] = 12;
            s[0].Rows[0][12] = 5;
            s[0].Rows[0][13] = 9;
            s[0].Rows[0][14] = 0;
            s[0].Rows[0][15] = 7;
            s[0].Rows[1][0] = 0;
            s[0].Rows[1][1] = 15;
            s[0].Rows[1][2] = 7;
            s[0].Rows[1][3] = 4;
            s[0].Rows[1][4] = 14;
            s[0].Rows[1][5] = 2;
            s[0].Rows[1][6] = 13;
            s[0].Rows[1][7] = 1;
            s[0].Rows[1][8] = 10;
            s[0].Rows[1][9] = 6;
            s[0].Rows[1][10] = 12;
            s[0].Rows[1][11] = 11;
            s[0].Rows[1][12] = 9;
            s[0].Rows[1][13] = 5;
            s[0].Rows[1][14] = 3;
            s[0].Rows[1][15] = 8;
            s[0].Rows[2][0] = 4;
            s[0].Rows[2][1] = 1;
            s[0].Rows[2][2] = 14;
            s[0].Rows[2][3] = 8;
            s[0].Rows[2][4] = 13;
            s[0].Rows[2][5] = 6;
            s[0].Rows[2][6] = 2;
            s[0].Rows[2][7] = 11;
            s[0].Rows[2][8] = 15;
            s[0].Rows[2][9] = 12;
            s[0].Rows[2][10] = 9;
            s[0].Rows[2][11] = 7;
            s[0].Rows[2][12] = 3;
            s[0].Rows[2][13] = 10;
            s[0].Rows[2][14] = 5;
            s[0].Rows[2][15] = 0;
            s[0].Rows[3][0] = 15;
            s[0].Rows[3][1] = 12;
            s[0].Rows[3][2] = 8;
            s[0].Rows[3][3] = 2;
            s[0].Rows[3][4] = 4;
            s[0].Rows[3][5] = 9;
            s[0].Rows[3][6] = 1;
            s[0].Rows[3][7] = 7;
            s[0].Rows[3][8] = 5;
            s[0].Rows[3][9] = 11;
            s[0].Rows[3][10] = 3;
            s[0].Rows[3][11] = 14;
            s[0].Rows[3][12] = 10;
            s[0].Rows[3][13] = 0;
            s[0].Rows[3][14] = 6;
            s[0].Rows[3][15] = 13;
            //dgs0.DataSource = s(0);
        }
        private void khoitao_s1()
        {
            int i;
            s[1] = new DataTable();
            for (i = 0; i <= 15; i++)
            {
                DataColumn col = new DataColumn();
                s[1].Columns.Add(col);
            }
            for (i = 0; i <= 3; i++)
            {
                DataRow row = s[1].NewRow();
                s[1].Rows.Add(row);
            }
            s[1].Rows[0][0] = 15;
            s[1].Rows[0][1] = 1;
            s[1].Rows[0][2] = 8;
            s[1].Rows[0][3] = 14;
            s[1].Rows[0][4] = 6;
            s[1].Rows[0][5] = 11;
            s[1].Rows[0][6] = 3;
            s[1].Rows[0][7] = 4;
            s[1].Rows[0][8] = 9;
            s[1].Rows[0][9] = 7;
            s[1].Rows[0][10] = 2;
            s[1].Rows[0][11] = 13;
            s[1].Rows[0][12] = 12;
            s[1].Rows[0][13] = 0;
            s[1].Rows[0][14] = 5;
            s[1].Rows[0][15] = 10;
            s[1].Rows[1][0] = 3;
            s[1].Rows[1][1] = 13;
            s[1].Rows[1][2] = 4;
            s[1].Rows[1][3] = 7;
            s[1].Rows[1][4] = 15;
            s[1].Rows[1][5] = 2;
            s[1].Rows[1][6] = 8;
            s[1].Rows[1][7] = 14;
            s[1].Rows[1][8] = 12;
            s[1].Rows[1][9] = 0;
            s[1].Rows[1][10] = 1;
            s[1].Rows[1][11] = 10;
            s[1].Rows[1][12] = 6;
            s[1].Rows[1][13] = 9;
            s[1].Rows[1][14] = 11;
            s[1].Rows[1][15] = 5;
            s[1].Rows[2][0] = 0;
            s[1].Rows[2][1] = 14;
            s[1].Rows[2][2] = 7;
            s[1].Rows[2][3] = 11;
            s[1].Rows[2][4] = 10;
            s[1].Rows[2][5] = 4;
            s[1].Rows[2][6] = 13;
            s[1].Rows[2][7] = 1;
            s[1].Rows[2][8] = 5;
            s[1].Rows[2][9] = 8;
            s[1].Rows[2][10] = 12;
            s[1].Rows[2][11] = 6;
            s[1].Rows[2][12] = 9;
            s[1].Rows[2][13] = 3;
            s[1].Rows[2][14] = 2;
            s[1].Rows[2][15] = 15;
            s[1].Rows[3][0] = 13;
            s[1].Rows[3][1] = 8;
            s[1].Rows[3][2] = 10;
            s[1].Rows[3][3] = 1;
            s[1].Rows[3][4] = 3;
            s[1].Rows[3][5] = 15;
            s[1].Rows[3][6] = 4;
            s[1].Rows[3][7] = 2;
            s[1].Rows[3][8] = 11;
            s[1].Rows[3][9] = 6;
            s[1].Rows[3][10] = 7;
            s[1].Rows[3][11] = 12;
            s[1].Rows[3][12] = 0;
            s[1].Rows[3][13] = 5;
            s[1].Rows[3][14] = 14;
            s[1].Rows[3][15] = 9;
        }
        private void khoitao_s2()
        {
            int i;
            s[2] = new DataTable();
            for (i = 0; i <= 15; i++)
            {
                DataColumn col = new DataColumn();
                s[2].Columns.Add(col);
            }
            for (i = 0; i <= 3; i++)
            {
                DataRow row = s[2].NewRow();
                s[2].Rows.Add(row);
            }
            s[2].Rows[0][0] = 10;
            s[2].Rows[0][1] = 0;
            s[2].Rows[0][2] = 9;
            s[2].Rows[0][3] = 14;
            s[2].Rows[0][4] = 6;
            s[2].Rows[0][5] = 3;
            s[2].Rows[0][6] = 15;
            s[2].Rows[0][7] = 5;
            s[2].Rows[0][8] = 1;
            s[2].Rows[0][9] = 13;
            s[2].Rows[0][10] = 12;
            s[2].Rows[0][11] = 7;
            s[2].Rows[0][12] = 11;
            s[2].Rows[0][13] = 4;
            s[2].Rows[0][14] = 2;
            s[2].Rows[0][15] = 8;
            s[2].Rows[1][0] = 13;
            s[2].Rows[1][1] = 7;
            s[2].Rows[1][2] = 0;
            s[2].Rows[1][3] = 9;
            s[2].Rows[1][4] = 3;
            s[2].Rows[1][5] = 4;
            s[2].Rows[1][6] = 6;
            s[2].Rows[1][7] = 10;
            s[2].Rows[1][8] = 2;
            s[2].Rows[1][9] = 8;
            s[2].Rows[1][10] = 5;
            s[2].Rows[1][11] = 14;
            s[2].Rows[1][12] = 12;
            s[2].Rows[1][13] = 11;
            s[2].Rows[1][14] = 15;
            s[2].Rows[1][15] = 1;
            s[2].Rows[2][0] = 13;
            s[2].Rows[2][1] = 6;
            s[2].Rows[2][2] = 4;
            s[2].Rows[2][3] = 9;
            s[2].Rows[2][4] = 8;
            s[2].Rows[2][5] = 15;
            s[2].Rows[2][6] = 3;
            s[2].Rows[2][7] = 0;
            s[2].Rows[2][8] = 11;
            s[2].Rows[2][9] = 1;
            s[2].Rows[2][10] = 2;
            s[2].Rows[2][11] = 12;
            s[2].Rows[2][12] = 5;
            s[2].Rows[2][13] = 10;
            s[2].Rows[2][14] = 14;
            s[2].Rows[2][15] = 7;
            s[2].Rows[3][0] = 1;
            s[2].Rows[3][1] = 10;
            s[2].Rows[3][2] = 13;
            s[2].Rows[3][3] = 0;
            s[2].Rows[3][4] = 6;
            s[2].Rows[3][5] = 9;
            s[2].Rows[3][6] = 8;
            s[2].Rows[3][7] = 7;
            s[2].Rows[3][8] = 4;
            s[2].Rows[3][9] = 15;
            s[2].Rows[3][10] = 14;
            s[2].Rows[3][11] = 3;
            s[2].Rows[3][12] = 11;
            s[2].Rows[3][13] = 5;
            s[2].Rows[3][14] = 3;
            s[2].Rows[3][15] = 12;
        }
        private void khoitao_s3()
        {
            int i;
            s[3] = new DataTable();
            for (i = 0; i <= 15; i++)
            {
                DataColumn col = new DataColumn();
                s[3].Columns.Add(col);
            }
            for (i = 0; i <= 3; i++)
            {
                DataRow row = s[3].NewRow();
                s[3].Rows.Add(row);
            }
            s[3].Rows[0][0] = 7;
            s[3].Rows[0][1] = 13;
            s[3].Rows[0][2] = 14;
            s[3].Rows[0][3] = 3;
            s[3].Rows[0][4] = 0;
            s[3].Rows[0][5] = 6;
            s[3].Rows[0][6] = 9;
            s[3].Rows[0][7] = 10;
            s[3].Rows[0][8] = 1;
            s[3].Rows[0][9] = 2;
            s[3].Rows[0][10] = 8;
            s[3].Rows[0][11] = 5;
            s[3].Rows[0][12] = 11;
            s[3].Rows[0][13] = 12;
            s[3].Rows[0][14] = 4;
            s[3].Rows[0][15] = 15;
            s[3].Rows[1][0] = 13;
            s[3].Rows[1][1] = 8;
            s[3].Rows[1][2] = 11;
            s[3].Rows[1][3] = 5;
            s[3].Rows[1][4] = 6;
            s[3].Rows[1][5] = 15;
            s[3].Rows[1][6] = 0;
            s[3].Rows[1][7] = 3;
            s[3].Rows[1][8] = 4;
            s[3].Rows[1][9] = 7;
            s[3].Rows[1][10] = 2;
            s[3].Rows[1][11] = 12;
            s[3].Rows[1][12] = 1;
            s[3].Rows[1][13] = 10;
            s[3].Rows[1][14] = 14;
            s[3].Rows[1][15] = 9;
            s[3].Rows[2][0] = 10;
            s[3].Rows[2][1] = 6;
            s[3].Rows[2][2] = 9;
            s[3].Rows[2][3] = 0;
            s[3].Rows[2][4] = 12;
            s[3].Rows[2][5] = 11;
            s[3].Rows[2][6] = 7;
            s[3].Rows[2][7] = 13;
            s[3].Rows[2][8] = 15;
            s[3].Rows[2][9] = 1;
            s[3].Rows[2][10] = 3;
            s[3].Rows[2][11] = 14;
            s[3].Rows[2][12] = 5;
            s[3].Rows[2][13] = 2;
            s[3].Rows[2][14] = 8;
            s[3].Rows[2][15] = 4;
            s[3].Rows[3][0] = 3;
            s[3].Rows[3][1] = 15;
            s[3].Rows[3][2] = 0;
            s[3].Rows[3][3] = 6;
            s[3].Rows[3][4] = 10;
            s[3].Rows[3][5] = 1;
            s[3].Rows[3][6] = 13;
            s[3].Rows[3][7] = 8;
            s[3].Rows[3][8] = 9;
            s[3].Rows[3][9] = 4;
            s[3].Rows[3][10] = 5;
            s[3].Rows[3][11] = 11;
            s[3].Rows[3][12] = 12;
            s[3].Rows[3][13] = 7;
            s[3].Rows[3][14] = 2;
            s[3].Rows[3][15] = 14;
        }
        private void khoitao_s4()
        {
            int i;
            s[4] = new DataTable();
            for (i = 0; i <= 15; i++)
            {
                DataColumn col = new DataColumn();
                s[4].Columns.Add(col);
            }
            for (i = 0; i <= 3; i++)
            {
                DataRow row = s[4].NewRow();
                s[4].Rows.Add(row);
            }
            s[4].Rows[0][0] = 2;
            s[4].Rows[0][1] = 12;
            s[4].Rows[0][2] = 4;
            s[4].Rows[0][3] = 1;
            s[4].Rows[0][4] = 7;
            s[4].Rows[0][5] = 10;
            s[4].Rows[0][6] = 11;
            s[4].Rows[0][7] = 6;
            s[4].Rows[0][8] = 8;
            s[4].Rows[0][9] = 5;
            s[4].Rows[0][10] = 3;
            s[4].Rows[0][11] = 15;
            s[4].Rows[0][12] = 13;
            s[4].Rows[0][13] = 0;
            s[4].Rows[0][14] = 14;
            s[4].Rows[0][15] = 9;
            s[4].Rows[1][0] = 14;
            s[4].Rows[1][1] = 11;
            s[4].Rows[1][2] = 2;
            s[4].Rows[1][3] = 12;
            s[4].Rows[1][4] = 4;
            s[4].Rows[1][5] = 7;
            s[4].Rows[1][6] = 13;
            s[4].Rows[1][7] = 1;
            s[4].Rows[1][8] = 5;
            s[4].Rows[1][9] = 0;
            s[4].Rows[1][10] = 15;
            s[4].Rows[1][11] = 10;
            s[4].Rows[1][12] = 3;
            s[4].Rows[1][13] = 9;
            s[4].Rows[1][14] = 8;
            s[4].Rows[1][15] = 6;
            s[4].Rows[2][0] = 4;
            s[4].Rows[2][1] = 2;
            s[4].Rows[2][2] = 1;
            s[4].Rows[2][3] = 11;
            s[4].Rows[2][4] = 10;
            s[4].Rows[2][5] = 13;
            s[4].Rows[2][6] = 7;
            s[4].Rows[2][7] = 8;
            s[4].Rows[2][8] = 15;
            s[4].Rows[2][9] = 9;
            s[4].Rows[2][10] = 12;
            s[4].Rows[2][11] = 5;
            s[4].Rows[2][12] = 6;
            s[4].Rows[2][13] = 3;
            s[4].Rows[2][14] = 0;
            s[4].Rows[2][15] = 14;
            s[4].Rows[3][0] = 11;
            s[4].Rows[3][1] = 8;
            s[4].Rows[3][2] = 12;
            s[4].Rows[3][3] = 7;
            s[4].Rows[3][4] = 0;
            s[4].Rows[3][5] = 14;
            s[4].Rows[3][6] = 2;
            s[4].Rows[3][7] = 13;
            s[4].Rows[3][8] = 6;
            s[4].Rows[3][9] = 15;
            s[4].Rows[3][10] = 0;
            s[4].Rows[3][11] = 9;
            s[4].Rows[3][12] = 10;
            s[4].Rows[3][13] = 4;
            s[4].Rows[3][14] = 5;
            s[4].Rows[3][15] = 3;
        }
        private void khoitao_s5()
        {
            int i;
            s[5] = new DataTable();
            for (i = 0; i <= 15; i++)
            {
                DataColumn col = new DataColumn();
                s[5].Columns.Add(col);
            }
            for (i = 0; i <= 3; i++)
            {
                DataRow row = s[5].NewRow();
                s[5].Rows.Add(row);
            }
            s[5].Rows[0][0] = 12;
            s[5].Rows[0][1] = 1;
            s[5].Rows[0][2] = 10;
            s[5].Rows[0][3] = 15;
            s[5].Rows[0][4] = 9;
            s[5].Rows[0][5] = 2;
            s[5].Rows[0][6] = 6;
            s[5].Rows[0][7] = 8;
            s[5].Rows[0][8] = 0;
            s[5].Rows[0][9] = 13;
            s[5].Rows[0][10] = 3;
            s[5].Rows[0][11] = 4;
            s[5].Rows[0][12] = 14;
            s[5].Rows[0][13] = 7;
            s[5].Rows[0][14] = 5;
            s[5].Rows[0][15] = 11;
            s[5].Rows[1][0] = 10;
            s[5].Rows[1][1] = 15;
            s[5].Rows[1][2] = 4;
            s[5].Rows[1][3] = 2;
            s[5].Rows[1][4] = 7;
            s[5].Rows[1][5] = 12;
            s[5].Rows[1][6] = 9;
            s[5].Rows[1][7] = 5;
            s[5].Rows[1][8] = 6;
            s[5].Rows[1][9] = 1;
            s[5].Rows[1][10] = 13;
            s[5].Rows[1][11] = 14;
            s[5].Rows[1][12] = 0;
            s[5].Rows[1][13] = 11;
            s[5].Rows[1][14] = 3;
            s[5].Rows[1][15] = 8;
            s[5].Rows[2][0] = 9;
            s[5].Rows[2][1] = 14;
            s[5].Rows[2][2] = 15;
            s[5].Rows[2][3] = 5;
            s[5].Rows[2][4] = 2;
            s[5].Rows[2][5] = 8;
            s[5].Rows[2][6] = 12;
            s[5].Rows[2][7] = 3;
            s[5].Rows[2][8] = 7;
            s[5].Rows[2][9] = 0;
            s[5].Rows[2][10] = 4;
            s[5].Rows[2][11] = 10;
            s[5].Rows[2][12] = 1;
            s[5].Rows[2][13] = 13;
            s[5].Rows[2][14] = 11;
            s[5].Rows[2][15] = 6;
            s[5].Rows[3][0] = 4;
            s[5].Rows[3][1] = 3;
            s[5].Rows[3][2] = 2;
            s[5].Rows[3][3] = 12;
            s[5].Rows[3][4] = 9;
            s[5].Rows[3][5] = 5;
            s[5].Rows[3][6] = 15;
            s[5].Rows[3][7] = 10;
            s[5].Rows[3][8] = 11;
            s[5].Rows[3][9] = 14;
            s[5].Rows[3][10] = 1;
            s[5].Rows[3][11] = 7;
            s[5].Rows[3][12] = 6;
            s[5].Rows[3][13] = 0;
            s[5].Rows[3][14] = 8;
            s[5].Rows[3][15] = 13;
        }
        private void khoitao_s6()
        {
            int i;
            s[6] = new DataTable();
            for (i = 0; i <= 15; i++)
            {
                DataColumn col = new DataColumn();
                s[6].Columns.Add(col);
            }
            for (i = 0; i <= 3; i++)
            {
                DataRow row = s[6].NewRow();
                s[6].Rows.Add(row);
            }
            s[6].Rows[0][0] = 4;
            s[6].Rows[0][1] = 11;
            s[6].Rows[0][2] = 2;
            s[6].Rows[0][3] = 14;
            s[6].Rows[0][4] = 15;
            s[6].Rows[0][5] = 0;
            s[6].Rows[0][6] = 8;
            s[6].Rows[0][7] = 13;
            s[6].Rows[0][8] = 3;
            s[6].Rows[0][9] = 12;
            s[6].Rows[0][10] = 9;
            s[6].Rows[0][11] = 7;
            s[6].Rows[0][12] = 5;
            s[6].Rows[0][13] = 10;
            s[6].Rows[0][14] = 6;
            s[6].Rows[0][15] = 1;
            s[6].Rows[1][0] = 13;
            s[6].Rows[1][1] = 0;
            s[6].Rows[1][2] = 11;
            s[6].Rows[1][3] = 7;
            s[6].Rows[1][4] = 4;
            s[6].Rows[1][5] = 9;
            s[6].Rows[1][6] = 1;
            s[6].Rows[1][7] = 10;
            s[6].Rows[1][8] = 14;
            s[6].Rows[1][9] = 3;
            s[6].Rows[1][10] = 5;
            s[6].Rows[1][11] = 12;
            s[6].Rows[1][12] = 2;
            s[6].Rows[1][13] = 15;
            s[6].Rows[1][14] = 8;
            s[6].Rows[1][15] = 6;
            s[6].Rows[2][0] = 1;
            s[6].Rows[2][1] = 4;
            s[6].Rows[2][2] = 11;
            s[6].Rows[2][3] = 13;
            s[6].Rows[2][4] = 12;
            s[6].Rows[2][5] = 3;
            s[6].Rows[2][6] = 7;
            s[6].Rows[2][7] = 14;
            s[6].Rows[2][8] = 10;
            s[6].Rows[2][9] = 15;
            s[6].Rows[2][10] = 6;
            s[6].Rows[2][11] = 8;
            s[6].Rows[2][12] = 0;
            s[6].Rows[2][13] = 5;
            s[6].Rows[2][14] = 9;
            s[6].Rows[2][15] = 2;
            s[6].Rows[3][0] = 6;
            s[6].Rows[3][1] = 11;
            s[6].Rows[3][2] = 13;
            s[6].Rows[3][3] = 8;
            s[6].Rows[3][4] = 1;
            s[6].Rows[3][5] = 4;
            s[6].Rows[3][6] = 10;
            s[6].Rows[3][7] = 7;
            s[6].Rows[3][8] = 9;
            s[6].Rows[3][9] = 5;
            s[6].Rows[3][10] = 0;
            s[6].Rows[3][11] = 15;
            s[6].Rows[3][12] = 14;
            s[6].Rows[3][13] = 2;
            s[6].Rows[3][14] = 3;
            s[6].Rows[3][15] = 12;
            //dgs6.DataSource = s[6];
        }
        private void khoitao_s7()
        {
            int i;
            s[7] = new DataTable();
            for (i = 0; i <= 15; i++)
            {
                DataColumn col = new DataColumn();
                s[7].Columns.Add(col);
            }
            for (i = 0; i <= 3; i++)
            {
                DataRow row = s[7].NewRow();
                s[7].Rows.Add(row);
            }
            s[7].Rows[0][0] = 13;
            s[7].Rows[0][1] = 2;
            s[7].Rows[0][2] = 8;
            s[7].Rows[0][3] = 4;
            s[7].Rows[0][4] = 6;
            s[7].Rows[0][5] = 15;
            s[7].Rows[0][6] = 11;
            s[7].Rows[0][7] = 1;
            s[7].Rows[0][8] = 10;
            s[7].Rows[0][9] = 9;
            s[7].Rows[0][10] = 3;
            s[7].Rows[0][11] = 14;
            s[7].Rows[0][12] = 5;
            s[7].Rows[0][13] = 0;
            s[7].Rows[0][14] = 12;
            s[7].Rows[0][15] = 7;
            s[7].Rows[1][0] = 1;
            s[7].Rows[1][1] = 15;
            s[7].Rows[1][2] = 13;
            s[7].Rows[1][3] = 8;
            s[7].Rows[1][4] = 10;
            s[7].Rows[1][5] = 3;
            s[7].Rows[1][6] = 7;
            s[7].Rows[1][7] = 4;
            s[7].Rows[1][8] = 12;
            s[7].Rows[1][9] = 5;
            s[7].Rows[1][10] = 6;
            s[7].Rows[1][11] = 11;
            s[7].Rows[1][12] = 0;
            s[7].Rows[1][13] = 14;
            s[7].Rows[1][14] = 9;
            s[7].Rows[1][15] = 2;
            s[7].Rows[2][0] = 7;
            s[7].Rows[2][1] = 11;
            s[7].Rows[2][2] = 4;
            s[7].Rows[2][3] = 1;
            s[7].Rows[2][4] = 9;
            s[7].Rows[2][5] = 12;
            s[7].Rows[2][6] = 14;
            s[7].Rows[2][7] = 2;
            s[7].Rows[2][8] = 0;
            s[7].Rows[2][9] = 6;
            s[7].Rows[2][10] = 10;
            s[7].Rows[2][11] = 13;
            s[7].Rows[2][12] = 15;
            s[7].Rows[2][13] = 3;
            s[7].Rows[2][14] = 5;
            s[7].Rows[2][15] = 8;
            s[7].Rows[3][0] = 2;
            s[7].Rows[3][1] = 1;
            s[7].Rows[3][2] = 14;
            s[7].Rows[3][3] = 7;
            s[7].Rows[3][4] = 4;
            s[7].Rows[3][5] = 10;
            s[7].Rows[3][6] = 8;
            s[7].Rows[3][7] = 13;
            s[7].Rows[3][8] = 15;
            s[7].Rows[3][9] = 12;
            s[7].Rows[3][10] = 9;
            s[7].Rows[3][11] = 0;
            s[7].Rows[3][12] = 3;
            s[7].Rows[3][13] = 5;
            s[7].Rows[3][14] = 6;
            s[7].Rows[3][15] = 11;
            //dgs7.DataSource = s[7];
        }
    }
}
