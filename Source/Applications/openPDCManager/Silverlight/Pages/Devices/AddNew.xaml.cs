﻿//*******************************************************************************************************
//  AddNew.xaml.cs - Gbtc
//
//  Tennessee Valley Authority, 2009
//  No copyright is claimed pursuant to 17 USC § 105.  All Other Rights Reserved.
//
//  This software is made freely available under the TVA Open Source Agreement (see below).
//
//  Code Modification History:
//  -----------------------------------------------------------------------------------------------------
//  09/28/2009 - Mehulbhai P. Thakkar
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
using openPDCManager.Silverlight.PhasorDataServiceProxy;
using openPDCManager.Silverlight.Utilities;

namespace openPDCManager.Silverlight.Pages.Devices
{
	public partial class AddNew : Page
	{
		#region [ Members ]

		PhasorDataServiceClient m_client;
		ActivityWindow m_activityWindow;
		bool m_inEditMode = false;
		int m_deviceID = 0;
        Device m_deviceToEdit;

		#endregion

		#region [ Constructor ]

		public AddNew()
		{
			InitializeComponent();
			Loaded += new RoutedEventHandler(AddNew_Loaded);
			m_client = Common.GetPhasorDataServiceProxyClient();
			m_client.GetDevicesCompleted += new EventHandler<GetDevicesCompletedEventArgs>(client_GetDevicesCompleted);
			m_client.GetCompaniesCompleted += new EventHandler<GetCompaniesCompletedEventArgs>(client_GetCompaniesCompleted);
			m_client.GetNodesCompleted += new EventHandler<GetNodesCompletedEventArgs>(client_GetNodesCompleted);
			m_client.GetHistoriansCompleted += new EventHandler<GetHistoriansCompletedEventArgs>(client_GetHistoriansCompleted);
			m_client.GetInterconnectionsCompleted += new EventHandler<GetInterconnectionsCompletedEventArgs>(client_GetInterconnectionsCompleted);
			m_client.GetVendorDevicesCompleted += new EventHandler<GetVendorDevicesCompletedEventArgs>(client_GetVendorDevicesCompleted);
			m_client.GetProtocolsCompleted += new EventHandler<GetProtocolsCompletedEventArgs>(client_GetProtocolsCompleted);
			m_client.GetTimeZonesCompleted += new EventHandler<GetTimeZonesCompletedEventArgs>(client_GetTimeZonesCompleted);
			m_client.SaveDeviceCompleted += new EventHandler<SaveDeviceCompletedEventArgs>(client_SaveDeviceCompleted);
			m_client.GetDeviceByDeviceIDCompleted += new EventHandler<GetDeviceByDeviceIDCompletedEventArgs>(client_GetDeviceByDeviceIDCompleted);
			m_client.GetConcentratorDeviceCompleted += new EventHandler<GetConcentratorDeviceCompletedEventArgs>(client_GetConcentratorDeviceCompleted);
			m_client.GetDeviceListByParentIDCompleted += new EventHandler<GetDeviceListByParentIDCompletedEventArgs>(client_GetDeviceListByParentIDCompleted);
			ButtonSave.Click += new RoutedEventHandler(ButtonSave_Click);
			ButtonClear.Click += new RoutedEventHandler(ButtonClear_Click);
			ButtonView.Click += new RoutedEventHandler(ButtonView_Click);
			ComboboxParent.SelectionChanged += new SelectionChangedEventHandler(ComboboxParent_SelectionChanged);
			ButtonBuildConnectionString.Click += new RoutedEventHandler(ButtonBuildConnectionString_Click);
		}

		#endregion

		#region [ Service Event Handlers ]

		void client_GetDeviceListByParentIDCompleted(object sender, GetDeviceListByParentIDCompletedEventArgs e)
		{
			if (e.Error == null)
				ListBoxDeviceList.ItemsSource = e.Result;
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
					sm = new SystemMessages(new Message() { UserMessage = "Failed to Retrieve Device List By Parent ID", SystemMessage = e.Error.Message, UserMessageType = MessageType.Error },
						ButtonType.OkOnly);

				sm.Show();
			}
		}

		void client_GetConcentratorDeviceCompleted(object sender, GetConcentratorDeviceCompletedEventArgs e)
		{
			if (e.Error == null && e.Result != null)
			{
				Device device = new Device();
				device = e.Result;
				ToolTip toolTip = new ToolTip();
				toolTip.DataContext = device;
				toolTip.Template = Application.Current.Resources["PdcInfoToolTipTemplate"] as ControlTemplate;
				ToolTipService.SetToolTip(ButtonView, toolTip);
			}
		}

		void client_GetDeviceByDeviceIDCompleted(object sender, GetDeviceByDeviceIDCompletedEventArgs e)
		{
			m_deviceToEdit = new Device();
			if (e.Error == null)
			{
				//System.Threading.Thread.Sleep(3000);
				m_deviceToEdit = e.Result;
				GridDeviceDetail.DataContext = m_deviceToEdit;

                if (ComboboxNode.Items.Count > 0)
				    ComboboxNode.SelectedItem = new KeyValuePair<string, string>(m_deviceToEdit.NodeID, m_deviceToEdit.NodeName);
				
                if (m_deviceToEdit.CompanyID.HasValue)
					ComboboxCompany.SelectedItem = new KeyValuePair<int, string>((int)m_deviceToEdit.CompanyID, m_deviceToEdit.CompanyName);
				else if (ComboboxCompany.Items.Count > 0)
					ComboboxCompany.SelectedIndex = 0;
				
                if (m_deviceToEdit.HistorianID.HasValue)
					ComboboxHistorian.SelectedItem = new KeyValuePair<int, string>((int)m_deviceToEdit.HistorianID, m_deviceToEdit.HistorianAcronym);
				else if (ComboboxHistorian.Items.Count > 0)
					ComboboxHistorian.SelectedIndex = 0;
				
                if (m_deviceToEdit.InterconnectionID.HasValue)
					ComboboxInterconnection.SelectedItem = new KeyValuePair<int, string>((int)m_deviceToEdit.InterconnectionID, m_deviceToEdit.InterconnectionName);
				else if (ComboboxInterconnection.Items.Count >0 )
					ComboboxInterconnection.SelectedIndex = 0;
				
                if (m_deviceToEdit.ParentID.HasValue)
					ComboboxParent.SelectedItem = new KeyValuePair<int, string>((int)m_deviceToEdit.ParentID, m_deviceToEdit.ParentAcronym);
				else if (ComboboxParent.Items.Count > 0)
					ComboboxParent.SelectedIndex = 0;
				
                if (m_deviceToEdit.ProtocolID.HasValue)
					ComboboxProtocol.SelectedItem = new KeyValuePair<int, string>((int)m_deviceToEdit.ProtocolID, m_deviceToEdit.ProtocolName);
				else if (ComboboxProtocol.Items.Count > 0)
					ComboboxProtocol.SelectedIndex = 0;
				
                if (string.IsNullOrEmpty(m_deviceToEdit.TimeZone) && ComboboxTimeZone.Items.Count > 0)
					ComboboxTimeZone.SelectedIndex = 0;
				else
				{
					foreach (KeyValuePair<string, string> item in ComboboxTimeZone.Items)
					{
						if (item.Key == m_deviceToEdit.TimeZone)
						{
							ComboboxTimeZone.SelectedItem = item;
							break;
						}
					}
				}
				if (m_deviceToEdit.VendorDeviceID.HasValue)
					ComboboxVendorDevice.SelectedItem = new KeyValuePair<int, string>((int)m_deviceToEdit.VendorDeviceID, m_deviceToEdit.VendorDeviceName);
				else if (ComboboxVendorDevice.Items.Count > 0)
					ComboboxVendorDevice.SelectedIndex = 0;

				if (m_deviceToEdit.IsConcentrator)	//then display list of devices.
				{
					m_client.GetDeviceListByParentIDAsync(m_deviceToEdit.ID);
					StackPanelDeviceList.Visibility = Visibility.Visible;
					StackPanelPhasorsMeassurements.Visibility = Visibility.Collapsed;
					TextBlockTitle.Text = "Devices For Concentrator: " + m_deviceToEdit.Acronym;
				}
				else
				{
					StackPanelPhasorsMeassurements.Visibility = Visibility.Visible;
					StackPanelDeviceList.Visibility = Visibility.Collapsed;
				}
			}
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
					sm = new SystemMessages(new Message() { UserMessage = "Failed to Retrieve Device Information by ID", SystemMessage = e.Error.Message, UserMessageType = MessageType.Error },
						ButtonType.OkOnly);

				sm.Show();
			}
			if (m_activityWindow != null)
				m_activityWindow.Close();
		}
		
		void client_SaveDeviceCompleted(object sender, SaveDeviceCompletedEventArgs e)
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
					sm = new SystemMessages(new Message() { UserMessage = "Failed to Save Device Information", SystemMessage = e.Error.Message, UserMessageType = MessageType.Error },
						ButtonType.OkOnly);
			}
			sm.Show();

			NavigationService.Navigate(new Uri("/Pages/Devices/Browse.xaml", UriKind.Relative));
		}

		void client_GetTimeZonesCompleted(object sender, GetTimeZonesCompletedEventArgs e)
		{
			if (e.Error == null)
				ComboboxTimeZone.ItemsSource = e.Result;
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
					sm = new SystemMessages(new Message() { UserMessage = "Failed to Retrieve Time Zones", SystemMessage = e.Error.Message, UserMessageType = MessageType.Error },
						ButtonType.OkOnly);

				sm.Show();
			}
			if (ComboboxTimeZone.Items.Count > 0)
				ComboboxTimeZone.SelectedIndex = 0;

            if (m_deviceToEdit != null)
            {
                foreach (KeyValuePair<string, string> item in ComboboxTimeZone.Items)
                {
                    if (item.Key == m_deviceToEdit.TimeZone)
                    {
                        ComboboxTimeZone.SelectedItem = item;
                        break;
                    }
                }
            }
		}
		
		void client_GetProtocolsCompleted(object sender, GetProtocolsCompletedEventArgs e)
		{
			if (e.Error == null)
				ComboboxProtocol.ItemsSource = e.Result;
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
					sm = new SystemMessages(new Message() { UserMessage = "Failed to Retrieve Protocols", SystemMessage = e.Error.Message, UserMessageType = MessageType.Error },
						ButtonType.OkOnly);

				sm.Show();
			}
			if (ComboboxProtocol.Items.Count > 0)
				ComboboxProtocol.SelectedIndex = 0;

            if (m_deviceToEdit != null && m_deviceToEdit.ProtocolID.HasValue)
                ComboboxProtocol.SelectedItem = new KeyValuePair<int, string>((int)m_deviceToEdit.ProtocolID, m_deviceToEdit.ProtocolName);

		}
		
		void client_GetVendorDevicesCompleted(object sender, GetVendorDevicesCompletedEventArgs e)
		{
			if (e.Error == null)
				ComboboxVendorDevice.ItemsSource = e.Result;
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
					sm = new SystemMessages(new Message() { UserMessage = "Failed to Retrieve Vendor Devices", SystemMessage = e.Error.Message, UserMessageType = MessageType.Error },
						ButtonType.OkOnly);

				sm.Show();
			}
			if (ComboboxVendorDevice.Items.Count > 0)
				ComboboxVendorDevice.SelectedIndex = 0;

            if (m_deviceToEdit != null && m_deviceToEdit.VendorDeviceID.HasValue)
                ComboboxVendorDevice.SelectedItem = new KeyValuePair<int, string>((int)m_deviceToEdit.VendorDeviceID, m_deviceToEdit.VendorDeviceName);
		}
		
		void client_GetInterconnectionsCompleted(object sender, GetInterconnectionsCompletedEventArgs e)
		{
			if (e.Error == null)
				ComboboxInterconnection.ItemsSource = e.Result;
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
					sm = new SystemMessages(new Message() { UserMessage = "Failed to Retrieve Interconnections", SystemMessage = e.Error.Message, UserMessageType = MessageType.Error },
						ButtonType.OkOnly);

				sm.Show();
			}
			if (ComboboxInterconnection.Items.Count > 0)
				ComboboxInterconnection.SelectedIndex = 0;

            if (m_deviceToEdit != null && m_deviceToEdit.InterconnectionID.HasValue)
                ComboboxInterconnection.SelectedItem = new KeyValuePair<int, string>((int)m_deviceToEdit.InterconnectionID, m_deviceToEdit.InterconnectionName);
		}
		
		void client_GetHistoriansCompleted(object sender, GetHistoriansCompletedEventArgs e)
		{
			if (e.Error == null)
				ComboboxHistorian.ItemsSource = e.Result;
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
					sm = new SystemMessages(new Message() { UserMessage = "Failed to Retrieve Historians", SystemMessage = e.Error.Message, UserMessageType = MessageType.Error },
						ButtonType.OkOnly);

				sm.Show();
			}
			if (ComboboxHistorian.Items.Count > 0)
				ComboboxHistorian.SelectedIndex = 0;

            if (m_deviceToEdit != null && m_deviceToEdit.HistorianID.HasValue)
                ComboboxHistorian.SelectedItem = new KeyValuePair<int, string>((int)m_deviceToEdit.HistorianID, m_deviceToEdit.HistorianAcronym);
		}
		
		void client_GetNodesCompleted(object sender, GetNodesCompletedEventArgs e)
		{
			if (e.Error == null)
				ComboboxNode.ItemsSource = e.Result;
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
			if (ComboboxNode.Items.Count > 0)
				ComboboxNode.SelectedIndex = 0;

            if(m_deviceToEdit != null)
                ComboboxNode.SelectedItem = new KeyValuePair<string, string>(m_deviceToEdit.NodeID, m_deviceToEdit.NodeName);
		}
		
		void client_GetCompaniesCompleted(object sender, GetCompaniesCompletedEventArgs e)
		{
			if (e.Error == null)
				ComboboxCompany.ItemsSource = e.Result;
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
					sm = new SystemMessages(new Message() { UserMessage = "Failed to Retrieve Companies", SystemMessage = e.Error.Message, UserMessageType = MessageType.Error },
						ButtonType.OkOnly);

				sm.Show();
			}
			if (ComboboxCompany.Items.Count > 0)
				ComboboxCompany.SelectedIndex = 0;

            if(m_deviceToEdit != null && m_deviceToEdit.CompanyID.HasValue)
                ComboboxCompany.SelectedItem = new KeyValuePair<int, string>((int)m_deviceToEdit.CompanyID, m_deviceToEdit.CompanyName);
		}
		
		void client_GetDevicesCompleted(object sender, GetDevicesCompletedEventArgs e)
		{
			if (e.Error == null)
				ComboboxParent.ItemsSource = e.Result;
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
					sm = new SystemMessages(new Message() { UserMessage = "Failed to Retrieve Devices", SystemMessage = e.Error.Message, UserMessageType = MessageType.Error },
						ButtonType.OkOnly);

				sm.Show();
			}
			if (ComboboxParent.Items.Count > 0)
				ComboboxParent.SelectedIndex = 0;

            if (m_deviceToEdit != null && m_deviceToEdit.ParentID.HasValue)
                ComboboxParent.SelectedItem = new KeyValuePair<int, string>((int)m_deviceToEdit.ParentID, m_deviceToEdit.ParentAcronym);
		}
		
		#endregion

		#region [ Control Event Handlers ]

		void ButtonView_Click(object sender, RoutedEventArgs e)
		{
			if (((KeyValuePair<int, string>)ComboboxParent.SelectedItem).Key != 0)
				NavigationService.Navigate(new Uri("/Pages/Devices/AddNew.xaml?did=" + ((KeyValuePair<int, string>)ComboboxParent.SelectedItem).Key.ToString(), UriKind.Relative));
		}
		
		void ComboboxParent_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (((KeyValuePair<int, string>)ComboboxParent.SelectedItem).Key != 0)
				m_client.GetConcentratorDeviceAsync(((KeyValuePair<int, string>)ComboboxParent.SelectedItem).Key);			
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

        void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sb = new Storyboard();
            sb = Application.Current.Resources["ButtonPressAnimation"] as Storyboard;
            sb.Completed += new EventHandler(delegate(object obj, EventArgs es) { sb.Stop(); });
            Storyboard.SetTarget(sb, ButtonSaveTransform);
            sb.Begin();

            if (IsValid())
            {
                Device device = new Device();
                device.NodeID = ((KeyValuePair<string, string>)ComboboxNode.SelectedItem).Key;
                device.ParentID = ((KeyValuePair<int, string>)ComboboxParent.SelectedItem).Key == 0 ? (int?)null : ((KeyValuePair<int, string>)ComboboxParent.SelectedItem).Key;
                device.Acronym = TextBoxAcronym.Text.CleanText();
                device.Name = TextBoxName.Text.CleanText();
                device.IsConcentrator = (bool)CheckboxConcentrator.IsChecked;
                device.CompanyID = ((KeyValuePair<int, string>)ComboboxCompany.SelectedItem).Key == 0 ? (int?)null : ((KeyValuePair<int, string>)ComboboxCompany.SelectedItem).Key;
                device.HistorianID = ((KeyValuePair<int, string>)ComboboxHistorian.SelectedItem).Key == 0 ? (int?)null : ((KeyValuePair<int, string>)ComboboxHistorian.SelectedItem).Key;
                device.AccessID = TextBoxAccessID.Text.ToInteger();
                device.VendorDeviceID = ((KeyValuePair<int, string>)ComboboxVendorDevice.SelectedItem).Key == 0 ? (int?)null : ((KeyValuePair<int, string>)ComboboxVendorDevice.SelectedItem).Key;
                device.ProtocolID = ((KeyValuePair<int, string>)ComboboxProtocol.SelectedItem).Key == 0 ? (int?)null : ((KeyValuePair<int, string>)ComboboxProtocol.SelectedItem).Key;
                device.Longitude = TextBoxLongitude.Text.ToNullableDecimal(); //string.IsNullOrEmpty(TextBoxLongitude.Text) ? (decimal?)null : Convert.ToDecimal(TextBoxLongitude.Text);
                device.Latitude = TextBoxLatitude.Text.ToNullableDecimal(); //string.IsNullOrEmpty(TextBoxLatitude.Text) ? (decimal?)null : Convert.ToDecimal(TextBoxLatitude.Text);
                device.InterconnectionID = ((KeyValuePair<int, string>)ComboboxInterconnection.SelectedItem).Key == 0 ? (int?)null : ((KeyValuePair<int, string>)ComboboxInterconnection.SelectedItem).Key;
                device.ConnectionString = TextBoxConnectionString.Text.CleanText();
                device.TimeZone = ((KeyValuePair<string, string>)ComboboxTimeZone.SelectedItem).Key;
                device.FramesPerSecond = string.IsNullOrEmpty(TextBoxFramesPerSecond.Text.CleanText()) ? 30 : TextBoxFramesPerSecond.Text.ToInteger();
                device.TimeAdjustmentTicks = TextBoxTimeAdjustmentTicks.Text.ToLong();
                device.DataLossInterval = TextBoxDataLossInterval.Text.ToDouble() == 0 ? 5 : TextBoxDataLossInterval.Text.ToDouble();
                device.ContactList = TextBoxContactList.Text.CleanText();
                device.MeasuredLines = TextBoxMeasuredLines.Text.ToNullableInteger(); //string.IsNullOrEmpty(TextBoxMeasuredLines.Text) ? (int?)null : Convert.ToInt32(TextBoxMeasuredLines.Text);
                device.LoadOrder = TextBoxLoadOrder.Text.ToInteger();
                device.Enabled = (bool)CheckboxEnabled.IsChecked;
                device.AllowedParsingExceptions = TextBoxAllowedParsingExceptions.Text.ToInteger();
                device.ParsingExceptionWindow = TextBoxParsingExceptionWindow.Text.ToDouble();
                device.DelayedConnectionInterval = TextBoxDelayedConnectionInterval.Text.ToDouble();
                device.AllowUseOfCachedConfiguration = (bool)CheckboxAllowUseOfCachedConfiguration.IsChecked;
                device.AutoStartDataParsingSequence = (bool)CheckboxAutoStartDataParsingSequence.IsChecked;
                device.SkipDisableRealTimeData = (bool)CheckboxSkipDisableRealTimeData.IsChecked;
                device.MeasurementReportingInterval = TextBoxMeasurementReportingInterval.Text.ToInteger();

                if (m_inEditMode == false && m_deviceID == 0)
                    m_client.SaveDeviceAsync(device, true, 0, 0);
                else
                {
                    device.ID = m_deviceID;
                    m_client.SaveDeviceAsync(device, false, 0, 0);
                }
            }
        }
        
        bool IsValid()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(TextBoxAcronym.Text.CleanText()))
            {                
                isValid = false;
                SystemMessages sm = new SystemMessages(new Message() { UserMessage = "Invalid Acronym", SystemMessage = "Please provide valid Acronym for a device.", UserMessageType = MessageType.Error },
                        ButtonType.OkOnly);
                sm.Closed += new EventHandler(delegate(object sender, EventArgs e) 
                                                {                                                   
                                                    TextBoxAcronym.Focus();                      
                                                });
                sm.Show();
                return isValid;
            }

            if (!TextBoxAccessID.Text.IsInteger())
            {
                isValid = false;
                SystemMessages sm = new SystemMessages(new Message() { UserMessage = "Invalid Access ID", SystemMessage = "Please provide valid integer value for Access ID.", UserMessageType = MessageType.Error },
                        ButtonType.OkOnly);
                sm.Closed += new EventHandler(delegate(object sender, EventArgs e)
                                                {
                                                    TextBoxAccessID.Focus();
                                                });
                sm.Show();
                return isValid;
            }

            if (!TextBoxTimeAdjustmentTicks.Text.IsLong())
            {
                isValid = false;
                SystemMessages sm = new SystemMessages(new Message() { UserMessage = "Invalid Time Adjustment Ticks", SystemMessage = "Please provide valid integer value for Time Adjustment Ticks.", UserMessageType = MessageType.Error },
                    ButtonType.OkOnly);
                sm.Closed += new EventHandler(delegate(object sender, EventArgs e)
                                                {
                                                    TextBoxTimeAdjustmentTicks.Focus();
                                                });
                sm.Show();
                return isValid;
            }

            if (!TextBoxDataLossInterval.Text.IsDouble())
            {
                isValid = false;
                SystemMessages sm = new SystemMessages(new Message() { UserMessage = "Invalid Data Loss Interval", SystemMessage = "Please provide valid numeric value for Data Loss Interval.", UserMessageType = MessageType.Error },
                    ButtonType.OkOnly);
                sm.Closed += new EventHandler(delegate(object sender, EventArgs e)
                                                {
                                                    TextBoxDataLossInterval.Focus();
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

            if (!TextBoxAllowedParsingExceptions.Text.IsInteger())
            {
                isValid = false;
                SystemMessages sm = new SystemMessages(new Message() { UserMessage = "Invalid Allowed Parsing Exceptions", SystemMessage = "Please provide valid integer value for Allowed Parsing Exceptions.", UserMessageType = MessageType.Error },
                    ButtonType.OkOnly);
                sm.Closed += new EventHandler(delegate(object sender, EventArgs e)
                {
                    TextBoxAllowedParsingExceptions.Focus();
                });
                sm.Show();
                return isValid;
            }

            if (!TextBoxParsingExceptionWindow.Text.IsDouble())
            {
                isValid = false;
                SystemMessages sm = new SystemMessages(new Message() { UserMessage = "Invalid Parsing Exception Window", SystemMessage = "Please provide valid numeric value for Parsing Exception Window.", UserMessageType = MessageType.Error },
                    ButtonType.OkOnly);
                sm.Closed += new EventHandler(delegate(object sender, EventArgs e)
                {
                    TextBoxParsingExceptionWindow.Focus();
                });
                sm.Show();
                return isValid;
            }

            if (!TextBoxDelayedConnectionInterval.Text.IsDouble())
            {
                isValid = false;
                SystemMessages sm = new SystemMessages(new Message() { UserMessage = "Invalid Delayed Connection Interval", SystemMessage = "Please provide valid numeric value for Delayed Connection Interval.", UserMessageType = MessageType.Error },
                    ButtonType.OkOnly);
                sm.Closed += new EventHandler(delegate(object sender, EventArgs e)
                {
                    TextBoxDelayedConnectionInterval.Focus();
                });
                sm.Show();
                return isValid;
            }

            if (!TextBoxMeasurementReportingInterval.Text.IsInteger())
            {
                isValid = false;
                SystemMessages sm = new SystemMessages(new Message() { UserMessage = "Invalid Measurement Reporting Interval", SystemMessage = "Please provide valid integer value for Measurement Reporting Interval.", UserMessageType = MessageType.Error },
                    ButtonType.OkOnly);
                sm.Closed += new EventHandler(delegate(object sender, EventArgs e)
                {
                    TextBoxMeasurementReportingInterval.Focus();
                });
                sm.Show();
                return isValid;
            }

            return isValid;
        }

        void HyperlinkButton_Click(object sender, RoutedEventArgs e)
		{
			string deviceId = ((HyperlinkButton)sender).Tag.ToString();
			NavigationService.Navigate(new Uri("/Pages/Devices/AddNew.xaml?did=" + deviceId, UriKind.Relative));
		}

		void HyperlinkButtonPhasors_Click(object sender, RoutedEventArgs e)
		{
			int deviceId = Convert.ToInt32(((HyperlinkButton)sender).Tag.ToString());
			string acronym = ToolTipService.GetToolTip((HyperlinkButton)sender).ToString();
			Phasors phasors = new Phasors(deviceId, acronym);
			phasors.Show();
		}

		void HyperlinkButtonMeasurements_Click(object sender, RoutedEventArgs e)
		{
			string deviceId = ((HyperlinkButton)sender).Tag.ToString();
			NavigationService.Navigate(new Uri("/Pages/Manage/Measurements.xaml?did=" + deviceId, UriKind.Relative));
		}

		void ButtonBuildConnectionString_Click(object sender, RoutedEventArgs e)
		{
			ConnectionStringBuilder csb = new ConnectionStringBuilder(ConnectionStringBuilder.ConnectionType.DeviceConnection);
			if (!string.IsNullOrEmpty(TextBoxConnectionString.Text))
				csb.ConnectionString = TextBoxConnectionString.Text;
			csb.Closed += new EventHandler(delegate(object popupWindow, EventArgs eargs)
			{
				if ((bool)csb.DialogResult)
					TextBoxConnectionString.Text = csb.ConnectionString;
			});
			csb.Show();
		}

		#endregion

		#region [ Page Event Handlers ]

		void AddNew_Loaded(object sender, RoutedEventArgs e)
		{
            ClearForm();
			if (this.NavigationContext.QueryString.ContainsKey("did"))
			{
				m_activityWindow = new ActivityWindow("Loading Data... Please Wait...");
				m_activityWindow.Show();
				m_deviceID = Convert.ToInt32(this.NavigationContext.QueryString["did"]);
				m_inEditMode = true;				
				m_client.GetDeviceByDeviceIDAsync(m_deviceID);
			}            
		}

		// Executes when the user navigates to this page.
		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			StackPanelDeviceList.Visibility = Visibility.Collapsed;
			StackPanelPhasorsMeassurements.Visibility = Visibility.Collapsed;
			m_client.GetDevicesAsync(DeviceType.Concentrator, ((App)Application.Current).NodeValue, true);
			m_client.GetCompaniesAsync(true);
			m_client.GetNodesAsync(true, false);
			m_client.GetHistoriansAsync(true, true);
			m_client.GetInterconnectionsAsync(true);
			m_client.GetVendorDevicesAsync(true);
			m_client.GetProtocolsAsync(true);
			m_client.GetTimeZonesAsync(true);            
		}

		#endregion

		#region [ Methods ]

		void ClearForm()
		{
            GridDeviceDetail.DataContext = new Device() { Longitude = -98.6m, Latitude = 37.5m, FramesPerSecond = 30, DataLossInterval = 5, AllowedParsingExceptions = 10, ParsingExceptionWindow = 5,
                                                          DelayedConnectionInterval = 5,
                                                          AllowUseOfCachedConfiguration = true,
                                                          AutoStartDataParsingSequence = true,
                                                          MeasurementReportingInterval = 100000,
                                                          MeasuredLines = 1            
                                                        };

            if (ComboboxCompany.Items.Count > 0)
			    ComboboxCompany.SelectedIndex = 0;

            if (ComboboxHistorian.Items.Count > 0)
			    ComboboxHistorian.SelectedIndex = 0;
			
            if (ComboboxInterconnection.Items.Count > 0)
                ComboboxInterconnection.SelectedIndex = 0;

            if (ComboboxNode.Items.Count > 0)
			    ComboboxNode.SelectedIndex = 0;

            if (ComboboxParent.Items.Count > 0)
			    ComboboxParent.SelectedIndex = 0;

            if (ComboboxProtocol.Items.Count > 0)
			    ComboboxProtocol.SelectedIndex = 0;

            if (ComboboxTimeZone.Items.Count > 0)
			    ComboboxTimeZone.SelectedIndex = 0;

            if (ComboboxVendorDevice.Items.Count > 0)
			    ComboboxVendorDevice.SelectedIndex = 0;

			m_inEditMode = false;
			m_deviceID = 0;
		}

		#endregion
				
	}
}
