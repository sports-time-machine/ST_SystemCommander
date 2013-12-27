namespace SystemCommander
{
	partial class TheForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonReboot = new System.Windows.Forms.Button();
			this.buttonShutdown = new System.Windows.Forms.Button();
			this.buttonCommand1 = new System.Windows.Forms.Button();
			this.buttonCommand2 = new System.Windows.Forms.Button();
			this.buttonCommand3 = new System.Windows.Forms.Button();
			this.buttonExitClient = new System.Windows.Forms.Button();
			this.buttonBye = new System.Windows.Forms.Button();
			this.textBoxCommandLine = new System.Windows.Forms.TextBox();
			this.buttonExec = new System.Windows.Forms.Button();
			this.buttonHaifu = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonReboot
			// 
			this.buttonReboot.Location = new System.Drawing.Point(14, 15);
			this.buttonReboot.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.buttonReboot.Name = "buttonReboot";
			this.buttonReboot.Size = new System.Drawing.Size(146, 88);
			this.buttonReboot.TabIndex = 1;
			this.buttonReboot.Text = "リブート";
			this.buttonReboot.UseVisualStyleBackColor = true;
			this.buttonReboot.Click += new System.EventHandler(this.buttonReboot_Click);
			// 
			// buttonShutdown
			// 
			this.buttonShutdown.Location = new System.Drawing.Point(170, 15);
			this.buttonShutdown.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.buttonShutdown.Name = "buttonShutdown";
			this.buttonShutdown.Size = new System.Drawing.Size(146, 88);
			this.buttonShutdown.TabIndex = 2;
			this.buttonShutdown.Text = "シャットダウン";
			this.buttonShutdown.UseVisualStyleBackColor = true;
			this.buttonShutdown.Click += new System.EventHandler(this.buttonShutdown_Click);
			// 
			// buttonCommand1
			// 
			this.buttonCommand1.Location = new System.Drawing.Point(14, 215);
			this.buttonCommand1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.buttonCommand1.Name = "buttonCommand1";
			this.buttonCommand1.Size = new System.Drawing.Size(146, 88);
			this.buttonCommand1.TabIndex = 3;
			this.buttonCommand1.Text = "command1.cmd";
			this.buttonCommand1.UseVisualStyleBackColor = true;
			this.buttonCommand1.Click += new System.EventHandler(this.buttonCommand1_Click);
			// 
			// buttonCommand2
			// 
			this.buttonCommand2.Location = new System.Drawing.Point(170, 215);
			this.buttonCommand2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.buttonCommand2.Name = "buttonCommand2";
			this.buttonCommand2.Size = new System.Drawing.Size(146, 88);
			this.buttonCommand2.TabIndex = 4;
			this.buttonCommand2.Text = "command2.cmd";
			this.buttonCommand2.UseVisualStyleBackColor = true;
			this.buttonCommand2.Click += new System.EventHandler(this.buttonCommand2_Click);
			// 
			// buttonCommand3
			// 
			this.buttonCommand3.Location = new System.Drawing.Point(326, 215);
			this.buttonCommand3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.buttonCommand3.Name = "buttonCommand3";
			this.buttonCommand3.Size = new System.Drawing.Size(146, 88);
			this.buttonCommand3.TabIndex = 5;
			this.buttonCommand3.Text = "command3.cmd";
			this.buttonCommand3.UseVisualStyleBackColor = true;
			this.buttonCommand3.Click += new System.EventHandler(this.buttonCommand3_Click);
			// 
			// buttonExitClient
			// 
			this.buttonExitClient.Location = new System.Drawing.Point(327, 15);
			this.buttonExitClient.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.buttonExitClient.Name = "buttonExitClient";
			this.buttonExitClient.Size = new System.Drawing.Size(146, 88);
			this.buttonExitClient.TabIndex = 6;
			this.buttonExitClient.Text = "クライアント終了";
			this.buttonExitClient.UseVisualStyleBackColor = true;
			this.buttonExitClient.Click += new System.EventHandler(this.buttonExitClient_Click);
			// 
			// buttonBye
			// 
			this.buttonBye.Location = new System.Drawing.Point(327, 115);
			this.buttonBye.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.buttonBye.Name = "buttonBye";
			this.buttonBye.Size = new System.Drawing.Size(146, 88);
			this.buttonBye.TabIndex = 7;
			this.buttonBye.Text = "デーモン終了";
			this.buttonBye.UseVisualStyleBackColor = true;
			this.buttonBye.Click += new System.EventHandler(this.buttonBye_Click);
			// 
			// textBoxCommandLine
			// 
			this.textBoxCommandLine.AllowDrop = true;
			this.textBoxCommandLine.Location = new System.Drawing.Point(14, 371);
			this.textBoxCommandLine.Name = "textBoxCommandLine";
			this.textBoxCommandLine.Size = new System.Drawing.Size(381, 31);
			this.textBoxCommandLine.TabIndex = 8;
			// 
			// buttonExec
			// 
			this.buttonExec.Location = new System.Drawing.Point(401, 367);
			this.buttonExec.Name = "buttonExec";
			this.buttonExec.Size = new System.Drawing.Size(96, 39);
			this.buttonExec.TabIndex = 9;
			this.buttonExec.Text = "exec";
			this.buttonExec.UseVisualStyleBackColor = true;
			this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
			// 
			// buttonHaifu
			// 
			this.buttonHaifu.Location = new System.Drawing.Point(14, 115);
			this.buttonHaifu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.buttonHaifu.Name = "buttonHaifu";
			this.buttonHaifu.Size = new System.Drawing.Size(146, 88);
			this.buttonHaifu.TabIndex = 10;
			this.buttonHaifu.Text = "クライアント再配布";
			this.buttonHaifu.UseVisualStyleBackColor = true;
			this.buttonHaifu.Click += new System.EventHandler(this.buttonHaifu_Click);
			// 
			// TheForm
			// 
			this.AcceptButton = this.buttonExec;
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(540, 418);
			this.Controls.Add(this.buttonHaifu);
			this.Controls.Add(this.buttonExec);
			this.Controls.Add(this.textBoxCommandLine);
			this.Controls.Add(this.buttonBye);
			this.Controls.Add(this.buttonExitClient);
			this.Controls.Add(this.buttonCommand3);
			this.Controls.Add(this.buttonCommand2);
			this.Controls.Add(this.buttonCommand1);
			this.Controls.Add(this.buttonShutdown);
			this.Controls.Add(this.buttonReboot);
			this.Font = new System.Drawing.Font("メイリオ", 12F);
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Name = "TheForm";
			this.Text = "システムコマンダー";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonReboot;
		private System.Windows.Forms.Button buttonShutdown;
		private System.Windows.Forms.Button buttonCommand1;
		private System.Windows.Forms.Button buttonCommand2;
		private System.Windows.Forms.Button buttonCommand3;
		private System.Windows.Forms.Button buttonExitClient;
		private System.Windows.Forms.Button buttonBye;
		private System.Windows.Forms.TextBox textBoxCommandLine;
		private System.Windows.Forms.Button buttonExec;
		private System.Windows.Forms.Button buttonHaifu;
	}
}

