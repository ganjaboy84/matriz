using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz
{
    class Matriz
    {
        int[,] mat = new int[6, 6];

        public void Llenar()
        {
            int x = 1;
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    mat[f,c] = x++;

                }
            }
        }
        public void LlenarXC()
        {
            int x = 1;
            for (int c = 0; c < mat.GetLength(1); c++)
            {
                for (int f = 0; f < mat.GetLength(0); f++)
                {
                    mat[f, c] = x++;
                }
            }
        }
        public void LlenarInv()
        {
            int x = 36;                    
            for (int f = 5; f>=0; f--)
            {
                for (int c = 5; c>=0; c--)
                {
                   mat[f, c] = x--;
                }
            }
        }
        public string Mostrar()
        {
            string matriz="";
            for(int f=0;f<mat.GetLength(0);f++)
            {
                for(int c=0; c<mat.GetLength(1);c++)
                {
                    matriz += mat[f, c] + " ";
                }
                matriz += Environment.NewLine;
            }
            return matriz;
        }
        public string mostrarDP()
        {
            string diaP = "";
            int c;
            for(int f=0;f<mat.GetLength(0);f++)
            {
                c = f;
                diaP += mat[f, c];
            }
            return diaP;
        }
        public string MostrarDS()
        {
            string diaSec = "";
            int c= mat.GetLength(1)-1;
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                diaSec += mat[f, c];
                c--;
            }
            return diaSec;
        }
        public string MostrarArDS()
        {
            string arDS = "";
            int vaux = mat.GetLength(1) - 2;
            for(int f=0; f<=mat.GetLength(0);f++)
            {
                for(int c=0;c<=vaux;c++)
                {
                    arDS += mat[f, c];
                }
                vaux--;
            }
            return arDS;
        }
        public string MostrarAbDP()
        {
            string abDP="";
            int vAux = 0;
            for(int f=1;f<mat.GetLength(0); f++)
            {
                for(int c=0;c<=vAux;c++)
                {
                    abDP += mat[f, c];
                }
                vAux++;
            }
            return abDP;
        }
        public void girarDP()
        {
            int vAux = 0;
            int x = 0;
            int f2 = 0,c2=0;
            for(int f=1;f<mat.GetLength(0);f++)
            {
                for(int c=0;c<=x;c++)
                {
                    f2 = c;
                    c2 = f;
                    vAux = mat[f2, c2];
                    mat[f2, c2] = mat[f, c];
                    mat[f, c] = vAux;
                }
                x++;
            }
        }
        public void girarDS()
        {
            int vAux = 0;
            int y = mat.GetLength(0) - 2;
            int lim = y;
            
            for(int c=0;c<lim;c++)
            {
                int x = lim;
                for (int f=0;f<lim;f++)
                {
                    vAux = mat[y, x];
                    mat[y, x] = mat[f, c];
                    mat[f, c] = vAux;
                    x--;
                }
                y--;

            }
        }


               
    }
}

//llenar inversa, mostrar dp, mostrar ds, mostrar abajo DP, mostrar arriba DS