using System.Diagnostics;

namespace razr_pm_Kastyrin_Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    string fileContent = File.ReadAllText(filePath);
                    textBox1.Text = fileContent; // Отображение содержимого файла в текстовом блоке
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGenerateArray_Click(object sender, EventArgs e)
        {
            int[] randomArray = GenerateRandomArray(10, 0, 100); // Генерация случайного массива

            // Отображение сгенерированного массива в текстовом блоке
            textBox1.Text = string.Join(", ", randomArray);
        }

        // Генерация случайного массива чисел
        private int[] GenerateRandomArray(int length, int minValue, int maxValue)
        {
            Random random = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }
            return array;
        }

        private void btn_SelectionSort_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string input = textBox1.Text;
                string[] values = input.Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                int[] arrayToSort = Array.ConvertAll(values, s => int.Parse(s));

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                SelectionSort(arrayToSort);
                stopwatch.Stop();

                textBox2.Text = string.Join(", ", arrayToSort); // Отображение отсортированного массива
                textBox3.Text = $" {stopwatch.Elapsed.TotalMilliseconds} мс";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите элементы массива для сортировки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Сортировка выбором
        private void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;

            }
        }

        private void btn_InsertionSort_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string input = textBox1.Text;
                string[] values = input.Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                int[] arrayToSort = Array.ConvertAll(values, s => int.Parse(s));

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                InsertionSort(arrayToSort);
                stopwatch.Stop();

                textBox2.Text = string.Join(", ", arrayToSort); // Отображение отсортированного массива
                textBox3.Text = $" {stopwatch.Elapsed.TotalMilliseconds} мс";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите элементы массива для сортировки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Сортировка включением
        private void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0 && arr[j] < arr[j - 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j--;
                }
            }
        }

        private void btn_QuickSort_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string input = textBox1.Text;
                string[] values = input.Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                int[] arrayToSort = Array.ConvertAll(values, s => int.Parse(s));

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                QuickSort(arrayToSort, 0, arrayToSort.Length - 1);
                stopwatch.Stop();

                textBox2.Text = string.Join(", ", arrayToSort); // Отображение отсортированного массива
                textBox3.Text = $" {stopwatch.Elapsed.TotalMilliseconds} мс";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите элементы массива для сортировки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Быстрая сортировка
        private void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        // Метод для разделения массива при быстрой сортировке
        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string input = textBox1.Text;
                string[] values = input.Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                int[] arrayToSort = Array.ConvertAll(values, s => int.Parse(s));

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                BubbleSort(arrayToSort);
                stopwatch.Stop();

                textBox2.Text = string.Join(", ", arrayToSort); // Отображение отсортированного массива
                textBox3.Text = $" {stopwatch.Elapsed.TotalMilliseconds} мс";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите элементы массива для сортировки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Пузырьковая сортировка
        private void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        private void btnShakerSort_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string input = textBox1.Text;
                string[] values = input.Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                int[] arrayToSort = Array.ConvertAll(values, s => int.Parse(s));

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                ShakerSort(arrayToSort);
                stopwatch.Stop();

                textBox2.Text = string.Join(", ", arrayToSort); // Отображение отсортированного массива
                textBox3.Text = $" {stopwatch.Elapsed.TotalMilliseconds} мс";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите элементы массива для сортировки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Сортировка шейкером
        private void ShakerSort(int[] arr)
        {
            bool swapped;
            int start = 0;
            int end = arr.Length - 1;

            do
            {
                swapped = false;

                for (int i = start; i < end; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }

                end--;

                if (!swapped)
                {
                    break;
                }

                swapped = false;

                for (int i = end; i > start; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                        swapped = true;
                    }
                }

                start++;
            } while (swapped);
        }

        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string input = textBox1.Text;
                string[] values = input.Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                int[] arrayToSort = Array.ConvertAll(values, s => int.Parse(s));

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                MergeSort(arrayToSort, 0, arrayToSort.Length - 1);
                stopwatch.Stop();

                textBox2.Text = string.Join(", ", arrayToSort); // Отображение отсортированного массива
                textBox3.Text = $" {stopwatch.Elapsed.TotalMilliseconds} мс";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите элементы массива для сортировки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Сортировка слиянием
        private void MergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;

                MergeSort(arr, l, m);
                MergeSort(arr, m + 1, r);

                Merge(arr, l, m, r);
            }
        }

        // Слияние массивов
        private void Merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];

            Array.Copy(arr, l, L, 0, n1);
            Array.Copy(arr, m + 1, R, 0, n2);

            int i = 0, j = 0, k = l;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;

                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
    }
}