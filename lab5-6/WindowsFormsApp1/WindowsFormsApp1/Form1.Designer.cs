namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DisciplineName = new System.Windows.Forms.TextBox();
            this.DisciplineLabel = new System.Windows.Forms.Label();
            this.AddAll = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Button();
            this.SemestrValue = new System.Windows.Forms.ComboBox();
            this.SemestrLabel = new System.Windows.Forms.Label();
            this.CouseLabel = new System.Windows.Forms.Label();
            this.CourseValue = new System.Windows.Forms.NumericUpDown();
            this.SpecializationDEVI = new System.Windows.Forms.CheckBox();
            this.SpecializationISIT = new System.Windows.Forms.CheckBox();
            this.SpecializationPOIBMS = new System.Windows.Forms.CheckBox();
            this.SpecializationPOIT = new System.Windows.Forms.CheckBox();
            this.Specialization = new System.Windows.Forms.Label();
            this.LabsCountValue = new System.Windows.Forms.Label();
            this.LabsCountLabel = new System.Windows.Forms.Label();
            this.LabsCount = new System.Windows.Forms.TrackBar();
            this.LecturesCountValue = new System.Windows.Forms.Label();
            this.LecturesCountLabel = new System.Windows.Forms.Label();
            this.LecturesCount = new System.Windows.Forms.TrackBar();
            this.test = new System.Windows.Forms.RadioButton();
            this.exam = new System.Windows.Forms.RadioButton();
            this.DisciplineControl = new System.Windows.Forms.Label();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CorpusAydit = new System.Windows.Forms.NumericUpDown();
            this.NumberAudit = new System.Windows.Forms.NumericUpDown();
            this.SNP = new System.Windows.Forms.TextBox();
            this.Pulpit = new System.Windows.Forms.TextBox();
            this.Lector = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.BookList = new System.Windows.Forms.ListView();
            this.BookName = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.TextBox();
            this.CreationDate = new System.Windows.Forms.DateTimePicker();
            this.Literature = new System.Windows.Forms.Label();
            this.OutputList = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Example1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CourseValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturesCount)).BeginInit();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CorpusAydit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberAudit)).BeginInit();
            this.SuspendLayout();
            // 
            // DisciplineName
            // 
            this.DisciplineName.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisciplineName.Location = new System.Drawing.Point(147, 36);
            this.DisciplineName.MaxLength = 20;
            this.DisciplineName.Name = "DisciplineName";
            this.DisciplineName.Size = new System.Drawing.Size(243, 22);
            this.DisciplineName.TabIndex = 3;
            this.DisciplineName.Text = "Название дисциплины";
            this.DisciplineName.Enter += new System.EventHandler(this.DisciplineName_Enter);
            // 
            // DisciplineLabel
            // 
            this.DisciplineLabel.AutoSize = true;
            this.DisciplineLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisciplineLabel.Location = new System.Drawing.Point(11, 36);
            this.DisciplineLabel.Name = "DisciplineLabel";
            this.DisciplineLabel.Size = new System.Drawing.Size(121, 22);
            this.DisciplineLabel.TabIndex = 2;
            this.DisciplineLabel.Text = "Дисциплина:";
            // 
            // AddAll
            // 
            this.AddAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAll.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAll.Location = new System.Drawing.Point(54, 236);
            this.AddAll.Name = "AddAll";
            this.AddAll.Size = new System.Drawing.Size(102, 27);
            this.AddAll.TabIndex = 40;
            this.AddAll.Text = "Добавить";
            this.AddAll.UseVisualStyleBackColor = false;
            this.AddAll.Click += new System.EventHandler(this.AddAll_Click);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Output.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Output.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Output.Location = new System.Drawing.Point(191, 236);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(97, 27);
            this.Output.TabIndex = 39;
            this.Output.Text = "Вывод";
            this.Output.UseVisualStyleBackColor = false;
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // SemestrValue
            // 
            this.SemestrValue.FormattingEnabled = true;
            this.SemestrValue.Items.AddRange(new object[] {
            "1",
            "2"});
            this.SemestrValue.Location = new System.Drawing.Point(262, 86);
            this.SemestrValue.Name = "SemestrValue";
            this.SemestrValue.Size = new System.Drawing.Size(40, 21);
            this.SemestrValue.TabIndex = 42;
            // 
            // SemestrLabel
            // 
            this.SemestrLabel.AutoSize = true;
            this.SemestrLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.SemestrLabel.Location = new System.Drawing.Point(181, 85);
            this.SemestrLabel.Name = "SemestrLabel";
            this.SemestrLabel.Size = new System.Drawing.Size(71, 19);
            this.SemestrLabel.TabIndex = 41;
            this.SemestrLabel.Text = "Семестр:";
            // 
            // CouseLabel
            // 
            this.CouseLabel.AutoSize = true;
            this.CouseLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.CouseLabel.Location = new System.Drawing.Point(201, 107);
            this.CouseLabel.Name = "CouseLabel";
            this.CouseLabel.Size = new System.Drawing.Size(45, 19);
            this.CouseLabel.TabIndex = 44;
            this.CouseLabel.Text = "Курс:";
            // 
            // CourseValue
            // 
            this.CourseValue.Location = new System.Drawing.Point(261, 109);
            this.CourseValue.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.CourseValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CourseValue.Name = "CourseValue";
            this.CourseValue.Size = new System.Drawing.Size(27, 20);
            this.CourseValue.TabIndex = 43;
            this.CourseValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SpecializationDEVI
            // 
            this.SpecializationDEVI.AutoSize = true;
            this.SpecializationDEVI.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.SpecializationDEVI.Location = new System.Drawing.Point(98, 110);
            this.SpecializationDEVI.Name = "SpecializationDEVI";
            this.SpecializationDEVI.Size = new System.Drawing.Size(58, 20);
            this.SpecializationDEVI.TabIndex = 49;
            this.SpecializationDEVI.Text = "ДЭВИ";
            this.SpecializationDEVI.UseVisualStyleBackColor = true;
            // 
            // SpecializationISIT
            // 
            this.SpecializationISIT.AutoSize = true;
            this.SpecializationISIT.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.SpecializationISIT.Location = new System.Drawing.Point(98, 87);
            this.SpecializationISIT.Name = "SpecializationISIT";
            this.SpecializationISIT.Size = new System.Drawing.Size(58, 20);
            this.SpecializationISIT.TabIndex = 48;
            this.SpecializationISIT.Text = "ИСИТ";
            this.SpecializationISIT.UseVisualStyleBackColor = true;
            // 
            // SpecializationPOIBMS
            // 
            this.SpecializationPOIBMS.AutoSize = true;
            this.SpecializationPOIBMS.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.SpecializationPOIBMS.Location = new System.Drawing.Point(16, 110);
            this.SpecializationPOIBMS.Name = "SpecializationPOIBMS";
            this.SpecializationPOIBMS.Size = new System.Drawing.Size(79, 20);
            this.SpecializationPOIBMS.TabIndex = 47;
            this.SpecializationPOIBMS.Text = "ПОИБМС";
            this.SpecializationPOIBMS.UseVisualStyleBackColor = true;
            // 
            // SpecializationPOIT
            // 
            this.SpecializationPOIT.AutoSize = true;
            this.SpecializationPOIT.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecializationPOIT.Location = new System.Drawing.Point(16, 87);
            this.SpecializationPOIT.Name = "SpecializationPOIT";
            this.SpecializationPOIT.Size = new System.Drawing.Size(60, 20);
            this.SpecializationPOIT.TabIndex = 46;
            this.SpecializationPOIT.Text = "ПОИТ";
            this.SpecializationPOIT.UseVisualStyleBackColor = true;
            // 
            // Specialization
            // 
            this.Specialization.AutoSize = true;
            this.Specialization.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Specialization.Location = new System.Drawing.Point(12, 65);
            this.Specialization.Name = "Specialization";
            this.Specialization.Size = new System.Drawing.Size(120, 19);
            this.Specialization.TabIndex = 45;
            this.Specialization.Text = "Специальность:";
            // 
            // LabsCountValue
            // 
            this.LabsCountValue.AutoSize = true;
            this.LabsCountValue.Location = new System.Drawing.Point(390, 195);
            this.LabsCountValue.Name = "LabsCountValue";
            this.LabsCountValue.Size = new System.Drawing.Size(0, 13);
            this.LabsCountValue.TabIndex = 55;
            // 
            // LabsCountLabel
            // 
            this.LabsCountLabel.AutoSize = true;
            this.LabsCountLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabsCountLabel.Location = new System.Drawing.Point(16, 195);
            this.LabsCountLabel.Name = "LabsCountLabel";
            this.LabsCountLabel.Size = new System.Drawing.Size(118, 19);
            this.LabsCountLabel.TabIndex = 54;
            this.LabsCountLabel.Text = "Лабораторные:";
            // 
            // LabsCount
            // 
            this.LabsCount.Location = new System.Drawing.Point(147, 189);
            this.LabsCount.Maximum = 32;
            this.LabsCount.Minimum = 10;
            this.LabsCount.Name = "LabsCount";
            this.LabsCount.Size = new System.Drawing.Size(141, 45);
            this.LabsCount.TabIndex = 53;
            this.LabsCount.Value = 10;
            this.LabsCount.ValueChanged += new System.EventHandler(this.LabsCount_ValueChanged);
            // 
            // LecturesCountValue
            // 
            this.LecturesCountValue.AutoSize = true;
            this.LecturesCountValue.Location = new System.Drawing.Point(390, 143);
            this.LecturesCountValue.Name = "LecturesCountValue";
            this.LecturesCountValue.Size = new System.Drawing.Size(0, 13);
            this.LecturesCountValue.TabIndex = 52;
            // 
            // LecturesCountLabel
            // 
            this.LecturesCountLabel.AutoSize = true;
            this.LecturesCountLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.LecturesCountLabel.Location = new System.Drawing.Point(12, 143);
            this.LecturesCountLabel.Name = "LecturesCountLabel";
            this.LecturesCountLabel.Size = new System.Drawing.Size(66, 19);
            this.LecturesCountLabel.TabIndex = 51;
            this.LecturesCountLabel.Text = "Лекции:";
            // 
            // LecturesCount
            // 
            this.LecturesCount.Location = new System.Drawing.Point(147, 145);
            this.LecturesCount.Maximum = 32;
            this.LecturesCount.Minimum = 10;
            this.LecturesCount.Name = "LecturesCount";
            this.LecturesCount.Size = new System.Drawing.Size(141, 45);
            this.LecturesCount.TabIndex = 50;
            this.LecturesCount.Value = 10;
            this.LecturesCount.ValueChanged += new System.EventHandler(this.LecturesCount_ValueChanged);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test.Location = new System.Drawing.Point(8, 30);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(55, 20);
            this.test.TabIndex = 58;
            this.test.TabStop = true;
            this.test.Text = "зачёт";
            this.test.UseVisualStyleBackColor = true;
            // 
            // exam
            // 
            this.exam.AutoSize = true;
            this.exam.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exam.Location = new System.Drawing.Point(8, 4);
            this.exam.Name = "exam";
            this.exam.Size = new System.Drawing.Size(70, 20);
            this.exam.TabIndex = 57;
            this.exam.TabStop = true;
            this.exam.Text = "экзамен";
            this.exam.UseVisualStyleBackColor = true;
            // 
            // DisciplineControl
            // 
            this.DisciplineControl.AutoSize = true;
            this.DisciplineControl.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.DisciplineControl.Location = new System.Drawing.Point(298, 143);
            this.DisciplineControl.Name = "DisciplineControl";
            this.DisciplineControl.Size = new System.Drawing.Size(110, 19);
            this.DisciplineControl.TabIndex = 56;
            this.DisciplineControl.Text = "Вид контроля:";
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.test);
            this.ControlPanel.Controls.Add(this.exam);
            this.ControlPanel.Location = new System.Drawing.Point(302, 166);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(90, 58);
            this.ControlPanel.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(772, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 16);
            this.label1.TabIndex = 65;
            this.label1.Text = "-";
            // 
            // CorpusAydit
            // 
            this.CorpusAydit.Location = new System.Drawing.Point(787, 36);
            this.CorpusAydit.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.CorpusAydit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CorpusAydit.Name = "CorpusAydit";
            this.CorpusAydit.Size = new System.Drawing.Size(26, 20);
            this.CorpusAydit.TabIndex = 64;
            this.CorpusAydit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumberAudit
            // 
            this.NumberAudit.Location = new System.Drawing.Point(727, 36);
            this.NumberAudit.Maximum = new decimal(new int[] {
            430,
            0,
            0,
            0});
            this.NumberAudit.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumberAudit.Name = "NumberAudit";
            this.NumberAudit.Size = new System.Drawing.Size(42, 20);
            this.NumberAudit.TabIndex = 63;
            this.NumberAudit.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // SNP
            // 
            this.SNP.Location = new System.Drawing.Point(496, 36);
            this.SNP.Name = "SNP";
            this.SNP.Size = new System.Drawing.Size(206, 20);
            this.SNP.TabIndex = 62;
            this.SNP.Text = "Ф.И.О.";
            this.SNP.Enter += new System.EventHandler(this.SNP_Enter);
            this.SNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SNP_KeyPress);
            // 
            // Pulpit
            // 
            this.Pulpit.Location = new System.Drawing.Point(496, 62);
            this.Pulpit.Name = "Pulpit";
            this.Pulpit.Size = new System.Drawing.Size(298, 20);
            this.Pulpit.TabIndex = 61;
            this.Pulpit.Text = "Кафедра";
            this.Pulpit.Enter += new System.EventHandler(this.Pulpit_Enter);
            // 
            // Lector
            // 
            this.Lector.AutoSize = true;
            this.Lector.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lector.Location = new System.Drawing.Point(430, 47);
            this.Lector.Name = "Lector";
            this.Lector.Size = new System.Drawing.Size(63, 19);
            this.Lector.TabIndex = 60;
            this.Lector.Text = "Лектор:";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(536, 236);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(86, 27);
            this.Add.TabIndex = 71;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // BookList
            // 
            this.BookList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.BookList.AutoArrange = false;
            this.BookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookList.GridLines = true;
            this.BookList.HideSelection = false;
            this.BookList.Location = new System.Drawing.Point(414, 273);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(387, 179);
            this.BookList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.BookList.TabIndex = 70;
            this.BookList.UseCompatibleStateImageBehavior = false;
            this.BookList.View = System.Windows.Forms.View.List;
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(529, 157);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(290, 20);
            this.BookName.TabIndex = 69;
            this.BookName.Text = "Название";
            this.BookName.Enter += new System.EventHandler(this.BookName_Enter);
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(529, 131);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(185, 20);
            this.Author.TabIndex = 68;
            this.Author.Text = "Автор";
            this.Author.Enter += new System.EventHandler(this.Author_Enter);
            // 
            // CreationDate
            // 
            this.CreationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreationDate.Location = new System.Drawing.Point(720, 131);
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.Size = new System.Drawing.Size(99, 20);
            this.CreationDate.TabIndex = 67;
            this.CreationDate.Value = new System.DateTime(1923, 1, 1, 0, 0, 0, 0);
            // 
            // Literature
            // 
            this.Literature.AutoSize = true;
            this.Literature.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.Literature.Location = new System.Drawing.Point(430, 143);
            this.Literature.Name = "Literature";
            this.Literature.Size = new System.Drawing.Size(93, 19);
            this.Literature.TabIndex = 66;
            this.Literature.Text = "Литература:";
            // 
            // OutputList
            // 
            this.OutputList.Location = new System.Drawing.Point(12, 273);
            this.OutputList.Name = "OutputList";
            this.OutputList.Size = new System.Drawing.Size(386, 179);
            this.OutputList.TabIndex = 72;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 73;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Example1
            // 
            this.Example1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Example1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Example1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Example1.Location = new System.Drawing.Point(635, 236);
            this.Example1.Name = "Example1";
            this.Example1.Size = new System.Drawing.Size(86, 28);
            this.Example1.TabIndex = 74;
            this.Example1.Text = "Тест";
            this.Example1.UseVisualStyleBackColor = false;
            this.Example1.Click += new System.EventHandler(this.Example1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(832, 462);
            this.Controls.Add(this.Example1);
            this.Controls.Add(this.OutputList);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.BookList);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.CreationDate);
            this.Controls.Add(this.Literature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CorpusAydit);
            this.Controls.Add(this.NumberAudit);
            this.Controls.Add(this.SNP);
            this.Controls.Add(this.Pulpit);
            this.Controls.Add(this.Lector);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.DisciplineControl);
            this.Controls.Add(this.LabsCountValue);
            this.Controls.Add(this.LabsCountLabel);
            this.Controls.Add(this.LabsCount);
            this.Controls.Add(this.LecturesCountValue);
            this.Controls.Add(this.LecturesCountLabel);
            this.Controls.Add(this.LecturesCount);
            this.Controls.Add(this.SpecializationDEVI);
            this.Controls.Add(this.SpecializationISIT);
            this.Controls.Add(this.SpecializationPOIBMS);
            this.Controls.Add(this.SpecializationPOIT);
            this.Controls.Add(this.Specialization);
            this.Controls.Add(this.CouseLabel);
            this.Controls.Add(this.CourseValue);
            this.Controls.Add(this.SemestrValue);
            this.Controls.Add(this.SemestrLabel);
            this.Controls.Add(this.AddAll);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.DisciplineName);
            this.Controls.Add(this.DisciplineLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Лабораторная 5";
            ((System.ComponentModel.ISupportInitialize)(this.CourseValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturesCount)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CorpusAydit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberAudit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DisciplineName;
        private System.Windows.Forms.Label DisciplineLabel;
        private System.Windows.Forms.Button AddAll;
        private System.Windows.Forms.Button Output;
        private System.Windows.Forms.ComboBox SemestrValue;
        private System.Windows.Forms.Label SemestrLabel;
        private System.Windows.Forms.Label CouseLabel;
        private System.Windows.Forms.NumericUpDown CourseValue;
        private System.Windows.Forms.CheckBox SpecializationDEVI;
        private System.Windows.Forms.CheckBox SpecializationISIT;
        private System.Windows.Forms.CheckBox SpecializationPOIBMS;
        private System.Windows.Forms.CheckBox SpecializationPOIT;
        private System.Windows.Forms.Label Specialization;
        private System.Windows.Forms.Label LabsCountValue;
        private System.Windows.Forms.Label LabsCountLabel;
        private System.Windows.Forms.TrackBar LabsCount;
        private System.Windows.Forms.Label LecturesCountValue;
        private System.Windows.Forms.Label LecturesCountLabel;
        private System.Windows.Forms.TrackBar LecturesCount;
        private System.Windows.Forms.RadioButton test;
        private System.Windows.Forms.RadioButton exam;
        private System.Windows.Forms.Label DisciplineControl;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown CorpusAydit;
        private System.Windows.Forms.NumericUpDown NumberAudit;
        private System.Windows.Forms.TextBox SNP;
        private System.Windows.Forms.TextBox Pulpit;
        private System.Windows.Forms.Label Lector;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ListView BookList;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.DateTimePicker CreationDate;
        private System.Windows.Forms.Label Literature;
        private System.Windows.Forms.TreeView OutputList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button Example1;
    }
}

