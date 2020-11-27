namespace WindowsFormsTarea9
{
    partial class frmRegistroEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lCedula = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTipoDeSangre = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbComentario = new System.Windows.Forms.RichTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbARS = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbAFP = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbTelefonoEmergencia = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbEmergencia = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(60, 12);
            this.tbCodigo.MaxLength = 12;
            this.tbCodigo.Multiline = true;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(82, 20);
            this.tbCodigo.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(220, 10);
            this.maskedTextBox1.Mask = "000-0000000-0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(82, 20);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // lCedula
            // 
            this.lCedula.AutoSize = true;
            this.lCedula.Location = new System.Drawing.Point(177, 13);
            this.lCedula.Name = "lCedula";
            this.lCedula.Size = new System.Drawing.Size(40, 13);
            this.lCedula.TabIndex = 3;
            this.lCedula.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha De Ingreso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha De Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(446, 11);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaNacimiento.TabIndex = 6;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(663, 12);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(99, 20);
            this.dtpFechaIngreso.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(61, 55);
            this.tbNombre.MaxLength = 40;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(249, 20);
            this.tbNombre.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Apellido";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(385, 55);
            this.tbApellido.MaxLength = 40;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(249, 20);
            this.tbApellido.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(58, 105);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 13;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            this.rbMasculino.CheckedChanged += new System.EventHandler(this.rbMasculino_CheckedChanged);
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(133, 105);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 14;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Estado Civil";
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "Casado(a)",
            "Soltero(a)",
            "Union Libre",
            "Vuido(a)"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(405, 103);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(102, 21);
            this.cbEstadoCivil.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(537, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tipo De Sangre";
            // 
            // cbTipoDeSangre
            // 
            this.cbTipoDeSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDeSangre.FormattingEnabled = true;
            this.cbTipoDeSangre.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O-",
            "AB+",
            "A-"});
            this.cbTipoDeSangre.Location = new System.Drawing.Point(625, 103);
            this.cbTipoDeSangre.Name = "cbTipoDeSangre";
            this.cbTipoDeSangre.Size = new System.Drawing.Size(83, 21);
            this.cbTipoDeSangre.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Nacionalidad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(348, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Religión";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Catolica ",
            "Evangelica ",
            "Testigo De Jehova"});
            this.comboBox1.Location = new System.Drawing.Point(405, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(544, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Telefono";
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(625, 158);
            this.mtbTelefono.Mask = "(000)000-0000";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(82, 20);
            this.mtbTelefono.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(158, 199);
            this.tbEmail.MaxLength = 60;
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(147, 20);
            this.tbEmail.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AccessibleDescription = "Dirección TextBox, maxlength=100";
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(353, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Dirección ";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(414, 203);
            this.tbDireccion.MaxLength = 100;
            this.tbDireccion.Multiline = true;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(280, 20);
            this.tbDireccion.TabIndex = 28;
            this.tbDireccion.TextChanged += new System.EventHandler(this.tbDireccion_TextChanged);
            // 
            // label14
            // 
            this.label14.AccessibleDescription = "Dirección TextBox, maxlength=100";
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 251);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Salario Mensual";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 244);
            this.textBox2.MaxLength = 20;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbComentario);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.cbARS);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.cbAFP);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.tbTelefonoEmergencia);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.tbEmergencia);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cbDepartamento);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.tbCodigo);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.tbDireccion);
            this.groupBox1.Controls.Add(this.lCedula);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dtpFechaNacimiento);
            this.groupBox1.Controls.Add(this.mtbTelefono);
            this.groupBox1.Controls.Add(this.dtpFechaIngreso);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.tbApellido);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbTipoDeSangre);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rbFemenino);
            this.groupBox1.Controls.Add(this.cbEstadoCivil);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 447);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rtbComentario
            // 
            this.rtbComentario.Location = new System.Drawing.Point(101, 362);
            this.rtbComentario.Name = "rtbComentario";
            this.rtbComentario.Size = new System.Drawing.Size(375, 67);
            this.rtbComentario.TabIndex = 42;
            this.rtbComentario.Text = "Escriba su Comentario";
            // 
            // label20
            // 
            this.label20.AccessibleDescription = "Dirección TextBox, maxlength=100";
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 365);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 13);
            this.label20.TabIndex = 41;
            this.label20.Text = "Observaciones ";
            // 
            // cbARS
            // 
            this.cbARS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbARS.FormattingEnabled = true;
            this.cbARS.Items.AddRange(new object[] {
            "ARS HUMANO",
            "Primera ARS Humano",
            "ARS CMD",
            "ARS Meta Salud",
            "Mapfre Salud ARS"});
            this.cbARS.Location = new System.Drawing.Point(515, 322);
            this.cbARS.Name = "cbARS";
            this.cbARS.Size = new System.Drawing.Size(151, 21);
            this.cbARS.TabIndex = 40;
            // 
            // label19
            // 
            this.label19.AccessibleDescription = "Dirección TextBox, maxlength=100";
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(352, 328);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "ARS a la que pertenece ";
            // 
            // cbAFP
            // 
            this.cbAFP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAFP.FormattingEnabled = true;
            this.cbAFP.Items.AddRange(new object[] {
            "Crecimiento\t",
            "Balanceado\t",
            "Conservador"});
            this.cbAFP.Location = new System.Drawing.Point(159, 320);
            this.cbAFP.Name = "cbAFP";
            this.cbAFP.Size = new System.Drawing.Size(151, 21);
            this.cbAFP.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.AccessibleDescription = "Dirección TextBox, maxlength=100";
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 323);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "AFP a la que pertenece";
            // 
            // tbTelefonoEmergencia
            // 
            this.tbTelefonoEmergencia.Location = new System.Drawing.Point(514, 283);
            this.tbTelefonoEmergencia.MaxLength = 60;
            this.tbTelefonoEmergencia.Multiline = true;
            this.tbTelefonoEmergencia.Name = "tbTelefonoEmergencia";
            this.tbTelefonoEmergencia.Size = new System.Drawing.Size(150, 20);
            this.tbTelefonoEmergencia.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AccessibleDescription = "Dirección TextBox, maxlength=100";
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(348, 287);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(154, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Teléfono Contacto Emergencia";
            // 
            // tbEmergencia
            // 
            this.tbEmergencia.Location = new System.Drawing.Point(159, 287);
            this.tbEmergencia.MaxLength = 60;
            this.tbEmergencia.Multiline = true;
            this.tbEmergencia.Name = "tbEmergencia";
            this.tbEmergencia.Size = new System.Drawing.Size(150, 20);
            this.tbEmergencia.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AccessibleDescription = "Dirección TextBox, maxlength=100";
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 290);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Nombre Contacto Emergencia";
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Items.AddRange(new object[] {
            "Seguridad",
            "Limpieza",
            "Oficina",
            "Auxiliar ",
            "Chofer"});
            this.cbDepartamento.Location = new System.Drawing.Point(515, 236);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(151, 21);
            this.cbDepartamento.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AccessibleDescription = "Dirección TextBox, maxlength=100";
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(348, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Departamento Al Que Pertenece";
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGuardar.Location = new System.Drawing.Point(334, 472);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(450, 470);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmRegistroEmpleado
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(844, 524);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistroEmpleado";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Empleado";
            this.Load += new System.EventHandler(this.frmRegistroEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTipoDeSangre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbARS;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbAFP;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbTelefonoEmergencia;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbEmergencia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox rtbComentario;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}