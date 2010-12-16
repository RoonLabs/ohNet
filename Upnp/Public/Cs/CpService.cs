using System;
using System.Runtime.InteropServices;
using System.Text;
using Zapp.Core;
using System.Collections.Generic;

namespace Zapp.ControlPoint
{
    /// <summary>
    /// (Action) Argument.  Only intended for use by auto-generated proxies.
    /// </summary>
    /// <remarks>One Argument will be created per [in/out]put Parameter for the Action.
    /// Input parameters should construct arguments using the (Parameter, Val) constructor.
    /// Output parameters should construct arguments using only the parameter and should
    /// read the value when the invocation completes.</remarks>
    public class Argument
    {
        protected IntPtr iHandle;

        internal IntPtr Handle()
        {
            return iHandle;
        }
        
        protected Argument()
        {
        }
    }

    /// <summary>
    /// Integer type argument.  Only intended for use by auto-generated proxies.
    /// </summary>
    public class ArgumentInt : Argument
    {
        [DllImport("ZappUpnp")]
        static extern IntPtr ActionArgumentCreateIntInput(IntPtr aParameter, int aValue);
        [DllImport("ZappUpnp")]
        static extern IntPtr ActionArgumentCreateIntOutput(IntPtr aParameter);
        [DllImport("ZappUpnp")]
        static extern int ActionArgumentValueInt(IntPtr aHandle);

        /// <summary>
        /// Constructor for integer input argument for an action
        /// </summary>
        /// <remarks>Intended to be write only (its value is written on construction and not be later read)</remarks>
        /// <param name="aParameter">Defines the name plus any bounds to the value for the argument.
        /// Must have been previously added to the action using Action.AddInputParameter</param>
        /// <param name="aValue">Value for the argument</param>
        public ArgumentInt(ParameterInt aParameter, int aValue)
        {
            iHandle = ActionArgumentCreateIntInput(aParameter.Handle(), aValue);
        }

        /// <summary>
        /// Constructor for integer output argument for an action
        /// </summary>
        /// <remarks>Intended to be created without any value.  The value is later set after
        /// CpService.InvokeAction is called but before the invocation's callback is run)</remarks>
        /// <param name="aParameter">Defines the name plus any bounds to the value for the argument.
        /// Must have been previously added to the action using Action.AddOutputParameter</param>
        public ArgumentInt(ParameterInt aParameter)
        {
            iHandle = ActionArgumentCreateIntOutput(aParameter.Handle());
        }

        /// <summary>
        /// Read the value of an integer argument.
        /// </summary>
        /// <remarks>Only intended for use with output arguments inside the invocation completed callback.</remarks>
        /// <returns>Current value of the argument</returns>
        int Value()
        {
            return ActionArgumentValueInt(iHandle);
        }
    }

    /// <summary>
    /// Unsigned integer type argument.  Only intended for use by auto-generated proxies.
    /// </summary>
    public class ArgumentUint : Argument
    {
        [DllImport("ZappUpnp")]
        static extern IntPtr ActionArgumentCreateUintInput(IntPtr aParameter, uint aValue);
        [DllImport("ZappUpnp")]
        static extern IntPtr ActionArgumentCreateUintOutput(IntPtr aParameter);
        [DllImport("ZappUpnp")]
        static extern uint ActionArgumentValueUint(IntPtr aHandle);

        /// <summary>
        /// Constructor for unsigned integer input argument for an action
        /// </summary>
        /// <remarks>Intended to be write only (its value is written on construction and not be later read)</remarks>
        /// <param name="aParameter">Defines the name plus any bounds to the value for the argument.
        /// Must have been previously added to the action using Action.AddInputParameter</param>
        /// <param name="aValue">Value for the argument</param>
        public ArgumentUint(ParameterUint aParameter, uint aValue)
        {
            iHandle = ActionArgumentCreateUintInput(aParameter.Handle(), aValue);
        }

        /// <summary>
        /// Constructor for unsigned integer output argument for an action
        /// </summary>
        /// <remarks>Intended to be created without any value.  The value is later set after
        /// CpService.InvokeAction is called but before the invocation's callback is run)</remarks>
        /// <param name="aParameter">Defines the name plus any bounds to the value for the argument.
        /// Must have been previously added to the action using Action.AddOutputParameter</param>
        public ArgumentUint(ParameterUint aParameter)
        {
            iHandle = ActionArgumentCreateUintOutput(aParameter.Handle());
        }

        /// <summary>
        /// Read the value of an unsigned integer argument.
        /// </summary>
        /// <remarks>Only intended for use with output arguments inside the invocation completed callback.</remarks>
        /// <returns>Current value of the argument</returns>
        uint Value()
        {
            return ActionArgumentValueUint(iHandle);
        }
    }

    /// <summary>
    /// Boolean type argument.  Only intended for use by auto-generated proxies.
    /// </summary>
    public class ArgumentBool : Argument
    {
        [DllImport("ZappUpnp")]
        static extern IntPtr ActionArgumentCreateBoolInput(IntPtr aParameter, uint aValue);
        [DllImport("ZappUpnp")]
        static extern IntPtr ActionArgumentCreateBoolOutput(IntPtr aParameter);
        [DllImport("ZappUpnp")]
        static extern uint ActionArgumentValueBool(IntPtr aHandle);

        /// <summary>
        /// Constructor for boolean input argument for an action
        /// </summary>
        /// <remarks>Intended to be write only (its value is written on construction and not be later read)</remarks>
        /// <param name="aParameter">Defines the name for the argument.
        /// Must have been previously added to the action using Action.AddInputParameter</param>
        /// <param name="aValue">Value for the argument</param>
        public ArgumentBool(ParameterBool aParameter, bool aValue)
        {
            iHandle = ActionArgumentCreateBoolInput(aParameter.Handle(), (aValue? 1u : 0u));
        }

        /// <summary>
        /// Constructor for boolean output argument for an action
        /// </summary>
        /// <remarks>Intended to be created without any value.  The value is later set after
        /// CpService.InvokeAction is called but before the invocation's callback is run)</remarks>
        /// <param name="aParameter">Defines the name for the argument.
        /// Must have been previously added to the action using Action.AddOutputParameter</param>
        public ArgumentBool(ParameterBool aParameter)
        {
            iHandle = ActionArgumentCreateBoolOutput(aParameter.Handle());
        }

        /// <summary>
        /// Read the value of a boolean argument.
        /// </summary>
        /// <remarks>Only intended for use with output arguments inside the invocation completed callback.</remarks>
        /// <returns>Current value of the argument</returns>
        bool Value()
        {
            uint val = ActionArgumentValueBool(iHandle);
            return (val != 0);
        }
    }

    /// <summary>
    /// String type argument.  Only intended for use by auto-generated proxies.
    /// </summary>
    public class ArgumentString : Argument
    {
        [DllImport("ZappUpnp")]
        static extern unsafe IntPtr ActionArgumentCreateStringInput(IntPtr aParameter, char* aValue);
        [DllImport("ZappUpnp")]
        static extern IntPtr ActionArgumentCreateStringOutput(IntPtr aParameter);
        [DllImport("ZappUpnp")]
        static extern unsafe char* ActionArgumentValueString(IntPtr aHandle);
        [DllImport("ZappUpnp")]
        static extern unsafe void ZappFree(IntPtr aPtr);

        /// <summary>
        /// Constructor for string input argument for an action
        /// </summary>
        /// <remarks>Intended to be write only (its value is written on construction and not be later read)</remarks>
        /// <param name="aParameter">Defines the name plus any bounds to the value for the argument.
        /// Must have been previously added to the action using Action.AddInputParameter</param>
        /// <param name="aValue">Value for the argument</param>
        public unsafe ArgumentString(ParameterString aParameter, String aValue)
        {
            char* value = (char*)Marshal.StringToHGlobalAnsi(aValue);
            iHandle = ActionArgumentCreateStringInput(aParameter.Handle(), value);
            Marshal.FreeHGlobal((IntPtr)value);
        }

        /// <summary>
        /// Constructor for string output argument for an action
        /// </summary>
        /// <remarks>Intended to be created without any value.  The value is later set after
        /// CpService.InvokeAction is called but before the invocation's callback is run)</remarks>
        /// <param name="aParameter">Defines the name plus any bounds to the value for the argument.
        /// Must have been previously added to the action using Action.AddOutputParameter</param>
        public ArgumentString(ParameterString aParameter)
        {
            iHandle = ActionArgumentCreateStringOutput(aParameter.Handle());
        }

        /// <summary>
        /// Read the value of a binary argument.
        /// </summary>
        /// <remarks>Only intended for use with output arguments inside the invocation completed callback.
        /// Can only be called once as the first call extracts the string data from the underlying native object</remarks>
        /// <returns>Current value of the argument</returns>
        unsafe String Value()
        {
            char* cStr = ActionArgumentValueString(iHandle);
            String ret = Marshal.PtrToStringAnsi((IntPtr)cStr);
            ZappFree((IntPtr)cStr);
            return ret;
        }
    }

    /// <summary>
    /// Binary type argument.  Only intended for use by auto-generated proxies.
    /// </summary>
    public class ArgumentBinary : Argument
    {
        [DllImport("ZappUpnp")]
        static extern unsafe IntPtr ActionArgumentCreateBinaryInput(IntPtr aParameter, char* aData, int aLength);
        [DllImport("ZappUpnp")]
        static extern IntPtr ActionArgumentCreateBinaryOutput(IntPtr aParameter);
        [DllImport("ZappUpnp")]
        static extern unsafe void ActionArgumentGetValueBinary(IntPtr aHandle, char** aData, uint* aLen);
        [DllImport("ZappUpnp")]
        static extern unsafe void ZappFree(IntPtr aPtr);

        /// <summary>
        /// Constructor for binary input argument for an action
        /// </summary>
        /// <remarks>Intended to be write only (its value is written on construction and not be later read)</remarks>
        /// <param name="aParameter">Defines the name for the argument.
        /// Must have been previously added to the action using Action.AddInputParameter</param>
        /// <param name="aValue">Value for the argument</param>
        public unsafe ArgumentBinary(ParameterBinary aParameter, String aData)
        {
            char* data = (char*)Marshal.StringToHGlobalAnsi(aData);
            iHandle = ActionArgumentCreateBinaryInput(aParameter.Handle(), data, aData.Length);
            Marshal.FreeHGlobal((IntPtr)data);
        }

        /// <summary>
        /// Constructor for binary output argument for an action
        /// </summary>
        /// <remarks>Intended to be created without any value.  The value is later set after
        /// CpService.InvokeAction is called but before the invocation's callback is run)</remarks>
        /// <param name="aParameter">Defines the name plus any bounds to the value for the argument.
        /// Must have been previously added to the action using Action.AddOutputParameter</param>
        public ArgumentBinary(ParameterBinary aParameter)
        {
            iHandle = ActionArgumentCreateBinaryOutput(aParameter.Handle());
        }

        /// <summary>
        /// Read the value of a binary argument.
        /// </summary>
        /// <remarks>Only intended for use with output arguments inside the invocation completed callback.
        /// Can only be called once as the first call extracts the string data from the underlying native object</remarks>
        /// <returns>Current value of the argument</returns>
        unsafe String Value()
        {
            char* data;
            uint len;
            ActionArgumentGetValueBinary(iHandle, &data, &len);
            String ret = Marshal.PtrToStringAnsi((IntPtr)data, (int)len);
            ZappFree((IntPtr)data);
            return ret;
        }
    }

    /// <summary>
    /// Utility class used to execute a single action.  Only intended for use by auto-generated proxies.
    /// </summary>
    public class Invocation
    {
        [DllImport("ZappUpnp")]
        static extern IntPtr CpServiceInvocation(IntPtr aService, IntPtr aAction, CpProxy.CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("ZappUpnp")]
        static extern void CpInvocationAddInput(IntPtr aInvocation, IntPtr aArgument);
        [DllImport("ZappUpnp")]
        static extern void CpInvocationAddOutput(IntPtr aInvocation, IntPtr aArgument);
        [DllImport("ZappUpnp")]
        static extern uint CpInvocationError(IntPtr aInvocation);
        [DllImport("ZappUpnp")]
        static extern unsafe void ZappFree(IntPtr aPtr);
        [DllImport("ZappUpnp")]
        static extern unsafe int CpInvocationOutputInt(IntPtr aInvocation, uint aIndex);
        [DllImport("ZappUpnp")]
        static extern unsafe uint CpInvocationOutputUint(IntPtr aInvocation, uint aIndex);
        [DllImport("ZappUpnp")]
        static extern unsafe uint CpInvocationOutputBool(IntPtr aInvocation, uint aIndex);
        [DllImport("ZappUpnp")]
        static extern unsafe char* CpInvocationOutputString(IntPtr aInvocation, uint aIndex);
        [DllImport("ZappUpnp")]
        static extern unsafe void CpInvocationGetOutputBinary(IntPtr aInvocation, uint aIndex, char** aData, uint* aLen);

        private CpProxy.CallbackAsyncComplete iAsyncComplete;
        private CpProxy.CallbackActionComplete iCallbackAsyncComplete;
        private IntPtr iHandle;
        private CpService iService;
        private List<Argument> iInputArgs;
        private List<Argument> iOutputArgs;

        /// <summary>
        /// Constructor.  Not intended for external use (use CpService.Invocation instead)
        /// </summary>
        /// <param name="aService">Service the action is being invoked on</param>
        /// <param name="aAction">Handle to the action being invoked</param>
        /// <param name="aCallback">Callback to run when the action completes</param>
        internal Invocation(CpService aService, IntPtr aAction, CpProxy.CallbackAsyncComplete aCallback)
        {
            iService = aService;
            iInputArgs = new List<Argument>();
            iOutputArgs = new List<Argument>();
            GCHandle gch = GCHandle.Alloc(this); /* no need to store gch as a member as AsyncComplete is guaranteed
                                                    to be called, even in error cases */
            iAsyncComplete = aCallback;
            iCallbackAsyncComplete = new CpProxy.CallbackActionComplete(AsyncComplete);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            iHandle = CpServiceInvocation(aService.Handle(), aAction, iCallbackAsyncComplete, ptr);
        }

        /// <summary>
        /// Add an input argument to an invocation
        /// </summary>
        /// <param name="aArgument">Input argument being added.  Ownership passes to the invocation</param>
        public void AddInput(Argument aArgument)
        {
            iInputArgs.Add(aArgument);
            CpInvocationAddInput(iHandle, aArgument.Handle());
        }

        /// <summary>
        /// Add an output argument to an invocation
        /// </summary>
        /// <param name="aArgument">Output argument being added.  Ownership passes to the invocation</param>
        public void AddOutput(Argument aArgument)
        {
            iOutputArgs.Add(aArgument);
            CpInvocationAddOutput(iHandle, aArgument.Handle());
        }

        /// <summary>
        /// Check whether the invocation failed
        /// </summary>
        /// <remarks>Only intended for use in the invocation complete callback</remarks>
        /// <returns>true if the invocation failed; false if it succeeded</returns>
        public bool Error()
        {
            uint err = CpInvocationError(iHandle);
            return (err != 0);
        }

        /// <summary>
        /// Utility to retrieve the value of an integer type output argument
        /// </summary>
        /// <param name="aHandle">Invocation handle</param>
        /// <param name="aIndex">Zero-based index into array of output arguments.
        /// Must refer to an ArgumentInt.</param>
        /// <returns>Value of the integer output argument</returns>
        public static unsafe int OutputInt(IntPtr aHandle, uint aIndex)
        {
            return CpInvocationOutputInt(aHandle, aIndex);
        }

        /// <summary>
        /// Utility to retrieve the value of an unsigned integer type output argument
        /// </summary>
        /// <param name="aHandle">Invocation handle</param>
        /// <param name="aIndex">Zero-based index into array of output arguments.
        /// Must refer to an ArgumentUint.</param>
        /// <returns>Value of the unsigned integer output argument</returns>
        public static unsafe uint OutputUint(IntPtr aHandle, uint aIndex)
        {
            return CpInvocationOutputUint(aHandle, aIndex);
        }

        /// <summary>
        /// Utility to retrieve the value of a boolean type output argument
        /// </summary>
        /// <param name="aHandle">Invocation handle</param>
        /// <param name="aIndex">Zero-based index into array of output arguments.
        /// Must refer to an ArgumentBool.</param>
        /// <returns>Value of the boolean output argument</returns>
        public static unsafe bool OutputBool(IntPtr aHandle, uint aIndex)
        {
            uint val = CpInvocationOutputBool(aHandle, aIndex);
            return (val != 0);
        }

        /// <summary>
        /// Utility to retrieve the value of a string type output argument
        /// </summary>
        /// <remarks>Must only be called once per output argument.  (The first call extracts
        /// the string data from the underlying native object so later calls would return an
        /// empty string.)</remarks>
        /// <param name="aHandle">Invocation handle</param>
        /// <param name="aIndex">Zero-based index into array of output arguments.
        /// Must refer to an ArgumentString.</param>
        /// <returns>Value of the string output argument</returns>
        public static unsafe String OutputString(IntPtr aHandle, uint aIndex)
        {
            char* cStr = CpInvocationOutputString(aHandle, aIndex);
            if (cStr == null)
            {
                return null;
            }
            String str = Marshal.PtrToStringAnsi((IntPtr)cStr);
            ZappFree((IntPtr)cStr);
            return str;
        }

        /// <summary>
        /// Utility to retrieve the value of a binary type output argument
        /// </summary>
        /// <remarks>Must only be called once per output argument.  (The first call extracts
        /// the binary data from the underlying native object so later calls would return an
        /// empty string.)</remarks>
        /// <param name="aHandle">Invocation handle</param>
        /// <param name="aIndex">Zero-based index into array of output arguments.
        /// Must refer to an ArgumentString.</param>
        /// <returns>Value of the string output argument</returns>
        public static unsafe String OutputBinary(IntPtr aHandle, uint aIndex)
        {
            char* data;
            uint len;
            CpInvocationGetOutputBinary(aHandle, aIndex, &data, &len);
            if (data == null)
            {
                return null;
            }
            String bin = Marshal.PtrToStringAnsi((IntPtr)data, (int)len);
            ZappFree((IntPtr)data);
            return bin;
        }

        internal IntPtr Handle()
        {
            return iHandle;
        }

        private void AsyncComplete(IntPtr aPtr, IntPtr aAsyncHandle)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            Invocation self = (Invocation)gch.Target;
            try
            {
                self.iAsyncComplete(aAsyncHandle);
            }
            catch (ProxyError)
            {
            }
            gch.Free();
            self.iService.InvocationComplete(this);
        }
    }

    /// <summary>
    /// Used by CpProxy to represent a service offered by a remote device.  Only intended for use by auto-generated proxies.
    /// </summary>
    public class CpService
    {
        [DllImport("ZappUpnp")]
        static extern unsafe IntPtr CpServiceCreate(char* aDomain, char* aName, uint aVersion, IntPtr aDevice);
        [DllImport("ZappUpnp")]
        static extern void CpServiceDestroy(IntPtr aService);
        [DllImport("ZappUpnp")]
        static extern void CpServiceInvokeAction(IntPtr aService, IntPtr aInvocation);

        private IntPtr iHandle;
        private List<Invocation> iActiveInvocations;
        
        /// <summary>
        /// Constructor.  Only intended for use by CpProxy.
        /// </summary>
        /// <param name="aHandle"></param>
        internal CpService(IntPtr aHandle)
        {
            iHandle = aHandle;
            iActiveInvocations = new List<Invocation>();
        }

        /// <summary>
        /// Request an invocation object prior to setting input/output arguments
        /// </summary>
        /// <param name="aAction">Action which will be invoked</param>
        /// <param name="aCallback">Delegate to run when the action completes</param>
        /// <returns>Invocation object, ready to receive input and output arguments</returns>
        public Invocation Invocation(Zapp.Core.Action aAction, CpProxy.CallbackAsyncComplete aCallback)
        {
            Invocation invocation = new Invocation(this, aAction.Handle(), aCallback);
            lock (this)
            {
                iActiveInvocations.Add(invocation);
            }
            return invocation;
        }

        /// <summary>
        /// Invoke an action
        /// </summary>
        /// <param name="aInvocation">Invocation object, with all input and output arguments added</param>
        public void InvokeAction(Invocation aInvocation)
        {
            CpServiceInvokeAction(iHandle, aInvocation.Handle());
        }

        internal void InvocationComplete(Invocation aInvocation)
        {
            IntPtr handle = aInvocation.Handle();
            lock (this)
            {
                for (int i=0; i<iActiveInvocations.Count; i++)
                {
                    if (iActiveInvocations[i].Handle() == handle)
                    {
                        iActiveInvocations.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        internal IntPtr Handle()
        {
            return iHandle;
        }
    }
}
