using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    public partial class ParallelSortingForm : Form
    {
        static System.Threading.Timer timer;
        public ParallelSortingForm()
        {
            InitializeComponent();
            errorLabel.Text = "";
            binFound.Text = "";
            seqFound.Text = "";
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            bool isValidated = formValidations();

            if (!isValidated)
            {
                timer = new System.Threading.Timer((e) =>
                {
                    errorLabel.Invoke((MethodInvoker)delegate
                    {
                        errorLabel.Text = "";
                    });
                }, null, 3000, Timeout.Infinite);
                return;
            }

            errorLabel.Text = "";
            int[] array = obtainArray();
            int target = Convert.ToInt32(toSearchNumber.Text);

            Stopwatch seqStopwatch = new Stopwatch();
            Stopwatch binStopwatch = new Stopwatch();
            Stopwatch bubbleStopwatch = new Stopwatch();
            Stopwatch quickStopwatch = new Stopwatch();
            Stopwatch insertionStopwatch = new Stopwatch();

            Thread seqSearchThread = new Thread(() => executeSeq(array, target, seqStopwatch));
            Thread binSearchThread = new Thread(() => executeBin(array, target, binStopwatch));
            Thread bubbleThread = new Thread(() => executeBubble(array, bubbleStopwatch));
            Thread quickSortThread = new Thread(() => executeQuick(array, quickStopwatch));
            Thread insertionThread = new Thread(() => executeInsertion(array, insertionStopwatch));

            seqSearchThread.Start();
            binSearchThread.Start();
            bubbleThread.Start();
            quickSortThread.Start();
            insertionThread.Start();

            sortButton.Enabled = false;
        }

        private void executeSeq(int[] array, int target, Stopwatch stopwatch)
        {
            stopwatch.Start();
            Algorithms.BusquedaSecuencial(array, target);
            stopwatch.Stop();
            double time = (double)(stopwatch.ElapsedTicks * 1000) / Stopwatch.Frequency;
            seqTime.Invoke((MethodInvoker)delegate
            {
                seqTime.Text = $"{time} ms"; // Mostrar tiempo en segundos con nueve decimales
            });
            bool found = Algorithms.BusquedaSecuencial(array, target);
            seqFound.Invoke((MethodInvoker)delegate
            {
                if (found)
                {
                    seqFound.Text = "Encontrado";
                    seqFound.ForeColor = Color.Green;
                }
                else
                {
                    seqFound.Text = "No encontrado";
                    seqFound.ForeColor = Color.Red;
                }
            });
        }

        private void executeBin(int[] array, int target, Stopwatch stopwatch)
        {
            stopwatch.Start();
            Algorithms.BusquedaBinaria(array, target);
            stopwatch.Stop();
            double time = (double)(stopwatch.ElapsedTicks * 1000) / Stopwatch.Frequency;
            binTime.Invoke((MethodInvoker)delegate
            {
                binTime.Text = $"{time} ms"; // Mostrar tiempo en segundos con nueve decimales
            });
            bool found = Algorithms.BusquedaBinaria(array, target);
            binFound.Invoke((MethodInvoker)delegate
            {
                if (found)
                {
                    binFound.Text = "Encontrado";
                    binFound.ForeColor = Color.Green;
                }
                else
                {
                    binFound.Text = "No encontrado";
                    binFound.ForeColor = Color.Red;
                }
            });
        }

        private void executeBubble(int[] array, Stopwatch stopwatch)
        {
            stopwatch.Restart();
            Algorithms.Burbuja(array);
            stopwatch.Stop();
            double time = (double)(stopwatch.ElapsedTicks * 1000) / Stopwatch.Frequency;
            bubbleTime.Invoke((MethodInvoker)delegate
            {
                bubbleTime.Text = $"{time} ms"; // Mostrar tiempo en segundos con nueve decimales
            });

        }

        private void executeQuick(int[] array, Stopwatch stopwatch)
        {
            stopwatch.Start();
            Algorithms.QuickSort(array, 0, array.Length - 1);
            stopwatch.Stop();
            double time = (double)(stopwatch.ElapsedTicks * 1000) / Stopwatch.Frequency;
            quickTime.Invoke((MethodInvoker)delegate
            {
                quickTime.Text = $"{time} ms"; // Mostrar tiempo en segundos con nueve decimales
            });
        }

        private void executeInsertion(int[] array, Stopwatch stopwatch)
        {
            stopwatch.Start();
            Algorithms.Insercion(array);
            stopwatch.Stop();
            double time = (double)(stopwatch.ElapsedTicks * 1000) / Stopwatch.Frequency;
            insTime.Invoke((MethodInvoker)delegate
            {
                insTime.Text = $"{time} ms"; // Mostrar tiempo en segundos con nueve decimales
            });
        }

        private int[] obtainArray()
        {
            string[] stringArray = arrayText.Text.Split(',');
            int[] array = new int[stringArray.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(stringArray[i]);
            }
            return array;
        }

        private bool formValidations()
        {
            if (arrayText.Text == "" && toSearchNumber.Text == "")
            {
                errorLabel.Text = "Por favor, ingresa el arreglo y el numero objetivo";
                return false;
            }
            else if (arrayText.Text == "")
            {
                errorLabel.Text = "Por favor, ingresa el arreglo";
                return false;
            }
            else if (toSearchNumber.Text == "")
            {
                errorLabel.Text = "Por favor, ingresa el numero objetivo";
                return false;
            }

            string[] stringArray = arrayText.Text.Split(',');
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (!int.TryParse(stringArray[i], out int n1))
                {
                    errorLabel.Text = "Por favor, ingresa un arreglo valido separando cada numero por coma";
                    return false;
                }
            }

            string target = toSearchNumber.Text;
            if (!int.TryParse(target, out int n2))
            {
                errorLabel.Text = "Por favor, ingresa un numero objetivo valido";
                return false;
            }

            return true;
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void genButton_Click(object sender, EventArgs e)
        {
            clear();
            int[] array = new int[1000];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 1000);
            }
            arrayText.Text = string.Join(",", array);
        }

        void clear()
        {
            bubbleTime.Text = "";
            quickTime.Text = "";
            insTime.Text = "";
            seqTime.Text = "";
            binTime.Text = "";
            arrayText.Text = "";
            toSearchNumber.Text = "";
            errorLabel.Text = "";
            sortButton.Enabled = true;
        }

        private void toSearchNumber_TextChanged(object sender, EventArgs e)
        {
            sortButton.Enabled = true;  
        }
    }
}
