﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.3.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("localhost"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property host() As String
            Get
                Return CType(Me("host"),String)
            End Get
            Set
                Me("host") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("root"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property username() As String
            Get
                Return CType(Me("username"),String)
            End Get
            Set
                Me("username") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("4sirah@123"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property password() As String
            Get
                Return CType(Me("password"),String)
            End Get
            Set
                Me("password") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("stock"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property database() As String
            Get
                Return CType(Me("database"),String)
            End Get
            Set
                Me("database") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("SmartShark Softwares"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property company_name() As String
            Get
                Return CType(Me("company_name"),String)
            End Get
            Set
                Me("company_name") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("SmartShark Products"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property company_trade_mark() As String
            Get
                Return CType(Me("company_trade_mark"),String)
            End Get
            Set
                Me("company_trade_mark") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("complex"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property layout() As String
            Get
                Return CType(Me("layout"),String)
            End Get
            Set
                Me("layout") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("siranjofuw@gmail.com"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property company_email_primary() As String
            Get
                Return CType(Me("company_email_primary"),String)
            End Get
            Set
                Me("company_email_primary") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("jerrysirah8@gmailcom"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property company_email_secondary() As String
            Get
                Return CType(Me("company_email_secondary"),String)
            End Get
            Set
                Me("company_email_secondary") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0790983123"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property company_phone_primary() As String
            Get
                Return CType(Me("company_phone_primary"),String)
            End Get
            Set
                Me("company_phone_primary") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0740500470"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property company_phone_secondary() As String
            Get
                Return CType(Me("company_phone_secondary"),String)
            End Get
            Set
                Me("company_phone_secondary") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Kiminini"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property company_street_name() As String
            Get
                Return CType(Me("company_street_name"),String)
            End Get
            Set
                Me("company_street_name") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("23"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property company_house_number() As String
            Get
                Return CType(Me("company_house_number"),String)
            End Get
            Set
                Me("company_house_number") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("232"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property company_postal_code() As String
            Get
                Return CType(Me("company_postal_code"),String)
            End Get
            Set
                Me("company_postal_code") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Kitale"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property company_region() As String
            Get
                Return CType(Me("company_region"),String)
            End Get
            Set
                Me("company_region") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Kenya"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property company_state() As String
            Get
                Return CType(Me("company_state"),String)
            End Get
            Set
                Me("company_state") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("SmartShark Softwares is an IT related Company based in Kenya that deals with Web "& _ 
            "Design and Development."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Was founded in 2017 by Dr. Eng. Wachiye Jeremiah Siranj"& _ 
            "ofu"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property company_description() As String
            Get
                Return CType(Me("company_description"),String)
            End Get
            Set
                Me("company_description") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.SMS.My.MySettings
            Get
                Return Global.SMS.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace