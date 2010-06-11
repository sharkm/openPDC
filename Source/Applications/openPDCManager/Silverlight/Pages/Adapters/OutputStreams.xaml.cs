﻿//*******************************************************************************************************
//  OutputStreams.xaml.cs - Gbtc
//
//  Tennessee Valley Authority, 2009
//  No copyright is claimed pursuant to 17 USC § 105.  All Other Rights Reserved.
//
//  This software is made freely available under the TVA Open Source Agreement (see below).
//
//  Code Modification History:
//  -----------------------------------------------------------------------------------------------------
//  10/15/2009 - Mehulbhai P. Thakkar
//       Generated original version of source code.
//
//*******************************************************************************************************

#region [ TVA Open Source Agreement ]
/*

 THIS OPEN SOURCE AGREEMENT ("AGREEMENT") DEFINES THE RIGHTS OF USE,REPRODUCTION, DISTRIBUTION,
 MODIFICATION AND REDISTRIBUTION OF CERTAIN COMPUTER SOFTWARE ORIGINALLY RELEASED BY THE
 TENNESSEE VALLEY AUTHORITY, A CORPORATE AGENCY AND INSTRUMENTALITY OF THE UNITED STATES GOVERNMENT
 ("GOVERNMENT AGENCY"). GOVERNMENT AGENCY IS AN INTENDED THIRD-PARTY BENEFICIARY OF ALL SUBSEQUENT
 DISTRIBUTIONS OR REDISTRIBUTIONS OF THE SUBJECT SOFTWARE. ANYONE WHO USES, REPRODUCES, DISTRIBUTES,
 MODIFIES OR REDISTRIBUTES THE SUBJECT SOFTWARE, AS DEFINED HEREIN, OR ANY PART THEREOF, IS, BY THAT
 ACTION, ACCEPTING IN FULL THE RESPONSIBILITIES AND OBLIGATIONS CONTAINED IN THIS AGREEMENT.

 Original Software Designation: openPDC
 Original Software Title: The TVA Open Source Phasor Data Concentrator
 User Registration Requested. Please Visit https://naspi.tva.com/Registration/
 Point of Contact for Original Software: J. Ritchie Carroll <mailto:jrcarrol@tva.gov>

 1. DEFINITIONS

 A. "Contributor" means Government Agency, as the developer of the Original Software, and any entity
 that makes a Modification.

 B. "Covered Patents" mean patent claims licensable by a Contributor that are necessarily infringed by
 the use or sale of its Modification alone or when combined with the Subject Software.

 C. "Display" means the showing of a copy of the Subject Software, either directly or by means of an
 image, or any other device.

 D. "Distribution" means conveyance or transfer of the Subject Software, regardless of means, to
 another.

 E. "Larger Work" means computer software that combines Subject Software, or portions thereof, with
 software separate from the Subject Software that is not governed by the terms of this Agreement.

 F. "Modification" means any alteration of, including addition to or deletion from, the substance or
 structure of either the Original Software or Subject Software, and includes derivative works, as that
 term is defined in the Copyright Statute, 17 USC § 101. However, the act of including Subject Software
 as part of a Larger Work does not in and of itself constitute a Modification.

 G. "Original Software" means the computer software first released under this Agreement by Government
 Agency entitled openPDC, including source code, object code and accompanying documentation, if any.

 H. "Recipient" means anyone who acquires the Subject Software under this Agreement, including all
 Contributors.

 I. "Redistribution" means Distribution of the Subject Software after a Modification has been made.

 J. "Reproduction" means the making of a counterpart, image or copy of the Subject Software.

 K. "Sale" means the exchange of the Subject Software for money or equivalent value.

 L. "Subject Software" means the Original Software, Modifications, or any respective parts thereof.

 M. "Use" means the application or employment of the Subject Software for any purpose.

 2. GRANT OF RIGHTS

 A. Under Non-Patent Rights: Subject to the terms and conditions of this Agreement, each Contributor,
 with respect to its own contribution to the Subject Software, hereby grants to each Recipient a
 non-exclusive, world-wide, royalty-free license to engage in the following activities pertaining to
 the Subject Software:

 1. Use

 2. Distribution

 3. Reproduction

 4. Modification

 5. Redistribution

 6. Display

 B. Under Patent Rights: Subject to the terms and conditions of this Agreement, each Contributor, with
 respect to its own contribution to the Subject Software, hereby grants to each Recipient under Covered
 Patents a non-exclusive, world-wide, royalty-free license to engage in the following activities
 pertaining to the Subject Software:

 1. Use

 2. Distribution

 3. Reproduction

 4. Sale

 5. Offer for Sale

 C. The rights granted under Paragraph B. also apply to the combination of a Contributor's Modification
 and the Subject Software if, at the time the Modification is added by the Contributor, the addition of
 such Modification causes the combination to be covered by the Covered Patents. It does not apply to
 any other combinations that include a Modification. 

 D. The rights granted in Paragraphs A. and B. allow the Recipient to sublicense those same rights.
 Such sublicense must be under the same terms and conditions of this Agreement.

 3. OBLIGATIONS OF RECIPIENT

 A. Distribution or Redistribution of the Subject Software must be made under this Agreement except for
 additions covered under paragraph 3H. 

 1. Whenever a Recipient distributes or redistributes the Subject Software, a copy of this Agreement
 must be included with each copy of the Subject Software; and

 2. If Recipient distributes or redistributes the Subject Software in any form other than source code,
 Recipient must also make the source code freely available, and must provide with each copy of the
 Subject Software information on how to obtain the source code in a reasonable manner on or through a
 medium customarily used for software exchange.

 B. Each Recipient must ensure that the following copyright notice appears prominently in the Subject
 Software:

          No copyright is claimed pursuant to 17 USC § 105.  All Other Rights Reserved.

 C. Each Contributor must characterize its alteration of the Subject Software as a Modification and
 must identify itself as the originator of its Modification in a manner that reasonably allows
 subsequent Recipients to identify the originator of the Modification. In fulfillment of these
 requirements, Contributor must include a file (e.g., a change log file) that describes the alterations
 made and the date of the alterations, identifies Contributor as originator of the alterations, and
 consents to characterization of the alterations as a Modification, for example, by including a
 statement that the Modification is derived, directly or indirectly, from Original Software provided by
 Government Agency. Once consent is granted, it may not thereafter be revoked.

 D. A Contributor may add its own copyright notice to the Subject Software. Once a copyright notice has
 been added to the Subject Software, a Recipient may not remove it without the express permission of
 the Contributor who added the notice.

 E. A Recipient may not make any representation in the Subject Software or in any promotional,
 advertising or other material that may be construed as an endorsement by Government Agency or by any
 prior Recipient of any product or service provided by Recipient, or that may seek to obtain commercial
 advantage by the fact of Government Agency's or a prior Recipient's participation in this Agreement.

 F. In an effort to track usage and maintain accurate records of the Subject Software, each Recipient,
 upon receipt of the Subject Software, is requested to register with Government Agency by visiting the
 following website: https://naspi.tva.com/Registration/. Recipient's name and personal information
 shall be used for statistical purposes only. Once a Recipient makes a Modification available, it is
 requested that the Recipient inform Government Agency at the web site provided above how to access the
 Modification.

 G. Each Contributor represents that that its Modification does not violate any existing agreements,
 regulations, statutes or rules, and further that Contributor has sufficient rights to grant the rights
 conveyed by this Agreement.

 H. A Recipient may choose to offer, and to charge a fee for, warranty, support, indemnity and/or
 liability obligations to one or more other Recipients of the Subject Software. A Recipient may do so,
 however, only on its own behalf and not on behalf of Government Agency or any other Recipient. Such a
 Recipient must make it absolutely clear that any such warranty, support, indemnity and/or liability
 obligation is offered by that Recipient alone. Further, such Recipient agrees to indemnify Government
 Agency and every other Recipient for any liability incurred by them as a result of warranty, support,
 indemnity and/or liability offered by such Recipient.

 I. A Recipient may create a Larger Work by combining Subject Software with separate software not
 governed by the terms of this agreement and distribute the Larger Work as a single product. In such
 case, the Recipient must make sure Subject Software, or portions thereof, included in the Larger Work
 is subject to this Agreement.

 J. Notwithstanding any provisions contained herein, Recipient is hereby put on notice that export of
 any goods or technical data from the United States may require some form of export license from the
 U.S. Government. Failure to obtain necessary export licenses may result in criminal liability under
 U.S. laws. Government Agency neither represents that a license shall not be required nor that, if
 required, it shall be issued. Nothing granted herein provides any such export license.

 4. DISCLAIMER OF WARRANTIES AND LIABILITIES; WAIVER AND INDEMNIFICATION

 A. No Warranty: THE SUBJECT SOFTWARE IS PROVIDED "AS IS" WITHOUT ANY WARRANTY OF ANY KIND, EITHER
 EXPRESSED, IMPLIED, OR STATUTORY, INCLUDING, BUT NOT LIMITED TO, ANY WARRANTY THAT THE SUBJECT
 SOFTWARE WILL CONFORM TO SPECIFICATIONS, ANY IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
 PARTICULAR PURPOSE, OR FREEDOM FROM INFRINGEMENT, ANY WARRANTY THAT THE SUBJECT SOFTWARE WILL BE ERROR
 FREE, OR ANY WARRANTY THAT DOCUMENTATION, IF PROVIDED, WILL CONFORM TO THE SUBJECT SOFTWARE. THIS
 AGREEMENT DOES NOT, IN ANY MANNER, CONSTITUTE AN ENDORSEMENT BY GOVERNMENT AGENCY OR ANY PRIOR
 RECIPIENT OF ANY RESULTS, RESULTING DESIGNS, HARDWARE, SOFTWARE PRODUCTS OR ANY OTHER APPLICATIONS
 RESULTING FROM USE OF THE SUBJECT SOFTWARE. FURTHER, GOVERNMENT AGENCY DISCLAIMS ALL WARRANTIES AND
 LIABILITIES REGARDING THIRD-PARTY SOFTWARE, IF PRESENT IN THE ORIGINAL SOFTWARE, AND DISTRIBUTES IT
 "AS IS."

 B. Waiver and Indemnity: RECIPIENT AGREES TO WAIVE ANY AND ALL CLAIMS AGAINST GOVERNMENT AGENCY, ITS
 AGENTS, EMPLOYEES, CONTRACTORS AND SUBCONTRACTORS, AS WELL AS ANY PRIOR RECIPIENT. IF RECIPIENT'S USE
 OF THE SUBJECT SOFTWARE RESULTS IN ANY LIABILITIES, DEMANDS, DAMAGES, EXPENSES OR LOSSES ARISING FROM
 SUCH USE, INCLUDING ANY DAMAGES FROM PRODUCTS BASED ON, OR RESULTING FROM, RECIPIENT'S USE OF THE
 SUBJECT SOFTWARE, RECIPIENT SHALL INDEMNIFY AND HOLD HARMLESS  GOVERNMENT AGENCY, ITS AGENTS,
 EMPLOYEES, CONTRACTORS AND SUBCONTRACTORS, AS WELL AS ANY PRIOR RECIPIENT, TO THE EXTENT PERMITTED BY
 LAW.  THE FOREGOING RELEASE AND INDEMNIFICATION SHALL APPLY EVEN IF THE LIABILITIES, DEMANDS, DAMAGES,
 EXPENSES OR LOSSES ARE CAUSED, OCCASIONED, OR CONTRIBUTED TO BY THE NEGLIGENCE, SOLE OR CONCURRENT, OF
 GOVERNMENT AGENCY OR ANY PRIOR RECIPIENT.  RECIPIENT'S SOLE REMEDY FOR ANY SUCH MATTER SHALL BE THE
 IMMEDIATE, UNILATERAL TERMINATION OF THIS AGREEMENT.

 5. GENERAL TERMS

 A. Termination: This Agreement and the rights granted hereunder will terminate automatically if a
 Recipient fails to comply with these terms and conditions, and fails to cure such noncompliance within
 thirty (30) days of becoming aware of such noncompliance. Upon termination, a Recipient agrees to
 immediately cease use and distribution of the Subject Software. All sublicenses to the Subject
 Software properly granted by the breaching Recipient shall survive any such termination of this
 Agreement.

 B. Severability: If any provision of this Agreement is invalid or unenforceable under applicable law,
 it shall not affect the validity or enforceability of the remainder of the terms of this Agreement.

 C. Applicable Law: This Agreement shall be subject to United States federal law only for all purposes,
 including, but not limited to, determining the validity of this Agreement, the meaning of its
 provisions and the rights, obligations and remedies of the parties.

 D. Entire Understanding: This Agreement constitutes the entire understanding and agreement of the
 parties relating to release of the Subject Software and may not be superseded, modified or amended
 except by further written agreement duly executed by the parties.

 E. Binding Authority: By accepting and using the Subject Software under this Agreement, a Recipient
 affirms its authority to bind the Recipient to all terms and conditions of this Agreement and that
 Recipient hereby agrees to all terms and conditions herein.

 F. Point of Contact: Any Recipient contact with Government Agency is to be directed to the designated
 representative as follows: J. Ritchie Carroll <mailto:jrcarrol@tva.gov>.

*/
#endregion

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using openPDCManager.Silverlight.ModalDialogs;
using openPDCManager.Silverlight.ModalDialogs.OutputStreamWizard;
using openPDCManager.Silverlight.PhasorDataServiceProxy;
using openPDCManager.Silverlight.Utilities;

namespace openPDCManager.Silverlight.Pages.Adapters
{
	public partial class OutputStreams : Page
	{
		#region [ Members ]

		PhasorDataServiceClient m_client;
		bool m_inEditMode = false;
		int m_outputStreamID = 0;
		string m_nodeValue;

		#endregion

		#region [ Constructor ]

		public OutputStreams()
		{
			InitializeComponent();
			m_client = Common.GetPhasorDataServiceProxyClient();
			m_client.GetNodesCompleted += new EventHandler<GetNodesCompletedEventArgs>(client_GetNodesCompleted);
			m_client.GetOutputStreamListCompleted += new EventHandler<GetOutputStreamListCompletedEventArgs>(client_GetOutputStreamListCompleted);
			m_client.SaveOutputStreamCompleted += new EventHandler<SaveOutputStreamCompletedEventArgs>(client_SaveOutputStreamCompleted);
			ButtonClear.Click += new RoutedEventHandler(ButtonClear_Click);
			ButtonSave.Click += new RoutedEventHandler(ButtonSave_Click);
			ListBoxOutputStreamList.SelectionChanged += new SelectionChangedEventHandler(ListBoxOutputStreamList_SelectionChanged);
			Loaded += new RoutedEventHandler(OutputStreams_Loaded);
			ButtonBuildCommandChannel.Click += new RoutedEventHandler(ButtonBuildCommandChannel_Click);
			ButtonBuildDataChannel.Click += new RoutedEventHandler(ButtonBuildDataChannel_Click);
		}		

		#endregion

		#region [ Service Event Handlers ]

		void client_SaveOutputStreamCompleted(object sender, SaveOutputStreamCompletedEventArgs e)
		{
			SystemMessages sm;
			if (e.Error == null)
			{
				ClearForm();
				sm = new SystemMessages(new Message() { UserMessage = e.Result, SystemMessage = string.Empty, UserMessageType = MessageType.Success },
						ButtonType.OkOnly);
			}
			else
			{
				if (e.Error is FaultException<CustomServiceFault>)
				{
					FaultException<CustomServiceFault> fault = e.Error as FaultException<CustomServiceFault>;
					sm = new SystemMessages(new Message() { UserMessage = fault.Detail.UserMessage, SystemMessage = fault.Detail.SystemMessage, UserMessageType = MessageType.Error },
						ButtonType.OkOnly);
				}
				else
					sm = new SystemMessages(new Message() { UserMessage = "Failed to Save Output Stream Information", SystemMessage = e.Error.Message, UserMessageType = MessageType.Error },
						ButtonType.OkOnly);
			}
			sm.Show();
			m_client.GetOutputStreamListAsync(false, m_nodeValue);
		}
		
		void client_GetOutputStreamListCompleted(object sender, GetOutputStreamListCompletedEventArgs e)
		{
			if (e.Error == null)
				ListBoxOutputStreamList.ItemsSource = e.Result;
			else
			{
				SystemMessages sm;
				if (e.Error is FaultException<CustomServiceFault>)
				{
					FaultException<CustomServiceFault> fault = e.Error as FaultException<CustomServiceFault>;
					sm = new SystemMessages(new Message() { UserMessage = fault.Detail.UserMessage, SystemMessage = fault.Detail.SystemMessage, UserMessageType = MessageType.Error },
						ButtonType.OkOnly);
				}
				else
					sm = new SystemMessages(new Message() { UserMessage = "Failed to Retrieve Output Stream List", SystemMessage = e.Error.Message, UserMessageType = MessageType.Error },
						ButtonType.OkOnly);

				sm.Show();
			}
		}

		void client_GetNodesCompleted(object sender, GetNodesCompletedEventArgs e)
		{
			if (e.Error == null)
				ComboBoxNode.ItemsSource = e.Result;
			else
			{
				SystemMessages sm;
				if (e.Error is FaultException<CustomServiceFault>)
				{
					FaultException<CustomServiceFault> fault = e.Error as FaultException<CustomServiceFault>;
					sm = new SystemMessages(new Message() { UserMessage = fault.Detail.UserMessage, SystemMessage = fault.Detail.SystemMessage, UserMessageType = MessageType.Error },
						ButtonType.OkOnly);
				}
				else
					sm = new SystemMessages(new Message() { UserMessage = "Failed to Retrieve Nodes", SystemMessage = e.Error.Message, UserMessageType = MessageType.Error },
						ButtonType.OkOnly);

				sm.Show();
			}
			if (ComboBoxNode.Items.Count > 0)
				ComboBoxNode.SelectedIndex = 0;
		}

		#endregion

		#region [ Page Event Handlers ]

		void OutputStreams_Loaded(object sender, RoutedEventArgs e)
		{
            ClearForm();
		}

		// Executes when the user navigates to this page.
		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			m_nodeValue = ((App)Application.Current).NodeValue;
			m_client.GetNodesAsync(true, false);
			ComboBoxType.Items.Add(new KeyValuePair<int, string>(0, "IEEE C37.118"));
			ComboBoxType.Items.Add(new KeyValuePair<int, string>(1, "BPA"));
			ComboBoxType.SelectedIndex = 0;
            ComboboxDownsamplingMethod.Items.Add("LastReceived");
            ComboboxDownsamplingMethod.Items.Add("Closest");
            ComboboxDownsamplingMethod.Items.Add("Filtered");
            ComboboxDownsamplingMethod.SelectedIndex = 0;
            ComboboxDataFormat.Items.Add("FloatingPoint");
            ComboboxDataFormat.Items.Add("FixedInteger");
            ComboboxDataFormat.SelectedIndex = 0;
            ComboboxCoordinateFormat.Items.Add("Polar");
            ComboboxCoordinateFormat.Items.Add("Rectangular");
            ComboboxCoordinateFormat.SelectedIndex = 0;
			m_client.GetOutputStreamListAsync(false, m_nodeValue);
		}

		#endregion

		#region [ Control Event Handlers ]

		void ListBoxOutputStreamList_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (ListBoxOutputStreamList.SelectedIndex >= 0)
			{
				OutputStream selectedOutputStream = ListBoxOutputStreamList.SelectedItem as OutputStream;
				GridOutputStreamDetail.DataContext = selectedOutputStream;
				ComboBoxNode.SelectedItem = new KeyValuePair<string, string>(selectedOutputStream.NodeID, selectedOutputStream.NodeName);
				if (selectedOutputStream.Type == 0)
					ComboBoxType.SelectedItem = new KeyValuePair<int, string>(0, "IEEE C37.118");
				else
					ComboBoxType.SelectedItem = new KeyValuePair<int, string>(1, "BPA");
                ComboboxCoordinateFormat.SelectedItem = selectedOutputStream.CoordinateFormat;
                ComboboxDownsamplingMethod.SelectedItem = selectedOutputStream.DownsamplingMethod;
                ComboboxDataFormat.SelectedItem = selectedOutputStream.DataFormat;
				CheckBoxAllowSortsByArrival.IsChecked = selectedOutputStream.AllowSortsByArrival;
				CheckBoxAutoPublishConfigFrame.IsChecked = selectedOutputStream.AutoPublishConfigFrame;
				CheckBoxAutoStartDataChannel.IsChecked = selectedOutputStream.AutoStartDataChannel;
				CheckBoxEnabled.IsChecked = selectedOutputStream.Enabled;
				CheckBoxUseLocalClockAsRealTime.IsChecked = selectedOutputStream.UseLocalClockAsRealTime;
				m_outputStreamID = selectedOutputStream.ID;
				m_inEditMode = true;
			}
		}

        void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sb = new Storyboard();
            sb = Application.Current.Resources["ButtonPressAnimation"] as Storyboard;
            sb.Completed += new EventHandler(delegate(object obj, EventArgs es) { sb.Stop(); });
            Storyboard.SetTarget(sb, ButtonSaveTransform);
            sb.Begin();

            if (IsValid())
            {
                OutputStream outputStream = new OutputStream();
                outputStream.NodeID = ((KeyValuePair<string, string>)ComboBoxNode.SelectedItem).Key;
                outputStream.Acronym = TextBoxAcronym.Text.CleanText();
                outputStream.Name = TextBoxName.Text.CleanText();
                outputStream.Type = ((KeyValuePair<int, string>)ComboBoxType.SelectedItem).Key;
                outputStream.ConnectionString = TextBoxConnectionString.Text.CleanText();
                outputStream.IDCode = TextBoxIDCode.Text.ToInteger();
                outputStream.CommandChannel = TextBoxCommandChannel.Text.CleanText();
                outputStream.DataChannel = TextBoxDataChannel.Text.CleanText();
                outputStream.AutoPublishConfigFrame = (bool)CheckBoxAutoPublishConfigFrame.IsChecked;
                outputStream.AutoStartDataChannel = (bool)CheckBoxAutoStartDataChannel.IsChecked;
                outputStream.NominalFrequency = TextBoxNominalFrequency.Text.ToInteger();
                outputStream.FramesPerSecond = TextBoxFramesPerSecond.Text.ToInteger();
                outputStream.LagTime = TextBoxLagTime.Text.ToDouble();
                outputStream.LeadTime = TextBoxLeadTime.Text.ToDouble();
                outputStream.UseLocalClockAsRealTime = (bool)CheckBoxUseLocalClockAsRealTime.IsChecked;
                outputStream.AllowSortsByArrival = (bool)CheckBoxAllowSortsByArrival.IsChecked;
                outputStream.LoadOrder = TextBoxLoadOrder.Text.ToInteger();
                outputStream.Enabled = (bool)CheckBoxEnabled.IsChecked;
                outputStream.IgnoreBadTimeStamps = (bool)CheckBoxIgnoreBadTimeStamps.IsChecked;
                outputStream.TimeResolution = TextBoxTimeResolution.Text.ToInteger();
                outputStream.AllowPreemptivePublishing = (bool)CheckBoxAllowPreemptivePublishing.IsChecked;
                outputStream.DownsamplingMethod = ComboboxDownsamplingMethod.SelectedItem.ToString();
                outputStream.DataFormat = ComboboxDataFormat.SelectedItem.ToString();
                outputStream.CoordinateFormat = ComboboxCoordinateFormat.SelectedItem.ToString();
                outputStream.CurrentScalingValue = TextBoxCurrentScalingValue.Text.ToInteger();
                outputStream.VoltageScalingValue = TextBoxVoltageScalingValue.Text.ToInteger();
                outputStream.AnalogScalingValue = TextBoxAnalogScalingValue.Text.ToInteger();
                outputStream.DigitalMaskValue = TextBoxDigitalMaskValue.Text.ToInteger();

                if (m_inEditMode == true && m_outputStreamID > 0)
                {
                    outputStream.ID = m_outputStreamID;
                    m_client.SaveOutputStreamAsync(outputStream, false);
                }
                else
                    m_client.SaveOutputStreamAsync(outputStream, true);
            }
        }
		
		void ButtonClear_Click(object sender, RoutedEventArgs e)
		{
			Storyboard sb = new Storyboard();
			sb = Application.Current.Resources["ButtonPressAnimation"] as Storyboard;
			sb.Completed += new EventHandler(delegate(object obj, EventArgs es) { sb.Stop(); });
			Storyboard.SetTarget(sb, ButtonClearTransform);
			sb.Begin();

			ClearForm();
		}

		void HyperlinkButtonDevices_Click(object sender, RoutedEventArgs e)
		{
			int outputStreamId = Convert.ToInt32(((HyperlinkButton)sender).Tag.ToString());
			string acronym = ((HyperlinkButton)sender).Name;
			OutputStreamDevices osd = new OutputStreamDevices(outputStreamId, acronym);
			osd.Show();
		}
		
		void HyperlinkButtonMeasurements_Click(object sender, RoutedEventArgs e)
		{
			int outputStreamId = Convert.ToInt32(((HyperlinkButton)sender).Tag.ToString());
			string acronym = ((HyperlinkButton)sender).Name;
			OutputStreamMeasurements osm = new OutputStreamMeasurements(outputStreamId, acronym);
			osm.Show();
		}
		
		void HyperlinkButtonWizard_Click(object sender, RoutedEventArgs e)
		{
			int outputStreamId = Convert.ToInt32(((HyperlinkButton)sender).Tag.ToString());
			string acronym = ((HyperlinkButton)sender).Name;
			CurrentDevices currentDevices = new CurrentDevices(outputStreamId, acronym);
			currentDevices.Show();
		}

		void ButtonBuildDataChannel_Click(object sender, RoutedEventArgs e)
		{
			ConnectionStringBuilder csb = new ConnectionStringBuilder(ConnectionStringBuilder.ConnectionType.DataChannel);
			if (!string.IsNullOrEmpty(TextBoxDataChannel.Text))
				csb.ConnectionString = TextBoxDataChannel.Text;
			csb.Closed += new EventHandler(delegate(object popupWindow, EventArgs eargs)
			{
				if ((bool)csb.DialogResult)
					TextBoxDataChannel.Text = csb.ConnectionString;
			});
			csb.Show();
		}

		void ButtonBuildCommandChannel_Click(object sender, RoutedEventArgs e)
		{
			ConnectionStringBuilder csb = new ConnectionStringBuilder(ConnectionStringBuilder.ConnectionType.CommandChannel);
			if (!string.IsNullOrEmpty(TextBoxCommandChannel.Text))
				csb.ConnectionString = TextBoxCommandChannel.Text;
			csb.Closed += new EventHandler(delegate(object popupWindow, EventArgs eargs)
			{
				if ((bool)csb.DialogResult)
					TextBoxCommandChannel.Text = csb.ConnectionString;
			});
			csb.Show();
		}

		#endregion

		#region [ Methods ]

        bool IsValid()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(TextBoxAcronym.Text.CleanText()))
            {
                isValid = false;
                SystemMessages sm = new SystemMessages(new Message() { UserMessage = "Invalid Acronym", SystemMessage = "Please provide valid Acronym.", UserMessageType = MessageType.Error },
                        ButtonType.OkOnly);
                sm.Closed += new EventHandler(delegate(object sender, EventArgs e)
                                                {
                                                    TextBoxAcronym.Focus();
                                                });
                sm.Show();
                return isValid;
            }

            if (!TextBoxIDCode.Text.IsInteger())
            {
                isValid = false;
                SystemMessages sm = new SystemMessages(new Message() { UserMessage = "Invalid ID Code", SystemMessage = "Please provide valid integer value for ID Code.", UserMessageType = MessageType.Error },
                        ButtonType.OkOnly);
                sm.Closed += new EventHandler(delegate(object sender, EventArgs e)
                                                {
                                                    TextBoxIDCode.Focus();
                                                });
                sm.Show();
                return isValid;
            }

            if (!TextBoxNominalFrequency.Text.IsInteger())
            {
                isValid = false;
                SystemMessages sm = new SystemMessages(new Message() { UserMessage = "Invalid Nominal Frequency", SystemMessage = "Please provide valid integer value for Nominal Frequency.", UserMessageType = MessageType.Error },
                        ButtonType.OkOnly);
                sm.Closed += new EventHandler(delegate(object sender, EventArgs e)
                                                {
                                                    TextBoxNominalFrequency.Focus();
                                                });
                sm.Show();
                return isValid;
            }

            if (!TextBoxFramesPerSecond.Text.IsInteger())
            {
                isValid = false;
                SystemMessages sm = new SystemMessages(new Message() { UserMessage = "Invalid Frames Per Second", SystemMessage = "Please provide valid integer value for Frames Per Second.", UserMessageType = MessageType.Error },
                        ButtonType.OkOnly);
                sm.Closed += new EventHandler(delegate(object sender, EventArgs e)
                                                {
                                                    TextBoxFramesPerSecond.Focus();
                                                });
                sm.Show();
                return isValid;
            }

            if (!TextBoxLagTime.Text.IsDouble())
            {
                isValid = false;
                SystemMessages sm = new SystemMessages(new Message() { UserMessage = "Invalid Lag Time", SystemMessage = "Please provide valid numeric value for Lag Time.", UserMessageType = MessageType.Error },
                        ButtonType.OkOnly);
                sm.Closed += new EventHandler(delegate(object sender, EventArgs e)
                                                {
                                                    TextBoxLagTime.Focus();
                                                });
                sm.Show();
                return isValid;
            }

            if (!TextBoxLeadTime.Text.IsDouble())
            {
                isValid = false;
                SystemMessages sm = new SystemMessages(new Message() { UserMessage = "Invalid Lead Time", SystemMessage = "Please provide valid numeric value for Lead Time.", UserMessageType = MessageType.Error },
                        ButtonType.OkOnly);
                sm.Closed += new EventHandler(delegate(object sender, EventArgs e)
                                                {
                                                    TextBoxLeadTime.Focus();
                                                });
                sm.Show();
                return isValid;
            }

            if (!TextBoxLoadOrder.Text.IsInteger())
            {
                isValid = false;
                SystemMessages sm = new SystemMessages(new Message() { UserMessage = "Invalid Load Order", SystemMessage = "Please provide valid integer value for Load Order.", UserMessageType = MessageType.Error },
                        ButtonType.OkOnly);
                sm.Closed += new EventHandler(delegate(object sender, EventArgs e)
                                                {
                                                    TextBoxLoadOrder.Focus();
                                                });
                sm.Show();
                return isValid;
            }

            if (!TextBoxTimeResolution.Text.IsInteger())
            {
                isValid = false;
                SystemMessages sm = new SystemMessages(new Message() { UserMessage = "Invalid Time Resolution", SystemMessage = "Please provide valid integer value for Time Resolution.", UserMessageType = MessageType.Error },
                        ButtonType.OkOnly);
                sm.Closed += new EventHandler(delegate(object sender, EventArgs e)
                {
                    TextBoxTimeResolution.Focus();
                });
                sm.Show();
                return isValid;
            }

            if (!TextBoxCurrentScalingValue.Text.IsInteger())
            {
                isValid = false;
                SystemMessages sm = new SystemMessages(new Message() { UserMessage = "Invalid Current Scaling Value", SystemMessage = "Please provide valid integer value for Current Scaling Value.", UserMessageType = MessageType.Error },
                        ButtonType.OkOnly);
                sm.Closed += new EventHandler(delegate(object sender, EventArgs e)
                {
                    TextBoxCurrentScalingValue.Focus();
                });
                sm.Show();
                return isValid;
            }

            if (!TextBoxVoltageScalingValue.Text.IsInteger())
            {
                isValid = false;
                SystemMessages sm = new SystemMessages(new Message() { UserMessage = "Invalid Voltage Scaling Value", SystemMessage = "Please provide valid integer value for Voltage Scaling Value.", UserMessageType = MessageType.Error },
                        ButtonType.OkOnly);
                sm.Closed += new EventHandler(delegate(object sender, EventArgs e)
                {
                    TextBoxVoltageScalingValue.Focus();
                });
                sm.Show();
                return isValid;
            }

            if (!TextBoxAnalogScalingValue.Text.IsInteger())
            {
                isValid = false;
                SystemMessages sm = new SystemMessages(new Message() { UserMessage = "Invalid Analog Scaling Value", SystemMessage = "Please provide valid integer value for Analog Scaling Value.", UserMessageType = MessageType.Error },
                        ButtonType.OkOnly);
                sm.Closed += new EventHandler(delegate(object sender, EventArgs e)
                {
                    TextBoxAnalogScalingValue.Focus();
                });
                sm.Show();
                return isValid;
            }

            if (!TextBoxDigitalMaskValue.Text.IsInteger())
            {
                isValid = false;
                SystemMessages sm = new SystemMessages(new Message() { UserMessage = "Invalid Digital Mask Value", SystemMessage = "Please provide valid integer value for Digital Mask Value.", UserMessageType = MessageType.Error },
                        ButtonType.OkOnly);
                sm.Closed += new EventHandler(delegate(object sender, EventArgs e)
                {
                    TextBoxDigitalMaskValue.Focus();
                });
                sm.Show();
                return isValid;
            }

            return isValid;
        }

		void ClearForm()
		{
            GridOutputStreamDetail.DataContext = new OutputStream() { AutoStartDataChannel = true, 
                                                                      NominalFrequency = 60, 
                                                                      FramesPerSecond = 30, 
                                                                      LagTime = 3, 
                                                                      LeadTime = 1, 
                                                                      AllowSortsByArrival = true,
                                                                      TimeResolution = 10000,
                                                                      AllowPreemptivePublishing = true,
                                                                      CurrentScalingValue = 2423,
                                                                      VoltageScalingValue = 2725785,
                                                                      AnalogScalingValue = 1373291,
                                                                      DigitalMaskValue = -65536
                                                                    };
			if (ComboBoxNode.Items.Count > 0)
				ComboBoxNode.SelectedIndex = 0;
			if (ComboBoxType.Items.Count > 0)
				ComboBoxType.SelectedIndex = 0;
            if (ComboboxDownsamplingMethod.Items.Count > 0)
                ComboboxDownsamplingMethod.SelectedIndex = 0;
            if (ComboboxCoordinateFormat.Items.Count > 0)
                ComboboxCoordinateFormat.SelectedIndex = 0;
            if (ComboboxDataFormat.Items.Count > 0)
                ComboboxDataFormat.SelectedIndex = 0;
			CheckBoxAllowSortsByArrival.IsChecked = false;
			CheckBoxAutoPublishConfigFrame.IsChecked = false;
			CheckBoxAutoStartDataChannel.IsChecked = false;
			CheckBoxEnabled.IsChecked = false;
			CheckBoxUseLocalClockAsRealTime.IsChecked = false;
			m_inEditMode = false;
			m_outputStreamID = 0;
			ListBoxOutputStreamList.SelectedIndex = -1;
		}

		#endregion

	}
}
