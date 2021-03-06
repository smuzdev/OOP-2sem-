﻿using lab7_8.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using WPFLocalizeExtension.Engine;

namespace lab7_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}\\todoDataList.json";
        private ObservableCollection<ToDoModel> _todoDataList;
        private ObservableCollection<ToDoModel> _todoDataListSearch;
        private ObservableCollection<ToDoModel> _todoDataListTemp;
        private Stack<ObservableCollection<ToDoModel>> _todoDataListStackReDo = new Stack<ObservableCollection<ToDoModel>>();
        private Stack<ObservableCollection<ToDoModel>> _todoDataListStackUnDo = new Stack<ObservableCollection<ToDoModel>>();
        private FileIOService _fileIOService;

        ObservableCollection<string> todoCategory { get; set; } = new ObservableCollection<string>() { "Дом", "Работа", "Универ" };
        ObservableCollection<string> todoPriority { get; set; } = new ObservableCollection<string>() { "Высокий", "Средний", "Низкий" };
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _fileIOService = new FileIOService(PATH);
            try
            {

                _todoDataList = _fileIOService.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }


            this.DataContext = this;
            ComboBoxCategory.ItemsSource = todoCategory;
            ComboBoxPriority.ItemsSource = todoPriority;
            
            // Timer
            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.IsEnabled = true;
            timer.Tick += (o, t) => {
                currentDateTextBlock.Text = DateTime.Now.ToString("dd");
                currentDayTextBlock.Text = DateTime.Now.ToString("dddd");
                currentMonthTextBlock.Text = DateTime.Now.ToString("MMMM, yyyy");
                currenTimeTextBlock.Text = DateTime.Now.ToString("hh:mm:ss");
            };
            timer.Start();

            // Cursor
            Uri uri = new Uri("pack://application:,,,/Images/cursor.cur");
            var stream = Application.GetResourceStream(uri).Stream;
            var cursor = new Cursor(stream);
            Cursor = cursor;

            List<string> styles = new List<string> { "Light", "Dark" };
            styleBox.SelectionChanged += ThemeChange;
            styleBox.ItemsSource = styles;
            styleBox.SelectedItem = "Light";
        }

        public ObservableCollection<ToDoModel> TodoDataList
        {
            get { return _todoDataList; }
            set
            {
                _todoDataList = value;
                OnPropertyChanged("TodoDataList");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _todoDataListStackReDo.Push(new ObservableCollection<ToDoModel>(_fileIOService.LoadData()));
                _fileIOService.SaveData(TodoDataList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }

        }

        // Languages
        private void button_Click_ChangeLanguageToEnglish(object sender, RoutedEventArgs e)
        {
            LocalizeDictionary.Instance.SetCurrentThreadCulture = true;
            LocalizeDictionary.Instance.Culture = new CultureInfo("en-US");
        }

        private void button1_Click_ChangeLanguageToRussian(object sender, RoutedEventArgs e)
        {
            LocalizeDictionary.Instance.SetCurrentThreadCulture = true;
            LocalizeDictionary.Instance.Culture = new CultureInfo("ru-RU");
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            string temp = SearchField.Text;
            _todoDataListSearch = new ObservableCollection<ToDoModel>();

            foreach (var item in TodoDataList)
            {
                if (item.ToDoDescription == temp)
                {
                    _todoDataListSearch.Add(item);
                }
            }
            TodoDataList = _todoDataListSearch;
        }
        
        private void clear_Click(object sender, RoutedEventArgs e)
        {
            SearchField.Text = null;
        }

        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = styleBox.SelectedItem as string;
            // определяем путь к файлу ресурсов
            var uri = new Uri("/Styles/" + style + ".xaml", UriKind.Relative);
            // загружаем словарь ресурсов
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            // очищаем коллекцию ресурсов приложения
            Application.Current.Resources.Clear();
            // добавляем загруженный словарь ресурсов
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }


        private void buttonRedoClick(object sender, RoutedEventArgs e)
        {
            dgToDoList.ItemsSource = null;

            _todoDataListTemp = _todoDataList;

            _todoDataList = _todoDataListStackReDo.Pop();

            _todoDataListStackUnDo.Push(_todoDataListTemp);

            dgToDoList.ItemsSource = _todoDataList;
            _fileIOService.SaveData(TodoDataList);
        }

        private void buttonUndoClick(object sender, RoutedEventArgs e)
        {
            dgToDoList.ItemsSource = null;
            _todoDataListStackReDo.Push(_todoDataList);
            _todoDataList = _todoDataListStackUnDo.Pop(); 
            dgToDoList.ItemsSource = _todoDataList;
            _fileIOService.SaveData(TodoDataList);
        }
    }
}
