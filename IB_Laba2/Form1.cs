using System.Text.Encodings.Web;

namespace IB_Laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str1 = "�������������������� �����Ũ������";
        string str2 = "������������������������������� ��";
        string str3 = "������������������� �����֨�������";
        string str4 = "�����Ũ�������������������������� ";
        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string text = textBox1.Text;
                string str = "";
                int a = 1;
                if (text.Length % 5 != 0)
                {
                    do
                    {
                        text += " ";

                    } while (text.Length % 5 != 0);
                }
                for (int i = 0; i < text.Length; i++)
                {
                    if (a==6)
                    {
                        a = 1;
                    }
                    if (a == 1)
                    {
                        str += text[i + 1];
                    }
                    else if (a == 2)
                    {
                        str += text[i + 3];
                    }
                    else if (a == 3)
                    {
                        str += text[i + 1];
                    }
                    else if (a == 4)
                    {
                        str += text[i - 1];
                    }
                    else if (a == 5)
                    {
                        str += text[i - 4];
                    }
                    a++;
                }
                textBox2.Text = str;
            }
            if (radioButton2.Checked)
            {
                string text = textBox1.Text;
                string decodedText = Encode2(text);
                textBox2.Text = decodedText;
            }
            if (radioButton3.Checked)
            {
                string text = ""; 
                int k = 1;
                for (int i =0; i < textBox1.Text.Length; i++)
                {
                    if (k == 4)
                    {
                        k = 1;
                    }
                    if (k==1)
                    {
                        for (int j = 0; j < str1.Length; j++)
                        {
                            if (textBox1.Text[i] == str4[j])
                            {
                                text += str1[j];
                                break;
                            }
                        }
                        
                    } else if (k == 2)
                    {
                        for (int j = 0; j < str1.Length; j++)
                        {
                            if (textBox1.Text[i] == str4[j])
                            {
                                text += str2[j];
                                break;
                            }
                        }
                    }
                    else if (k == 3)
                    {
                        for (int j = 0; j < str1.Length; j++)
                        {
                            if (textBox1.Text[i] == str4[j])
                            {
                                text += str3[j];
                                break;
                            }
                        }
                    }
                    k++;
                }
                textBox2.Text = text;
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string text = textBox1.Text;
                string str = "";
                int a = 1;
                if (text.Length % 5 != 0)
                {
                    do
                    {
                        text += " ";

                    } while (text.Length % 5 != 0);
                }
                for (int i = 0; i < text.Length; i++)
                {
                    if (a == 6)
                    {
                        a = 1;
                    }
                    if (a == 1)
                    {
                        str += text[i + 4];
                    }
                    else if (a == 2)
                    {
                        str += text[i - 1];
                    }
                    else if (a == 3)
                    {
                        str += text[i + 1];
                    }
                    else if (a == 4)
                    {
                        str += text[i - 1];
                    }
                    else if (a == 5)
                    {
                        str += text[i - 3];
                    }
                    a++;
                }
                textBox2.Text = str;
            }
            if (radioButton2.Checked)
            {
                string text = textBox1.Text;
                string decodedText = Decode2(text);
                textBox2.Text = decodedText;
            }
            if (radioButton3.Checked)
            {
                string text = "";
                int k = 1;
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (k == 4)
                    {
                        k = 1;
                    }
                    if (k == 1)
                    {
                        for (int j = 0; j < str1.Length; j++)
                        {
                            if (textBox1.Text[i] == str1[j])
                            {
                                text += str4[j];
                                break;
                            }
                        }

                    }
                    else if (k == 2)
                    {
                        for (int j = 0; j < str1.Length; j++)
                        {
                            if (textBox1.Text[i] == str2[j])
                            {
                                text += str4[j];
                                break;
                            }
                        }
                    }
                    else if (k == 3)
                    {
                        for (int j = 0; j < str1.Length; j++)
                        {
                            if (textBox1.Text[i] == str3[j])
                            {
                                text += str4[j];
                                break;
                            }
                        }
                    }
                    k++;
                }
                textBox2.Text = text;
            }
            
        }
        private string Encode2(string text)
        {
            char[] tempArray = text.ToCharArray();
            for (int i = 0; i < tempArray.Length; i++)
            {
                switch (tempArray[i])
                {
                    case '�':
                        tempArray[i] = 'V';
                        break;
                    case '�':
                        tempArray[i] = 'W';
                        break;
                    case '�':
                        tempArray[i] = 'X';
                        break;
                    case '�':
                        tempArray[i] = 'Y';
                        break;
                    case '�':
                        tempArray[i] = 'Z';
                        break;
                    case '�':
                        tempArray[i] = ' ';
                        break;
                    case '�':
                        tempArray[i] = '.';
                        break;
                    case '�':
                        tempArray[i] = ',';
                        break;
                    case '�':
                        tempArray[i] = '!';
                        break;
                    case '�':
                        tempArray[i] = ':';
                        break;
                    case '�':
                        tempArray[i] = ';';
                        break;
                    case '�':
                        tempArray[i] = '?';
                        break;
                    case '�':
                        tempArray[i] = '-';
                        break;
                    case '�':
                        tempArray[i] = 'K';
                        break;
                    case '�':
                        tempArray[i] = 'L';
                        break;
                    case '�':
                        tempArray[i] = 'M';
                        break;
                    case '�':
                        tempArray[i] = 'N';
                        break;
                    case '�':
                        tempArray[i] = 'O';
                        break;
                    case '�':
                        tempArray[i] = 'P';
                        break;
                    case '�':
                        tempArray[i] = 'Q';
                        break;
                    case ' ':
                        tempArray[i] = 'R';
                        break;
                    case '�':
                        tempArray[i] = 'S';
                        break;
                    case '�':
                        tempArray[i] = 'T';
                        break;
                    case '�':
                        tempArray[i] = 'U';
                        break;
                    case '�':
                        tempArray[i] = 'A';
                        break;
                    case '�':
                        tempArray[i] = 'B';
                        break;
                    case '�':
                        tempArray[i] = 'C';
                        break;
                    case '�':
                        tempArray[i] = 'D';
                        break;
                    case '�':
                        tempArray[i] = 'E';
                        break;
                    case '�':
                        tempArray[i] = 'F';
                        break;
                    case '�':
                        tempArray[i] = 'G';
                        break;
                    case '�':
                        tempArray[i] = 'H';
                        break;
                    case '�':
                        tempArray[i] = 'I';
                        break;
                    case '�':
                        tempArray[i] = 'J';
                        break;
                }
            }
            return new string(tempArray);
        }
        private string Decode1(string text)
        {
            string input = textBox1.Text;
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                switch (i % 5)
                {
                    case 0:
                        output += input[i + 4 >= input.Length ? i - 1 : i + 4];
                        break;
                    case 1:
                        output += input[i + 4 >= input.Length ? i - 1 : i + 4];
                        break;
                    case 2:
                        output += input[i + 1 >= input.Length ? i - 4 : i + 1];
                        break;
                    case 3:
                        output += input[i + 4 >= input.Length ? i - 1 : i + 4];
                        break;
                    case 4:
                        output += input[i + 2 >= input.Length ? i - 3 : i + 2];
                        break;
                }
            }
            textBox2.Text = output;
            return new string(output);
        }
            private string Decode2(string text)
        {
            char[] tempArray = text.ToCharArray();
            for (int i = 0; i < tempArray.Length; i++)
            {
                switch (tempArray[i])
                {
                    case 'v':
                        tempArray[i] = '�';
                        break;
                    case 'W':
                        tempArray[i] = '�';
                        break;
                    case 'X':
                        tempArray[i] = '�';
                        break;
                    case 'Y':
                        tempArray[i] = '�';
                        break;
                    case 'Z':
                        tempArray[i] = '�';
                        break;
                    case ' ':
                        tempArray[i] = '�';
                        break;
                    case '.':
                        tempArray[i] = '�';
                        break;
                    case ',':
                        tempArray[i] = '�';
                        break;
                    case '!':
                        tempArray[i] = '�';
                        break;
                    case ':':
                        tempArray[i] = '�';
                        break;
                    case ';':
                        tempArray[i] = '�';
                        break;
                    case '?':
                        tempArray[i] = '�';
                        break;
                    case '-':
                        tempArray[i] = '�';
                        break;
                    case 'K':
                        tempArray[i] = '�';
                        break;
                    case 'L':
                        tempArray[i] = '�';
                        break;
                    case 'M':
                        tempArray[i] = '�';
                        break;
                    case 'N':
                        tempArray[i] = '�';
                        break;
                    case 'O':
                        tempArray[i] = '�';
                        break;
                    case 'P':
                        tempArray[i] = '�';
                        break;
                    case 'Q':
                        tempArray[i] = '�';
                        break;
                    case 'R':
                        tempArray[i] = ' ';
                        break;
                    case 'S':
                        tempArray[i] = '�';
                        break;
                    case 'T':
                        tempArray[i] = '�';
                        break;
                    case 'U':
                        tempArray[i] = '�';
                        break;
                    case 'A':
                        tempArray[i] = '�';
                        break;
                    case 'B':
                        tempArray[i] = '�';
                        break;
                    case 'C':
                        tempArray[i] = '�';
                        break;
                    case 'D':
                        tempArray[i] = '�';
                        break;
                    case 'E':
                        tempArray[i] = '�';
                        break;
                    case 'F':
                        tempArray[i] = '�';
                        break;
                    case 'G':
                        tempArray[i] = '�';
                        break;
                    case 'H':
                        tempArray[i] = '�';
                        break;
                    case 'I':
                        tempArray[i] = '�';
                        break;
                    case 'J':
                        tempArray[i] = '�';
                        break;
                }
            }
            return new string(tempArray);
        }
    }
}