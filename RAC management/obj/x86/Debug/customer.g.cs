﻿#pragma checksum "D:\big projects\semester 3\RAC management\RAC management\customer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CD8555CB30597B773E024E50B94A9A790066079A189A53D4492AE4583707FEF1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RAC_management
{
    partial class customer : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Control_IsEnabled(global::Windows.UI.Xaml.Controls.Control obj, global::System.Boolean value)
            {
                obj.IsEnabled = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class customer_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            Icustomer_Bindings
        {
            private global::RAC_management.customer dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Button obj2;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2IsEnabledDisabled = false;

            private customer_obj1_BindingsTracking bindingsTracking;

            public customer_obj1_Bindings()
            {
                this.bindingsTracking = new customer_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 17 && columnNumber == 17)
                {
                    isobj2IsEnabledDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // customer.xaml line 15
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // Icustomer_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::RAC_management.customer)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::RAC_management.customer obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Frame(obj.Frame, phase);
                    }
                }
            }
            private void Update_Frame(global::Windows.UI.Xaml.Controls.Frame obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_Frame(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Frame_CanGoBack(obj.CanGoBack, phase);
                    }
                }
            }
            private void Update_Frame_CanGoBack(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // customer.xaml line 15
                    if (!isobj2IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj2, obj);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class customer_obj1_BindingsTracking
            {
                private global::System.WeakReference<customer_obj1_Bindings> weakRefToBindingObj; 

                public customer_obj1_BindingsTracking(customer_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<customer_obj1_Bindings>(obj);
                }

                public customer_obj1_Bindings TryGetBindingObject()
                {
                    customer_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                    UpdateChildListeners_Frame(null);
                }

                public void DependencyPropertyChanged_Frame(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    customer_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::RAC_management.customer obj = sender as global::RAC_management.customer;
                        if (obj != null)
                        {
                            bindings.Update_Frame(obj.Frame, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_Frame = 0;
                public void UpdateChildListeners_(global::RAC_management.customer obj)
                {
                    customer_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Page.FrameProperty, tokenDPC_Frame);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_Frame = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Page.FrameProperty, DependencyPropertyChanged_Frame);
                        }
                    }
                }
                public void DependencyPropertyChanged_Frame_CanGoBack(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    customer_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Windows.UI.Xaml.Controls.Frame obj = sender as global::Windows.UI.Xaml.Controls.Frame;
                        if (obj != null)
                        {
                            bindings.Update_Frame_CanGoBack(obj.CanGoBack, DATA_CHANGED);
                        }
                    }
                }
                private global::Windows.UI.Xaml.Controls.Frame cache_Frame = null;
                private long tokenDPC_Frame_CanGoBack = 0;
                public void UpdateChildListeners_Frame(global::Windows.UI.Xaml.Controls.Frame obj)
                {
                    if (obj != cache_Frame)
                    {
                        if (cache_Frame != null)
                        {
                            cache_Frame.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Frame.CanGoBackProperty, tokenDPC_Frame_CanGoBack);
                            cache_Frame = null;
                        }
                        if (obj != null)
                        {
                            cache_Frame = obj;
                            tokenDPC_Frame_CanGoBack = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Frame.CanGoBackProperty, DependencyPropertyChanged_Frame_CanGoBack);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // customer.xaml line 15
                {
                    this.BackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackButton).Click += this.BackButton_Click;
                }
                break;
            case 3: // customer.xaml line 41
                {
                    this.CName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // customer.xaml line 43
                {
                    this.contact = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // customer.xaml line 45
                {
                    this.cnic = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // customer.xaml line 46
                {
                    this.sbmit_btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.sbmit_btn).Click += this.sbmit_btn_Click;
                }
                break;
            case 7: // customer.xaml line 47
                {
                    this.customerSubmitSuccess = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // customer.xaml line 25
                {
                    global::Windows.UI.Xaml.Controls.ComboBox element8 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)element8).SelectionChanged += this.ColorComboBox_SelectionChanged;
                }
                break;
            case 9: // customer.xaml line 31
                {
                    this.driver = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 10: // customer.xaml line 33
                {
                    this.days = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11: // customer.xaml line 34
                {
                    this.startDate = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 12: // customer.xaml line 35
                {
                    this.endDate = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 13: // customer.xaml line 36
                {
                    this.calculatePrice_btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.calculatePrice_btn).Click += this.calculatePrice_btn_Click;
                }
                break;
            case 14: // customer.xaml line 37
                {
                    this.calculatedPrice = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // customer.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    customer_obj1_Bindings bindings = new customer_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

