using System.Text.Encodings.Web;

namespace IB_Laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str1 = "лмнопярстужвьызэшщчъ юабцде╗фгхийк";
        string str2 = "ачцшеэгьижктмропянслуйвхыфздщбъ ю╗";
        string str3 = "янслйувхыфздщбъюачц еэгьиж╗тмропшк";
        string str4 = "юабцде╗фгхийклмнопярстужвьызшэщчъ ";
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
                    case 'л':
                        tempArray[i] = 'V';
                        break;
                    case 'м':
                        tempArray[i] = 'W';
                        break;
                    case 'н':
                        tempArray[i] = 'X';
                        break;
                    case 'о':
                        tempArray[i] = 'Y';
                        break;
                    case 'п':
                        tempArray[i] = 'Z';
                        break;
                    case 'я':
                        tempArray[i] = ' ';
                        break;
                    case 'р':
                        tempArray[i] = '.';
                        break;
                    case 'с':
                        tempArray[i] = ',';
                        break;
                    case 'т':
                        tempArray[i] = '!';
                        break;
                    case 'у':
                        tempArray[i] = ':';
                        break;
                    case 'ж':
                        tempArray[i] = ';';
                        break;
                    case 'в':
                        tempArray[i] = '?';
                        break;
                    case 'ь':
                        tempArray[i] = '-';
                        break;
                    case 'ы':
                        tempArray[i] = 'K';
                        break;
                    case 'з':
                        tempArray[i] = 'L';
                        break;
                    case 'э':
                        tempArray[i] = 'M';
                        break;
                    case 'ш':
                        tempArray[i] = 'N';
                        break;
                    case 'щ':
                        tempArray[i] = 'O';
                        break;
                    case 'ч':
                        tempArray[i] = 'P';
                        break;
                    case 'ъ':
                        tempArray[i] = 'Q';
                        break;
                    case ' ':
                        tempArray[i] = 'R';
                        break;
                    case 'ю':
                        tempArray[i] = 'S';
                        break;
                    case 'а':
                        tempArray[i] = 'T';
                        break;
                    case 'б':
                        tempArray[i] = 'U';
                        break;
                    case 'ц':
                        tempArray[i] = 'A';
                        break;
                    case 'д':
                        tempArray[i] = 'B';
                        break;
                    case 'е':
                        tempArray[i] = 'C';
                        break;
                    case '╗':
                        tempArray[i] = 'D';
                        break;
                    case 'ф':
                        tempArray[i] = 'E';
                        break;
                    case 'г':
                        tempArray[i] = 'F';
                        break;
                    case 'х':
                        tempArray[i] = 'G';
                        break;
                    case 'и':
                        tempArray[i] = 'H';
                        break;
                    case 'й':
                        tempArray[i] = 'I';
                        break;
                    case 'к':
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
                        tempArray[i] = 'л';
                        break;
                    case 'W':
                        tempArray[i] = 'м';
                        break;
                    case 'X':
                        tempArray[i] = 'н';
                        break;
                    case 'Y':
                        tempArray[i] = 'о';
                        break;
                    case 'Z':
                        tempArray[i] = 'п';
                        break;
                    case ' ':
                        tempArray[i] = 'я';
                        break;
                    case '.':
                        tempArray[i] = 'р';
                        break;
                    case ',':
                        tempArray[i] = 'с';
                        break;
                    case '!':
                        tempArray[i] = 'т';
                        break;
                    case ':':
                        tempArray[i] = 'у';
                        break;
                    case ';':
                        tempArray[i] = 'ж';
                        break;
                    case '?':
                        tempArray[i] = 'в';
                        break;
                    case '-':
                        tempArray[i] = 'ь';
                        break;
                    case 'K':
                        tempArray[i] = 'ы';
                        break;
                    case 'L':
                        tempArray[i] = 'з';
                        break;
                    case 'M':
                        tempArray[i] = 'э';
                        break;
                    case 'N':
                        tempArray[i] = 'ш';
                        break;
                    case 'O':
                        tempArray[i] = 'щ';
                        break;
                    case 'P':
                        tempArray[i] = 'ч';
                        break;
                    case 'Q':
                        tempArray[i] = 'ъ';
                        break;
                    case 'R':
                        tempArray[i] = ' ';
                        break;
                    case 'S':
                        tempArray[i] = 'ю';
                        break;
                    case 'T':
                        tempArray[i] = 'а';
                        break;
                    case 'U':
                        tempArray[i] = 'б';
                        break;
                    case 'A':
                        tempArray[i] = 'ц';
                        break;
                    case 'B':
                        tempArray[i] = 'д';
                        break;
                    case 'C':
                        tempArray[i] = 'е';
                        break;
                    case 'D':
                        tempArray[i] = '╗';
                        break;
                    case 'E':
                        tempArray[i] = 'ф';
                        break;
                    case 'F':
                        tempArray[i] = 'г';
                        break;
                    case 'G':
                        tempArray[i] = 'х';
                        break;
                    case 'H':
                        tempArray[i] = 'и';
                        break;
                    case 'I':
                        tempArray[i] = 'й';
                        break;
                    case 'J':
                        tempArray[i] = 'к';
                        break;
                }
            }
            return new string(tempArray);
        }
    }
}