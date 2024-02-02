using Microsoft.Win32;
using System.IO;
using System.Windows;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Threading.Tasks;
using IOExtensions;
using System.Threading;

namespace file_copier_async
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string? PathFrom { get; set; }
        public string? PathTo { get; set; }
        CancellationTokenSource cancellationTokenSource;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FromBrowseClicked(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
            {
                PathFrom = dialog.FileName;
                fromTxtBox.Text = PathFrom;
            }
        }

        private void ToBrowseClicked(object sender, RoutedEventArgs e)
        {
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                PathTo = dialog.FileName;
                toTxtBox.Text = PathTo;
            }
        }

        private void CopyBtnClicked(object sender, RoutedEventArgs e)
        {
			cancellationTokenSource = new CancellationTokenSource();
            if (string.IsNullOrEmpty(PathFrom) || string.IsNullOrEmpty(PathTo))
            {
                MessageBox.Show("Choose a sourse and destination path!", "Can not process copy", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            string fileName = Path.GetFileName(PathFrom);
            string dest = Path.Combine(PathTo, fileName);

            if (dest == PathFrom)
            {
				MessageBox.Show("Choose a sourse and destination path!", "Can not process copy", MessageBoxButton.OK, MessageBoxImage.Warning);
				return;
			}

            // -------------- copy file
            Task.Run(() =>
            {
                FileCopy(PathFrom, dest);
            }); 
        }

        private void FileCopy(string source, string destination)
        {
            // 1 - using File.Copy()
            //File.Copy(source, destination);

            // 2 - using FileStream
            //using (var fsFrom = File.OpenRead(source))
            //{
            //    byte[] buffer = new byte[1024 * 8]; // 8 KB
            //    int available = 0;
            //    long total = fsFrom.Length;

            //    using (var fsTo = File.Create(destination))
            //    {
            //        do
            //        {
            //            available = fsFrom.Read(buffer, 0, buffer.Length);
            //            fsTo.Write(buffer);

            //            // update progress
            //            Application.Current.Dispatcher.Invoke(() =>
            //            {
            //                progressBar.Value = fsTo.Length / (total / 100);
            //            });

            //        } while (available > 0);
            //    }
            //}

            stopCopyBtn.IsEnabled = true;

            // 3 - using 
            FileTransferManager.CopyWithProgress(source, destination, (obj) =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    //obj.Percentage        - process in %
                    //obj.BytesPerSecond    - speed (bytes / second)
                    //obj.Total             - total bytes to copy
                    //obj.BytesTransferred  - copied bytes
                    progressBar.Value = obj.Percentage;
                    copySpeed.Content = obj.BytesPerSecond * 1024;
                    totalAmount.Content = obj.BytesTransferred;
                });
            }, false);

            MessageBox.Show("Complete!");
            stopCopyBtn.IsEnabled = false;
        }

		private void StopCopyButton(object sender, RoutedEventArgs e)
		{
            cancellationTokenSource?.Cancel();
		}
	}
}
