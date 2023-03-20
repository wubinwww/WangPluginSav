﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WC3Tool
{
    partial class ECB_editor
    {
        private System.ComponentModel.IContainer components = null;
        private Button load_ecb_but;

        private Button save_ecb_but;

        private TextBox ecb_path;

        private Label label1;

        private TextBox name;

        private ComboBox firm_box;

        private Label label2;

        private NumericUpDown size;

        private Label label3;

        private Label label4;

        private Label label5;

        private NumericUpDown yield_max;

        private NumericUpDown yield_min;

        private Label label6;

        private NumericUpDown growth;

        private Label label7;

        private Label label8;

        private Label label9;

        private Label label10;

        private Label label11;

        private NumericUpDown spicy;

        private NumericUpDown dry;

        private NumericUpDown sweet;

        private NumericUpDown bitter;

        private NumericUpDown sour;

        private NumericUpDown smooth;

        private Label label12;

        private TextBox desc1;

        private TextBox desc2;

        private Label label13;

        private NumericUpDown held;

        private Button held_help;

        private Button sprite_export_but;

        private Button sprite_import_but;

        private Button palette_export_but;

        private Button palette_import_but;

        private Button sprite_help;

        private CheckBox jap_encoding;

        private CheckBox heal_inf;

        private CheckBox heal_sleep;

        private CheckBox heal_poison;

        private CheckBox heal_burn;

        private CheckBox heal_ice;

        private CheckBox heal_para;

        private CheckBox heal_confu;

        private CheckBox guard;

        private CheckBox lvlup;

        private CheckBox firstpoke;

        private Label label15;

        private Label label16;

        private Label label17;

        private Label label18;

        private Label label19;

        private Label label20;

        private NumericUpDown direhit;

        private NumericUpDown atkup;

        private NumericUpDown defup;

        private NumericUpDown speedup;

        private NumericUpDown spatkup;

        private NumericUpDown accurup;

        private CheckBox ev_hp;

        private CheckBox ev_atk;

        private CheckBox ev_def;

        private CheckBox ev_speed;

        private CheckBox ev_speatk;

        private CheckBox ev_spedef;

        private NumericUpDown tr6_val;

        private CheckBox heal_hp;

        private CheckBox heal_pp;

        private CheckBox selectedatk;

        private CheckBox maxppUP;

        private CheckBox revive;

        private CheckBox stone;

        private CheckBox happy200;

        private CheckBox happy100;

        private CheckBox happy0;

        private NumericUpDown hap200;

        private NumericUpDown hap100;

        private NumericUpDown happ0;

        private CheckBox ppup;

        private GroupBox groupBox1;

        private Label label14;

        private Button pphelp;

        private Button modifier_help;

        private Button note;

        private GroupBox groupBox6;

        private GroupBox groupBox5;

        private GroupBox groupBox4;

        private GroupBox groupBox3;

        private GroupBox groupBox2;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.load_ecb_but = new System.Windows.Forms.Button();
            this.save_ecb_but = new System.Windows.Forms.Button();
            this.ecb_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.firm_box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yield_max = new System.Windows.Forms.NumericUpDown();
            this.yield_min = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.growth = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.spicy = new System.Windows.Forms.NumericUpDown();
            this.dry = new System.Windows.Forms.NumericUpDown();
            this.sweet = new System.Windows.Forms.NumericUpDown();
            this.bitter = new System.Windows.Forms.NumericUpDown();
            this.sour = new System.Windows.Forms.NumericUpDown();
            this.smooth = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.desc1 = new System.Windows.Forms.TextBox();
            this.desc2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.held = new System.Windows.Forms.NumericUpDown();
            this.held_help = new System.Windows.Forms.Button();
            this.sprite_export_but = new System.Windows.Forms.Button();
            this.sprite_import_but = new System.Windows.Forms.Button();
            this.palette_export_but = new System.Windows.Forms.Button();
            this.palette_import_but = new System.Windows.Forms.Button();
            this.sprite_help = new System.Windows.Forms.Button();
            this.jap_encoding = new System.Windows.Forms.CheckBox();
            this.heal_inf = new System.Windows.Forms.CheckBox();
            this.heal_sleep = new System.Windows.Forms.CheckBox();
            this.heal_poison = new System.Windows.Forms.CheckBox();
            this.heal_burn = new System.Windows.Forms.CheckBox();
            this.heal_ice = new System.Windows.Forms.CheckBox();
            this.heal_para = new System.Windows.Forms.CheckBox();
            this.heal_confu = new System.Windows.Forms.CheckBox();
            this.guard = new System.Windows.Forms.CheckBox();
            this.lvlup = new System.Windows.Forms.CheckBox();
            this.firstpoke = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.direhit = new System.Windows.Forms.NumericUpDown();
            this.atkup = new System.Windows.Forms.NumericUpDown();
            this.defup = new System.Windows.Forms.NumericUpDown();
            this.speedup = new System.Windows.Forms.NumericUpDown();
            this.spatkup = new System.Windows.Forms.NumericUpDown();
            this.accurup = new System.Windows.Forms.NumericUpDown();
            this.ev_hp = new System.Windows.Forms.CheckBox();
            this.ev_atk = new System.Windows.Forms.CheckBox();
            this.ev_def = new System.Windows.Forms.CheckBox();
            this.ev_speed = new System.Windows.Forms.CheckBox();
            this.ev_speatk = new System.Windows.Forms.CheckBox();
            this.ev_spedef = new System.Windows.Forms.CheckBox();
            this.tr6_val = new System.Windows.Forms.NumericUpDown();
            this.heal_hp = new System.Windows.Forms.CheckBox();
            this.heal_pp = new System.Windows.Forms.CheckBox();
            this.selectedatk = new System.Windows.Forms.CheckBox();
            this.maxppUP = new System.Windows.Forms.CheckBox();
            this.revive = new System.Windows.Forms.CheckBox();
            this.stone = new System.Windows.Forms.CheckBox();
            this.happy200 = new System.Windows.Forms.CheckBox();
            this.happy100 = new System.Windows.Forms.CheckBox();
            this.happy0 = new System.Windows.Forms.CheckBox();
            this.hap200 = new System.Windows.Forms.NumericUpDown();
            this.hap100 = new System.Windows.Forms.NumericUpDown();
            this.happ0 = new System.Windows.Forms.NumericUpDown();
            this.ppup = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pphelp = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.note = new System.Windows.Forms.Button();
            this.modifier_help = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)this.size).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.yield_max).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.yield_min).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.growth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.spicy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.sweet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.bitter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.sour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.smooth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.held).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.direhit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.atkup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.defup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.speedup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.spatkup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.accurup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.tr6_val).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.hap200).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.hap100).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.happ0).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            base.SuspendLayout();
            this.load_ecb_but.Location = new System.Drawing.Point(12, 21);
            this.load_ecb_but.Name = "load_ecb_but";
            this.load_ecb_but.Size = new System.Drawing.Size(75, 23);
            this.load_ecb_but.TabIndex = 0;
            this.load_ecb_but.Text = "Load ECB";
            this.load_ecb_but.UseVisualStyleBackColor = true;
            this.load_ecb_but.Click += new System.EventHandler(Load_ecb_butClick);
            this.save_ecb_but.Enabled = false;
            this.save_ecb_but.Location = new System.Drawing.Point(93, 21);
            this.save_ecb_but.Name = "save_ecb_but";
            this.save_ecb_but.Size = new System.Drawing.Size(75, 23);
            this.save_ecb_but.TabIndex = 1;
            this.save_ecb_but.Text = "Save ECB";
            this.save_ecb_but.UseVisualStyleBackColor = true;
            this.save_ecb_but.Click += new System.EventHandler(Save_ecb_butClick);
            this.ecb_path.Location = new System.Drawing.Point(174, 24);
            this.ecb_path.Name = "ecb_path";
            this.ecb_path.Size = new System.Drawing.Size(482, 20);
            this.ecb_path.TabIndex = 2;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            this.name.Location = new System.Drawing.Point(93, 69);
            this.name.MaxLength = 6;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(252, 20);
            this.name.TabIndex = 4;
            this.firm_box.FormattingEnabled = true;
            this.firm_box.Items.AddRange(new object[5] { "Very soft", "Soft", "Hard", "Very hard", "Super hard" });
            this.firm_box.Location = new System.Drawing.Point(93, 151);
            this.firm_box.Name = "firm_box";
            this.firm_box.Size = new System.Drawing.Size(120, 21);
            this.firm_box.TabIndex = 5;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Firmness:";
            this.size.Location = new System.Drawing.Point(93, 177);
            this.size.Maximum = new decimal(new int[4] { 65535, 0, 0, 0 });
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(120, 20);
            this.size.TabIndex = 7;
            this.label3.Location = new System.Drawing.Point(12, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Size:";
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Maximum yield:";
            this.label5.Location = new System.Drawing.Point(12, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Minumum yield:";
            this.yield_max.Location = new System.Drawing.Point(93, 203);
            this.yield_max.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
            this.yield_max.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
            this.yield_max.Name = "yield_max";
            this.yield_max.Size = new System.Drawing.Size(120, 20);
            this.yield_max.TabIndex = 11;
            this.yield_max.Value = new decimal(new int[4] { 1, 0, 0, 0 });
            this.yield_min.Location = new System.Drawing.Point(93, 229);
            this.yield_min.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
            this.yield_min.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
            this.yield_min.Name = "yield_min";
            this.yield_min.Size = new System.Drawing.Size(120, 20);
            this.yield_min.TabIndex = 12;
            this.yield_min.Value = new decimal(new int[4] { 1, 0, 0, 0 });
            this.label6.Location = new System.Drawing.Point(12, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 34);
            this.label6.TabIndex = 13;
            this.label6.Text = "Growth hours per stage:";
            this.growth.Location = new System.Drawing.Point(93, 255);
            this.growth.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
            this.growth.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
            this.growth.Name = "growth";
            this.growth.Size = new System.Drawing.Size(120, 20);
            this.growth.TabIndex = 14;
            this.growth.Value = new decimal(new int[4] { 1, 0, 0, 0 });
            this.label7.Location = new System.Drawing.Point(219, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Spicyness:";
            this.label8.Location = new System.Drawing.Point(219, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Dryness:";
            this.label9.Location = new System.Drawing.Point(219, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Sweetness:";
            this.label10.Location = new System.Drawing.Point(219, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Bitterness:";
            this.label11.Location = new System.Drawing.Point(219, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 19;
            this.label11.Text = "Sourness:";
            this.spicy.Location = new System.Drawing.Point(288, 152);
            this.spicy.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
            this.spicy.Name = "spicy";
            this.spicy.Size = new System.Drawing.Size(78, 20);
            this.spicy.TabIndex = 20;
            this.dry.Location = new System.Drawing.Point(288, 177);
            this.dry.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
            this.dry.Name = "dry";
            this.dry.Size = new System.Drawing.Size(78, 20);
            this.dry.TabIndex = 21;
            this.sweet.Location = new System.Drawing.Point(288, 203);
            this.sweet.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
            this.sweet.Name = "sweet";
            this.sweet.Size = new System.Drawing.Size(78, 20);
            this.sweet.TabIndex = 22;
            this.bitter.Location = new System.Drawing.Point(288, 229);
            this.bitter.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
            this.bitter.Name = "bitter";
            this.bitter.Size = new System.Drawing.Size(78, 20);
            this.bitter.TabIndex = 23;
            this.sour.Location = new System.Drawing.Point(288, 255);
            this.sour.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
            this.sour.Name = "sour";
            this.sour.Size = new System.Drawing.Size(78, 20);
            this.sour.TabIndex = 24;
            this.smooth.Location = new System.Drawing.Point(288, 281);
            this.smooth.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
            this.smooth.Name = "smooth";
            this.smooth.Size = new System.Drawing.Size(78, 20);
            this.smooth.TabIndex = 25;
            this.label12.Location = new System.Drawing.Point(219, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 23);
            this.label12.TabIndex = 26;
            this.label12.Text = "Smoothness:";
            this.desc1.Location = new System.Drawing.Point(42, 94);
            this.desc1.MaxLength = 44;
            this.desc1.Name = "desc1";
            this.desc1.Size = new System.Drawing.Size(303, 20);
            this.desc1.TabIndex = 27;
            this.desc2.Location = new System.Drawing.Point(42, 120);
            this.desc2.MaxLength = 44;
            this.desc2.Name = "desc2";
            this.desc2.Size = new System.Drawing.Size(303, 20);
            this.desc2.TabIndex = 28;
            this.label13.Location = new System.Drawing.Point(12, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 18);
            this.label13.TabIndex = 29;
            this.label13.Text = "Usage as held item:";
            this.held.Location = new System.Drawing.Point(120, 309);
            this.held.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
            this.held.Name = "held";
            this.held.Size = new System.Drawing.Size(59, 20);
            this.held.TabIndex = 30;
            this.held_help.Location = new System.Drawing.Point(185, 309);
            this.held_help.Name = "held_help";
            this.held_help.Size = new System.Drawing.Size(15, 20);
            this.held_help.TabIndex = 31;
            this.held_help.Text = "?";
            this.held_help.UseVisualStyleBackColor = true;
            this.held_help.Click += new System.EventHandler(Held_helpClick);
            this.sprite_export_but.Enabled = false;
            this.sprite_export_but.Location = new System.Drawing.Point(662, 21);
            this.sprite_export_but.Name = "sprite_export_but";
            this.sprite_export_but.Size = new System.Drawing.Size(86, 23);
            this.sprite_export_but.TabIndex = 33;
            this.sprite_export_but.Text = "Export Sprite";
            this.sprite_export_but.UseVisualStyleBackColor = true;
            this.sprite_export_but.Click += new System.EventHandler(Sprite_export_butClick);
            this.sprite_import_but.Enabled = false;
            this.sprite_import_but.Location = new System.Drawing.Point(754, 21);
            this.sprite_import_but.Name = "sprite_import_but";
            this.sprite_import_but.Size = new System.Drawing.Size(86, 23);
            this.sprite_import_but.TabIndex = 34;
            this.sprite_import_but.Text = "Import Sprite";
            this.sprite_import_but.UseVisualStyleBackColor = true;
            this.sprite_import_but.Click += new System.EventHandler(Sprite_import_butClick);
            this.palette_export_but.Enabled = false;
            this.palette_export_but.Location = new System.Drawing.Point(472, 0);
            this.palette_export_but.Name = "palette_export_but";
            this.palette_export_but.Size = new System.Drawing.Size(86, 23);
            this.palette_export_but.TabIndex = 35;
            this.palette_export_but.Text = "Export Palette";
            this.palette_export_but.UseVisualStyleBackColor = true;
            this.palette_export_but.Visible = false;
            this.palette_export_but.Click += new System.EventHandler(Palette_export_butClick);
            this.palette_import_but.Enabled = false;
            this.palette_import_but.Location = new System.Drawing.Point(564, 0);
            this.palette_import_but.Name = "palette_import_but";
            this.palette_import_but.Size = new System.Drawing.Size(86, 23);
            this.palette_import_but.TabIndex = 36;
            this.palette_import_but.Text = "Import Palette";
            this.palette_import_but.UseVisualStyleBackColor = true;
            this.palette_import_but.Visible = false;
            this.palette_import_but.Click += new System.EventHandler(Palette_import_butClick);
            this.sprite_help.Location = new System.Drawing.Point(846, 22);
            this.sprite_help.Name = "sprite_help";
            this.sprite_help.Size = new System.Drawing.Size(15, 20);
            this.sprite_help.TabIndex = 37;
            this.sprite_help.Text = "?";
            this.sprite_help.UseVisualStyleBackColor = true;
            this.sprite_help.Click += new System.EventHandler(Sprite_helpClick);
            this.jap_encoding.Location = new System.Drawing.Point(93, 47);
            this.jap_encoding.Name = "jap_encoding";
            this.jap_encoding.Size = new System.Drawing.Size(134, 22);
            this.jap_encoding.TabIndex = 38;
            this.jap_encoding.Text = "Japanese encoding";
            this.jap_encoding.UseVisualStyleBackColor = true;
            this.jap_encoding.CheckedChanged += new System.EventHandler(Jap_encodingCheckedChanged);
            this.heal_inf.Location = new System.Drawing.Point(6, 19);
            this.heal_inf.Name = "heal_inf";
            this.heal_inf.Size = new System.Drawing.Size(104, 18);
            this.heal_inf.TabIndex = 39;
            this.heal_inf.Text = "Heal Infatuation";
            this.heal_inf.UseVisualStyleBackColor = true;
            this.heal_sleep.Location = new System.Drawing.Point(6, 40);
            this.heal_sleep.Name = "heal_sleep";
            this.heal_sleep.Size = new System.Drawing.Size(104, 18);
            this.heal_sleep.TabIndex = 40;
            this.heal_sleep.Text = "Heal Sleep";
            this.heal_sleep.UseVisualStyleBackColor = true;
            this.heal_poison.Location = new System.Drawing.Point(6, 58);
            this.heal_poison.Name = "heal_poison";
            this.heal_poison.Size = new System.Drawing.Size(104, 18);
            this.heal_poison.TabIndex = 41;
            this.heal_poison.Text = "Heal Poison";
            this.heal_poison.UseVisualStyleBackColor = true;
            this.heal_burn.Location = new System.Drawing.Point(6, 76);
            this.heal_burn.Name = "heal_burn";
            this.heal_burn.Size = new System.Drawing.Size(104, 18);
            this.heal_burn.TabIndex = 42;
            this.heal_burn.Text = "Heal Burn";
            this.heal_burn.UseVisualStyleBackColor = true;
            this.heal_ice.Location = new System.Drawing.Point(6, 93);
            this.heal_ice.Name = "heal_ice";
            this.heal_ice.Size = new System.Drawing.Size(104, 18);
            this.heal_ice.TabIndex = 43;
            this.heal_ice.Text = "Heal Ice";
            this.heal_ice.UseVisualStyleBackColor = true;
            this.heal_para.Location = new System.Drawing.Point(6, 111);
            this.heal_para.Name = "heal_para";
            this.heal_para.Size = new System.Drawing.Size(104, 18);
            this.heal_para.TabIndex = 44;
            this.heal_para.Text = "Heal Paralyze";
            this.heal_para.UseVisualStyleBackColor = true;
            this.heal_confu.Location = new System.Drawing.Point(6, 129);
            this.heal_confu.Name = "heal_confu";
            this.heal_confu.Size = new System.Drawing.Size(104, 18);
            this.heal_confu.TabIndex = 45;
            this.heal_confu.Text = "Heal Confusion";
            this.heal_confu.UseVisualStyleBackColor = true;
            this.guard.Location = new System.Drawing.Point(17, 141);
            this.guard.Name = "guard";
            this.guard.Size = new System.Drawing.Size(91, 16);
            this.guard.TabIndex = 46;
            this.guard.Text = "Guard-spec";
            this.guard.UseVisualStyleBackColor = true;
            this.lvlup.Location = new System.Drawing.Point(228, 226);
            this.lvlup.Name = "lvlup";
            this.lvlup.Size = new System.Drawing.Size(104, 16);
            this.lvlup.TabIndex = 47;
            this.lvlup.Text = "Level up";
            this.lvlup.UseVisualStyleBackColor = true;
            this.firstpoke.Location = new System.Drawing.Point(228, 191);
            this.firstpoke.Name = "firstpoke";
            this.firstpoke.Size = new System.Drawing.Size(95, 40);
            this.firstpoke.TabIndex = 48;
            this.firstpoke.Text = "Apply to first pokemon";
            this.firstpoke.UseVisualStyleBackColor = true;
            this.label15.Location = new System.Drawing.Point(17, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "Dire Hit";
            this.label16.Location = new System.Drawing.Point(17, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 13);
            this.label16.TabIndex = 50;
            this.label16.Text = "Atk Up";
            this.label17.Location = new System.Drawing.Point(17, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 13);
            this.label17.TabIndex = 51;
            this.label17.Text = "Def Up";
            this.label18.Location = new System.Drawing.Point(17, 81);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 13);
            this.label18.TabIndex = 52;
            this.label18.Text = "Speed Up";
            this.label19.Location = new System.Drawing.Point(17, 102);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 13);
            this.label19.TabIndex = 53;
            this.label19.Text = "SP Atk Up";
            this.label20.Location = new System.Drawing.Point(17, 123);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 13);
            this.label20.TabIndex = 54;
            this.label20.Text = "Accur. Up";
            this.direhit.Location = new System.Drawing.Point(78, 16);
            this.direhit.Maximum = new decimal(new int[4] { 3, 0, 0, 0 });
            this.direhit.Name = "direhit";
            this.direhit.Size = new System.Drawing.Size(39, 20);
            this.direhit.TabIndex = 56;
            this.atkup.Location = new System.Drawing.Point(78, 37);
            this.atkup.Maximum = new decimal(new int[4] { 15, 0, 0, 0 });
            this.atkup.Name = "atkup";
            this.atkup.Size = new System.Drawing.Size(39, 20);
            this.atkup.TabIndex = 57;
            this.defup.Location = new System.Drawing.Point(78, 58);
            this.defup.Maximum = new decimal(new int[4] { 15, 0, 0, 0 });
            this.defup.Name = "defup";
            this.defup.Size = new System.Drawing.Size(39, 20);
            this.defup.TabIndex = 58;
            this.speedup.Location = new System.Drawing.Point(78, 79);
            this.speedup.Maximum = new decimal(new int[4] { 15, 0, 0, 0 });
            this.speedup.Name = "speedup";
            this.speedup.Size = new System.Drawing.Size(39, 20);
            this.speedup.TabIndex = 59;
            this.spatkup.Location = new System.Drawing.Point(78, 100);
            this.spatkup.Maximum = new decimal(new int[4] { 15, 0, 0, 0 });
            this.spatkup.Name = "spatkup";
            this.spatkup.Size = new System.Drawing.Size(39, 20);
            this.spatkup.TabIndex = 60;
            this.accurup.Location = new System.Drawing.Point(78, 121);
            this.accurup.Maximum = new decimal(new int[4] { 15, 0, 0, 0 });
            this.accurup.Name = "accurup";
            this.accurup.Size = new System.Drawing.Size(39, 20);
            this.accurup.TabIndex = 61;
            this.ev_hp.Location = new System.Drawing.Point(13, 17);
            this.ev_hp.Name = "ev_hp";
            this.ev_hp.Size = new System.Drawing.Size(65, 18);
            this.ev_hp.TabIndex = 62;
            this.ev_hp.Text = "HP";
            this.ev_hp.UseVisualStyleBackColor = true;
            this.ev_atk.Location = new System.Drawing.Point(13, 38);
            this.ev_atk.Name = "ev_atk";
            this.ev_atk.Size = new System.Drawing.Size(65, 18);
            this.ev_atk.TabIndex = 63;
            this.ev_atk.Text = "Attack";
            this.ev_atk.UseVisualStyleBackColor = true;
            this.ev_def.Location = new System.Drawing.Point(13, 56);
            this.ev_def.Name = "ev_def";
            this.ev_def.Size = new System.Drawing.Size(75, 18);
            this.ev_def.TabIndex = 65;
            this.ev_def.Text = "Defense";
            this.ev_def.UseVisualStyleBackColor = true;
            this.ev_speed.Location = new System.Drawing.Point(13, 74);
            this.ev_speed.Name = "ev_speed";
            this.ev_speed.Size = new System.Drawing.Size(75, 18);
            this.ev_speed.TabIndex = 66;
            this.ev_speed.Text = "Speed";
            this.ev_speed.UseVisualStyleBackColor = true;
            this.ev_speatk.Location = new System.Drawing.Point(13, 91);
            this.ev_speatk.Name = "ev_speatk";
            this.ev_speatk.Size = new System.Drawing.Size(75, 18);
            this.ev_speatk.TabIndex = 67;
            this.ev_speatk.Text = "SPE Atk";
            this.ev_speatk.UseVisualStyleBackColor = true;
            this.ev_spedef.Location = new System.Drawing.Point(13, 109);
            this.ev_spedef.Name = "ev_spedef";
            this.ev_spedef.Size = new System.Drawing.Size(75, 18);
            this.ev_spedef.TabIndex = 68;
            this.ev_spedef.Text = "SPE Def";
            this.ev_spedef.UseVisualStyleBackColor = true;
            this.tr6_val.Location = new System.Drawing.Point(401, 207);
            this.tr6_val.Maximum = new decimal(new int[4] { 127, 0, 0, 0 });
            this.tr6_val.Name = "tr6_val";
            this.tr6_val.Size = new System.Drawing.Size(54, 20);
            this.tr6_val.TabIndex = 69;
            this.heal_hp.Location = new System.Drawing.Point(6, 21);
            this.heal_hp.Name = "heal_hp";
            this.heal_hp.Size = new System.Drawing.Size(104, 18);
            this.heal_hp.TabIndex = 70;
            this.heal_hp.Text = "Heal HP";
            this.heal_hp.UseVisualStyleBackColor = true;
            this.heal_pp.Location = new System.Drawing.Point(6, 39);
            this.heal_pp.Name = "heal_pp";
            this.heal_pp.Size = new System.Drawing.Size(104, 18);
            this.heal_pp.TabIndex = 71;
            this.heal_pp.Text = "Heal PP";
            this.heal_pp.UseVisualStyleBackColor = true;
            this.selectedatk.Location = new System.Drawing.Point(6, 57);
            this.selectedatk.Name = "selectedatk";
            this.selectedatk.Size = new System.Drawing.Size(139, 18);
            this.selectedatk.TabIndex = 73;
            this.selectedatk.Text = "Only to selected attack";
            this.selectedatk.UseVisualStyleBackColor = true;
            this.maxppUP.Location = new System.Drawing.Point(6, 78);
            this.maxppUP.Name = "maxppUP";
            this.maxppUP.Size = new System.Drawing.Size(109, 18);
            this.maxppUP.TabIndex = 74;
            this.maxppUP.Text = "Increase Max PP";
            this.maxppUP.UseVisualStyleBackColor = true;
            this.revive.Location = new System.Drawing.Point(6, 95);
            this.revive.Name = "revive";
            this.revive.Size = new System.Drawing.Size(104, 18);
            this.revive.TabIndex = 75;
            this.revive.Text = "Revive and heal";
            this.revive.UseVisualStyleBackColor = true;
            this.stone.Location = new System.Drawing.Point(6, 142);
            this.stone.Name = "stone";
            this.stone.Size = new System.Drawing.Size(104, 18);
            this.stone.TabIndex = 76;
            this.stone.Text = "Evolution stone";
            this.stone.UseVisualStyleBackColor = true;
            this.happy200.Location = new System.Drawing.Point(12, 16);
            this.happy200.Name = "happy200";
            this.happy200.Size = new System.Drawing.Size(104, 18);
            this.happy200.TabIndex = 77;
            this.happy200.Text = "Friendship >200";
            this.happy200.UseVisualStyleBackColor = true;
            this.happy100.Location = new System.Drawing.Point(12, 42);
            this.happy100.Name = "happy100";
            this.happy100.Size = new System.Drawing.Size(104, 18);
            this.happy100.TabIndex = 78;
            this.happy100.Text = "Friendship >100";
            this.happy100.UseVisualStyleBackColor = true;
            this.happy0.Location = new System.Drawing.Point(12, 68);
            this.happy0.Name = "happy0";
            this.happy0.Size = new System.Drawing.Size(109, 18);
            this.happy0.TabIndex = 79;
            this.happy0.Text = "Friendship < 100";
            this.happy0.UseVisualStyleBackColor = true;
            this.hap200.Location = new System.Drawing.Point(117, 16);
            this.hap200.Maximum = new decimal(new int[4] { 127, 0, 0, 0 });
            this.hap200.Name = "hap200";
            this.hap200.Size = new System.Drawing.Size(57, 20);
            this.hap200.TabIndex = 80;
            this.hap100.Location = new System.Drawing.Point(117, 42);
            this.hap100.Maximum = new decimal(new int[4] { 127, 0, 0, 0 });
            this.hap100.Name = "hap100";
            this.hap100.Size = new System.Drawing.Size(57, 20);
            this.hap100.TabIndex = 81;
            this.happ0.Location = new System.Drawing.Point(117, 68);
            this.happ0.Maximum = new decimal(new int[4] { 127, 0, 0, 0 });
            this.happ0.Name = "happ0";
            this.happ0.Size = new System.Drawing.Size(57, 20);
            this.happ0.TabIndex = 82;
            this.ppup.Location = new System.Drawing.Point(6, 111);
            this.ppup.Name = "ppup";
            this.ppup.Size = new System.Drawing.Size(124, 30);
            this.ppup.TabIndex = 83;
            this.ppup.Text = "Increase PP to max on selected attack";
            this.ppup.UseVisualStyleBackColor = true;
            this.groupBox1.Controls.Add(this.lvlup);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.note);
            this.groupBox1.Controls.Add(this.modifier_help);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tr6_val);
            this.groupBox1.Controls.Add(this.firstpoke);
            this.groupBox1.Location = new System.Drawing.Point(372, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 283);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usage by trainer:";
            this.groupBox6.Controls.Add(this.pphelp);
            this.groupBox6.Controls.Add(this.ppup);
            this.groupBox6.Controls.Add(this.stone);
            this.groupBox6.Controls.Add(this.revive);
            this.groupBox6.Controls.Add(this.maxppUP);
            this.groupBox6.Controls.Add(this.heal_pp);
            this.groupBox6.Controls.Add(this.heal_hp);
            this.groupBox6.Controls.Add(this.selectedatk);
            this.groupBox6.Location = new System.Drawing.Point(370, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(144, 168);
            this.groupBox6.TabIndex = 92;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "HP/PP";
            this.pphelp.Location = new System.Drawing.Point(113, 13);
            this.pphelp.Name = "pphelp";
            this.pphelp.Size = new System.Drawing.Size(25, 21);
            this.pphelp.TabIndex = 85;
            this.pphelp.Text = "?";
            this.pphelp.UseVisualStyleBackColor = true;
            this.pphelp.Click += new System.EventHandler(PphelpClick);
            this.groupBox5.Controls.Add(this.happ0);
            this.groupBox5.Controls.Add(this.hap100);
            this.groupBox5.Controls.Add(this.hap200);
            this.groupBox5.Controls.Add(this.happy0);
            this.groupBox5.Controls.Add(this.happy100);
            this.groupBox5.Controls.Add(this.happy200);
            this.groupBox5.Location = new System.Drawing.Point(6, 180);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(199, 96);
            this.groupBox5.TabIndex = 91;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Friendship";
            this.groupBox4.Controls.Add(this.heal_confu);
            this.groupBox4.Controls.Add(this.heal_para);
            this.groupBox4.Controls.Add(this.heal_ice);
            this.groupBox4.Controls.Add(this.heal_burn);
            this.groupBox4.Controls.Add(this.heal_poison);
            this.groupBox4.Controls.Add(this.heal_sleep);
            this.groupBox4.Controls.Add(this.heal_inf);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(121, 162);
            this.groupBox4.TabIndex = 90;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status";
            this.groupBox3.Controls.Add(this.accurup);
            this.groupBox3.Controls.Add(this.spatkup);
            this.groupBox3.Controls.Add(this.speedup);
            this.groupBox3.Controls.Add(this.defup);
            this.groupBox3.Controls.Add(this.atkup);
            this.groupBox3.Controls.Add(this.direhit);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.guard);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(133, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 162);
            this.groupBox3.TabIndex = 89;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Battle";
            this.groupBox2.Controls.Add(this.ev_spedef);
            this.groupBox2.Controls.Add(this.ev_speatk);
            this.groupBox2.Controls.Add(this.ev_speed);
            this.groupBox2.Controls.Add(this.ev_def);
            this.groupBox2.Controls.Add(this.ev_atk);
            this.groupBox2.Controls.Add(this.ev_hp);
            this.groupBox2.Location = new System.Drawing.Point(271, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(93, 133);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EV";
            this.note.Location = new System.Drawing.Point(301, 248);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(75, 23);
            this.note.TabIndex = 87;
            this.note.Text = "Note";
            this.note.UseVisualStyleBackColor = true;
            this.note.Click += new System.EventHandler(NoteClick);
            this.modifier_help.Location = new System.Drawing.Point(461, 206);
            this.modifier_help.Name = "modifier_help";
            this.modifier_help.Size = new System.Drawing.Size(25, 21);
            this.modifier_help.TabIndex = 86;
            this.modifier_help.Text = "?";
            this.modifier_help.UseVisualStyleBackColor = true;
            this.modifier_help.Click += new System.EventHandler(Modifier_helpClick);
            this.label14.Location = new System.Drawing.Point(395, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 20);
            this.label14.TabIndex = 84;
            this.label14.Text = "HP/PP/EV modifier:";
            this.AllowDrop = true;
            base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new System.Drawing.Size(901, 342);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.jap_encoding);
            base.Controls.Add(this.sprite_help);
            base.Controls.Add(this.palette_import_but);
            base.Controls.Add(this.palette_export_but);
            base.Controls.Add(this.sprite_import_but);
            base.Controls.Add(this.sprite_export_but);
            base.Controls.Add(this.held_help);
            base.Controls.Add(this.held);
            base.Controls.Add(this.label13);
            base.Controls.Add(this.desc2);
            base.Controls.Add(this.desc1);
            base.Controls.Add(this.label12);
            base.Controls.Add(this.smooth);
            base.Controls.Add(this.sour);
            base.Controls.Add(this.bitter);
            base.Controls.Add(this.sweet);
            base.Controls.Add(this.dry);
            base.Controls.Add(this.spicy);
            base.Controls.Add(this.label11);
            base.Controls.Add(this.label10);
            base.Controls.Add(this.label9);
            base.Controls.Add(this.label8);
            base.Controls.Add(this.label7);
            base.Controls.Add(this.growth);
            base.Controls.Add(this.label6);
            base.Controls.Add(this.yield_min);
            base.Controls.Add(this.yield_max);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.size);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.firm_box);
            base.Controls.Add(this.name);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.ecb_path);
            base.Controls.Add(this.save_ecb_but);
            base.Controls.Add(this.load_ecb_but);
            base.Name = "ECB_editor";
            this.Text = "ECB Editor";
            base.DragDrop += new System.Windows.Forms.DragEventHandler(ECB_editorDragDrop);
            base.DragEnter += new System.Windows.Forms.DragEventHandler(ECB_editorDragEnter);
            ((System.ComponentModel.ISupportInitialize)this.size).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.yield_max).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.yield_min).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.growth).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.spicy).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dry).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.sweet).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.bitter).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.sour).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.smooth).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.held).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.direhit).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.atkup).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.defup).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.speedup).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.spatkup).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.accurup).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.tr6_val).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.hap200).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.hap100).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.happ0).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}
