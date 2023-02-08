using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
//процессы - програм. задача


namespace CSharpSystProgLesson1
{ 
    internal class Program
    {
        //унаследованный код, winapi
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);
        const uint MB_ICONWARNING = 0x0000030;
        const uint MB_CANCELTRYCONTINUE = 0x00000006;
        const uint MB_DEFBUTTON2 = 0x00000100;
        static void Main(string[] args)
        {
            MessageBox(IntPtr.Zero, "Hello World", "Warning!", MB_ICONWARNING | MB_CANCELTRYCONTINUE | MB_DEFBUTTON2);
            //общение с процессами 
            //Process process = new Process();
            //устанавливаем запуск процесса
            //process.StartInfo = new ProcessStartInfo("notepad.exe");
            //process.Start(); //старт процесса

            //команда ожидания закрытия процесса, код дальше выполн. не будет
            //process.WaitForExit();

            //методы. 1. немедленное закрытие процесса
            //process.Kill();

            //2.закрывает интерфейс программы (главное окно), не убивает процесс
            //process.CloseMainWindow();

            //3.процесс закрытия, высвобождает выделенные ресурсы на процесс
            //process.Close();
            //Console.WriteLine("после закрытия");
            //process.ExitCode = 0; возвращает код ошибки
            //process.Handle or HandleCount перехвадчик процесса, сущность IntPtr(указатель на область памяти, где начинается приложение)
            //process.HasExited = true выход из приложения, не убивает процесс
            //process.Id получаем номер процесса, можно пересылать сам процесс
            //process.MainWindowHandle= IntPtr.Zero; главный класс программы
            //process.Modules какие модули исп. в процессе

            //создание массива процесса, обращение к классу процесса, возможность получить все текущие процессы на компьютере 
            //Process[] processes = Process.GetProcesses();
            //foreach (Process p in processes)
            //{
            //    Console.WriteLine("{0,-35}{1,10}", 
            //   p.ProcessName, p.Id);

            //}
            //Process process = new Process();
            //process.StartInfo = new ProcessStartInfo("notepad.exe");
            //Console.WriteLine(process.Handle);


            //вывод процессов 
            //Console.WriteLine();

        }
    }
}