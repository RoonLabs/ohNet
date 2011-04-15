using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Zapp.Core;
using Zapp.ControlPoint;

namespace Zapp.ControlPoint.Proxies
{
    public interface ICpProxyLinnCoUkInfo1 : ICpProxy, IDisposable
    {
        void SyncCounters(out uint aTrackCount, out uint aDetailsCount, out uint aMetatextCount);
        void BeginCounters(CpProxy.CallbackAsyncComplete aCallback);
        void EndCounters(IntPtr aAsyncHandle, out uint aTrackCount, out uint aDetailsCount, out uint aMetatextCount);
        void SyncTrack(out String aUri, out String aMetadata);
        void BeginTrack(CpProxy.CallbackAsyncComplete aCallback);
        void EndTrack(IntPtr aAsyncHandle, out String aUri, out String aMetadata);
        void SyncDetails(out uint aDuration, out uint aBitRate, out uint aBitDepth, out uint aSampleRate, out bool aLossless, out String aCodecName);
        void BeginDetails(CpProxy.CallbackAsyncComplete aCallback);
        void EndDetails(IntPtr aAsyncHandle, out uint aDuration, out uint aBitRate, out uint aBitDepth, out uint aSampleRate, out bool aLossless, out String aCodecName);
        void SyncMetatext(out String aMetatext);
        void BeginMetatext(CpProxy.CallbackAsyncComplete aCallback);
        void EndMetatext(IntPtr aAsyncHandle, out String aMetatext);
        void SetPropertyTrackCountChanged(System.Action aTrackCountChanged);
        uint PropertyTrackCount();
        void SetPropertyDetailsCountChanged(System.Action aDetailsCountChanged);
        uint PropertyDetailsCount();
        void SetPropertyMetatextCountChanged(System.Action aMetatextCountChanged);
        uint PropertyMetatextCount();
        void SetPropertyUriChanged(System.Action aUriChanged);
        String PropertyUri();
        void SetPropertyMetadataChanged(System.Action aMetadataChanged);
        String PropertyMetadata();
        void SetPropertyDurationChanged(System.Action aDurationChanged);
        uint PropertyDuration();
        void SetPropertyBitRateChanged(System.Action aBitRateChanged);
        uint PropertyBitRate();
        void SetPropertyBitDepthChanged(System.Action aBitDepthChanged);
        uint PropertyBitDepth();
        void SetPropertySampleRateChanged(System.Action aSampleRateChanged);
        uint PropertySampleRate();
        void SetPropertyLosslessChanged(System.Action aLosslessChanged);
        bool PropertyLossless();
        void SetPropertyCodecNameChanged(System.Action aCodecNameChanged);
        String PropertyCodecName();
        void SetPropertyMetatextChanged(System.Action aMetatextChanged);
        String PropertyMetatext();
    }

    internal class SyncCountersLinnCoUkInfo1 : SyncProxyAction
    {
        private CpProxyLinnCoUkInfo1 iService;
        private uint iTrackCount;
        private uint iDetailsCount;
        private uint iMetatextCount;

        public SyncCountersLinnCoUkInfo1(CpProxyLinnCoUkInfo1 aProxy)
        {
            iService = aProxy;
        }
        public uint TrackCount()
        {
            return iTrackCount;
        }
        public uint DetailsCount()
        {
            return iDetailsCount;
        }
        public uint MetatextCount()
        {
            return iMetatextCount;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndCounters(aAsyncHandle, out iTrackCount, out iDetailsCount, out iMetatextCount);
        }
    };

    internal class SyncTrackLinnCoUkInfo1 : SyncProxyAction
    {
        private CpProxyLinnCoUkInfo1 iService;
        private String iUri;
        private String iMetadata;

        public SyncTrackLinnCoUkInfo1(CpProxyLinnCoUkInfo1 aProxy)
        {
            iService = aProxy;
        }
        public String Uri()
        {
            return iUri;
        }
        public String Metadata()
        {
            return iMetadata;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndTrack(aAsyncHandle, out iUri, out iMetadata);
        }
    };

    internal class SyncDetailsLinnCoUkInfo1 : SyncProxyAction
    {
        private CpProxyLinnCoUkInfo1 iService;
        private uint iDuration;
        private uint iBitRate;
        private uint iBitDepth;
        private uint iSampleRate;
        private bool iLossless;
        private String iCodecName;

        public SyncDetailsLinnCoUkInfo1(CpProxyLinnCoUkInfo1 aProxy)
        {
            iService = aProxy;
        }
        public uint Duration()
        {
            return iDuration;
        }
        public uint BitRate()
        {
            return iBitRate;
        }
        public uint BitDepth()
        {
            return iBitDepth;
        }
        public uint SampleRate()
        {
            return iSampleRate;
        }
        public bool Lossless()
        {
            return iLossless;
        }
        public String CodecName()
        {
            return iCodecName;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndDetails(aAsyncHandle, out iDuration, out iBitRate, out iBitDepth, out iSampleRate, out iLossless, out iCodecName);
        }
    };

    internal class SyncMetatextLinnCoUkInfo1 : SyncProxyAction
    {
        private CpProxyLinnCoUkInfo1 iService;
        private String iMetatext;

        public SyncMetatextLinnCoUkInfo1(CpProxyLinnCoUkInfo1 aProxy)
        {
            iService = aProxy;
        }
        public String Metatext()
        {
            return iMetatext;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndMetatext(aAsyncHandle, out iMetatext);
        }
    };

    /// <summary>
    /// Proxy for the linn.co.uk:Info:1 UPnP service
    /// </summary>
    public class CpProxyLinnCoUkInfo1 : CpProxy, IDisposable, ICpProxyLinnCoUkInfo1
    {
        private Zapp.Core.Action iActionCounters;
        private Zapp.Core.Action iActionTrack;
        private Zapp.Core.Action iActionDetails;
        private Zapp.Core.Action iActionMetatext;
        private PropertyUint iTrackCount;
        private PropertyUint iDetailsCount;
        private PropertyUint iMetatextCount;
        private PropertyString iUri;
        private PropertyString iMetadata;
        private PropertyUint iDuration;
        private PropertyUint iBitRate;
        private PropertyUint iBitDepth;
        private PropertyUint iSampleRate;
        private PropertyBool iLossless;
        private PropertyString iCodecName;
        private PropertyString iMetatext;
        private System.Action iTrackCountChanged;
        private System.Action iDetailsCountChanged;
        private System.Action iMetatextCountChanged;
        private System.Action iUriChanged;
        private System.Action iMetadataChanged;
        private System.Action iDurationChanged;
        private System.Action iBitRateChanged;
        private System.Action iBitDepthChanged;
        private System.Action iSampleRateChanged;
        private System.Action iLosslessChanged;
        private System.Action iCodecNameChanged;
        private System.Action iMetatextChanged;
        private Mutex iPropertyLock;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <remarks>Use CpProxy::[Un]Subscribe() to enable/disable querying of state variable and reporting of their changes.</remarks>
        /// <param name="aDevice">The device to use</param>
        public CpProxyLinnCoUkInfo1(CpDevice aDevice)
            : base("linn-co-uk", "Info", 1, aDevice)
        {
            Zapp.Core.Parameter param;
            List<String> allowedValues = new List<String>();

            iActionCounters = new Zapp.Core.Action("Counters");
            param = new ParameterUint("aTrackCount");
            iActionCounters.AddOutputParameter(param);
            param = new ParameterUint("aDetailsCount");
            iActionCounters.AddOutputParameter(param);
            param = new ParameterUint("aMetatextCount");
            iActionCounters.AddOutputParameter(param);

            iActionTrack = new Zapp.Core.Action("Track");
            param = new ParameterString("aUri", allowedValues);
            iActionTrack.AddOutputParameter(param);
            param = new ParameterString("aMetadata", allowedValues);
            iActionTrack.AddOutputParameter(param);

            iActionDetails = new Zapp.Core.Action("Details");
            param = new ParameterUint("aDuration");
            iActionDetails.AddOutputParameter(param);
            param = new ParameterUint("aBitRate");
            iActionDetails.AddOutputParameter(param);
            param = new ParameterUint("aBitDepth");
            iActionDetails.AddOutputParameter(param);
            param = new ParameterUint("aSampleRate");
            iActionDetails.AddOutputParameter(param);
            param = new ParameterBool("aLossless");
            iActionDetails.AddOutputParameter(param);
            param = new ParameterString("aCodecName", allowedValues);
            iActionDetails.AddOutputParameter(param);

            iActionMetatext = new Zapp.Core.Action("Metatext");
            param = new ParameterString("aMetatext", allowedValues);
            iActionMetatext.AddOutputParameter(param);

            iTrackCount = new PropertyUint("TrackCount", TrackCountPropertyChanged);
            AddProperty(iTrackCount);
            iDetailsCount = new PropertyUint("DetailsCount", DetailsCountPropertyChanged);
            AddProperty(iDetailsCount);
            iMetatextCount = new PropertyUint("MetatextCount", MetatextCountPropertyChanged);
            AddProperty(iMetatextCount);
            iUri = new PropertyString("Uri", UriPropertyChanged);
            AddProperty(iUri);
            iMetadata = new PropertyString("Metadata", MetadataPropertyChanged);
            AddProperty(iMetadata);
            iDuration = new PropertyUint("Duration", DurationPropertyChanged);
            AddProperty(iDuration);
            iBitRate = new PropertyUint("BitRate", BitRatePropertyChanged);
            AddProperty(iBitRate);
            iBitDepth = new PropertyUint("BitDepth", BitDepthPropertyChanged);
            AddProperty(iBitDepth);
            iSampleRate = new PropertyUint("SampleRate", SampleRatePropertyChanged);
            AddProperty(iSampleRate);
            iLossless = new PropertyBool("Lossless", LosslessPropertyChanged);
            AddProperty(iLossless);
            iCodecName = new PropertyString("CodecName", CodecNamePropertyChanged);
            AddProperty(iCodecName);
            iMetatext = new PropertyString("Metatext", MetatextPropertyChanged);
            AddProperty(iMetatext);
            
            iPropertyLock = new Mutex();
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aaTrackCount"></param>
        /// <param name="aaDetailsCount"></param>
        /// <param name="aaMetatextCount"></param>
        public void SyncCounters(out uint aTrackCount, out uint aDetailsCount, out uint aMetatextCount)
        {
            SyncCountersLinnCoUkInfo1 sync = new SyncCountersLinnCoUkInfo1(this);
            BeginCounters(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aTrackCount = sync.TrackCount();
            aDetailsCount = sync.DetailsCount();
            aMetatextCount = sync.MetatextCount();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndCounters().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginCounters(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionCounters, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentUint((ParameterUint)iActionCounters.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentUint((ParameterUint)iActionCounters.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentUint((ParameterUint)iActionCounters.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aaTrackCount"></param>
        /// <param name="aaDetailsCount"></param>
        /// <param name="aaMetatextCount"></param>
        public void EndCounters(IntPtr aAsyncHandle, out uint aTrackCount, out uint aDetailsCount, out uint aMetatextCount)
        {
            if (Invocation.Error(aAsyncHandle))
            {
                throw new ProxyError();
            }
            uint index = 0;
            aTrackCount = Invocation.OutputUint(aAsyncHandle, index++);
            aDetailsCount = Invocation.OutputUint(aAsyncHandle, index++);
            aMetatextCount = Invocation.OutputUint(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aaUri"></param>
        /// <param name="aaMetadata"></param>
        public void SyncTrack(out String aUri, out String aMetadata)
        {
            SyncTrackLinnCoUkInfo1 sync = new SyncTrackLinnCoUkInfo1(this);
            BeginTrack(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aUri = sync.Uri();
            aMetadata = sync.Metadata();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndTrack().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginTrack(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionTrack, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionTrack.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionTrack.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aaUri"></param>
        /// <param name="aaMetadata"></param>
        public void EndTrack(IntPtr aAsyncHandle, out String aUri, out String aMetadata)
        {
            if (Invocation.Error(aAsyncHandle))
            {
                throw new ProxyError();
            }
            uint index = 0;
            aUri = Invocation.OutputString(aAsyncHandle, index++);
            aMetadata = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aaDuration"></param>
        /// <param name="aaBitRate"></param>
        /// <param name="aaBitDepth"></param>
        /// <param name="aaSampleRate"></param>
        /// <param name="aaLossless"></param>
        /// <param name="aaCodecName"></param>
        public void SyncDetails(out uint aDuration, out uint aBitRate, out uint aBitDepth, out uint aSampleRate, out bool aLossless, out String aCodecName)
        {
            SyncDetailsLinnCoUkInfo1 sync = new SyncDetailsLinnCoUkInfo1(this);
            BeginDetails(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aDuration = sync.Duration();
            aBitRate = sync.BitRate();
            aBitDepth = sync.BitDepth();
            aSampleRate = sync.SampleRate();
            aLossless = sync.Lossless();
            aCodecName = sync.CodecName();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndDetails().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginDetails(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionDetails, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentUint((ParameterUint)iActionDetails.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentUint((ParameterUint)iActionDetails.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentUint((ParameterUint)iActionDetails.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentUint((ParameterUint)iActionDetails.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentBool((ParameterBool)iActionDetails.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionDetails.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aaDuration"></param>
        /// <param name="aaBitRate"></param>
        /// <param name="aaBitDepth"></param>
        /// <param name="aaSampleRate"></param>
        /// <param name="aaLossless"></param>
        /// <param name="aaCodecName"></param>
        public void EndDetails(IntPtr aAsyncHandle, out uint aDuration, out uint aBitRate, out uint aBitDepth, out uint aSampleRate, out bool aLossless, out String aCodecName)
        {
            if (Invocation.Error(aAsyncHandle))
            {
                throw new ProxyError();
            }
            uint index = 0;
            aDuration = Invocation.OutputUint(aAsyncHandle, index++);
            aBitRate = Invocation.OutputUint(aAsyncHandle, index++);
            aBitDepth = Invocation.OutputUint(aAsyncHandle, index++);
            aSampleRate = Invocation.OutputUint(aAsyncHandle, index++);
            aLossless = Invocation.OutputBool(aAsyncHandle, index++);
            aCodecName = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aaMetatext"></param>
        public void SyncMetatext(out String aMetatext)
        {
            SyncMetatextLinnCoUkInfo1 sync = new SyncMetatextLinnCoUkInfo1(this);
            BeginMetatext(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aMetatext = sync.Metatext();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndMetatext().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginMetatext(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionMetatext, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionMetatext.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aaMetatext"></param>
        public void EndMetatext(IntPtr aAsyncHandle, out String aMetatext)
        {
            if (Invocation.Error(aAsyncHandle))
            {
                throw new ProxyError();
            }
            uint index = 0;
            aMetatext = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Set a delegate to be run when the TrackCount state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyLinnCoUkInfo1 instance will not overlap.</remarks>
        /// <param name="aTrackCountChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyTrackCountChanged(System.Action aTrackCountChanged)
        {
            lock (iPropertyLock)
            {
                iTrackCountChanged = aTrackCountChanged;
            }
        }

        private void TrackCountPropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iTrackCountChanged);
            }
        }

        /// <summary>
        /// Set a delegate to be run when the DetailsCount state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyLinnCoUkInfo1 instance will not overlap.</remarks>
        /// <param name="aDetailsCountChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyDetailsCountChanged(System.Action aDetailsCountChanged)
        {
            lock (iPropertyLock)
            {
                iDetailsCountChanged = aDetailsCountChanged;
            }
        }

        private void DetailsCountPropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iDetailsCountChanged);
            }
        }

        /// <summary>
        /// Set a delegate to be run when the MetatextCount state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyLinnCoUkInfo1 instance will not overlap.</remarks>
        /// <param name="aMetatextCountChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyMetatextCountChanged(System.Action aMetatextCountChanged)
        {
            lock (iPropertyLock)
            {
                iMetatextCountChanged = aMetatextCountChanged;
            }
        }

        private void MetatextCountPropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iMetatextCountChanged);
            }
        }

        /// <summary>
        /// Set a delegate to be run when the Uri state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyLinnCoUkInfo1 instance will not overlap.</remarks>
        /// <param name="aUriChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyUriChanged(System.Action aUriChanged)
        {
            lock (iPropertyLock)
            {
                iUriChanged = aUriChanged;
            }
        }

        private void UriPropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iUriChanged);
            }
        }

        /// <summary>
        /// Set a delegate to be run when the Metadata state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyLinnCoUkInfo1 instance will not overlap.</remarks>
        /// <param name="aMetadataChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyMetadataChanged(System.Action aMetadataChanged)
        {
            lock (iPropertyLock)
            {
                iMetadataChanged = aMetadataChanged;
            }
        }

        private void MetadataPropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iMetadataChanged);
            }
        }

        /// <summary>
        /// Set a delegate to be run when the Duration state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyLinnCoUkInfo1 instance will not overlap.</remarks>
        /// <param name="aDurationChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyDurationChanged(System.Action aDurationChanged)
        {
            lock (iPropertyLock)
            {
                iDurationChanged = aDurationChanged;
            }
        }

        private void DurationPropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iDurationChanged);
            }
        }

        /// <summary>
        /// Set a delegate to be run when the BitRate state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyLinnCoUkInfo1 instance will not overlap.</remarks>
        /// <param name="aBitRateChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyBitRateChanged(System.Action aBitRateChanged)
        {
            lock (iPropertyLock)
            {
                iBitRateChanged = aBitRateChanged;
            }
        }

        private void BitRatePropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iBitRateChanged);
            }
        }

        /// <summary>
        /// Set a delegate to be run when the BitDepth state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyLinnCoUkInfo1 instance will not overlap.</remarks>
        /// <param name="aBitDepthChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyBitDepthChanged(System.Action aBitDepthChanged)
        {
            lock (iPropertyLock)
            {
                iBitDepthChanged = aBitDepthChanged;
            }
        }

        private void BitDepthPropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iBitDepthChanged);
            }
        }

        /// <summary>
        /// Set a delegate to be run when the SampleRate state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyLinnCoUkInfo1 instance will not overlap.</remarks>
        /// <param name="aSampleRateChanged">The delegate to run when the state variable changes</param>
        public void SetPropertySampleRateChanged(System.Action aSampleRateChanged)
        {
            lock (iPropertyLock)
            {
                iSampleRateChanged = aSampleRateChanged;
            }
        }

        private void SampleRatePropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iSampleRateChanged);
            }
        }

        /// <summary>
        /// Set a delegate to be run when the Lossless state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyLinnCoUkInfo1 instance will not overlap.</remarks>
        /// <param name="aLosslessChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyLosslessChanged(System.Action aLosslessChanged)
        {
            lock (iPropertyLock)
            {
                iLosslessChanged = aLosslessChanged;
            }
        }

        private void LosslessPropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iLosslessChanged);
            }
        }

        /// <summary>
        /// Set a delegate to be run when the CodecName state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyLinnCoUkInfo1 instance will not overlap.</remarks>
        /// <param name="aCodecNameChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyCodecNameChanged(System.Action aCodecNameChanged)
        {
            lock (iPropertyLock)
            {
                iCodecNameChanged = aCodecNameChanged;
            }
        }

        private void CodecNamePropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iCodecNameChanged);
            }
        }

        /// <summary>
        /// Set a delegate to be run when the Metatext state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyLinnCoUkInfo1 instance will not overlap.</remarks>
        /// <param name="aMetatextChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyMetatextChanged(System.Action aMetatextChanged)
        {
            lock (iPropertyLock)
            {
                iMetatextChanged = aMetatextChanged;
            }
        }

        private void MetatextPropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iMetatextChanged);
            }
        }

        /// <summary>
        /// Query the value of the TrackCount property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <param name="aTrackCount">Will be set to the value of the property</param>
        public uint PropertyTrackCount()
        {
            PropertyReadLock();
            uint val = iTrackCount.Value();
            PropertyReadUnlock();
            return val;
        }

        /// <summary>
        /// Query the value of the DetailsCount property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <param name="aDetailsCount">Will be set to the value of the property</param>
        public uint PropertyDetailsCount()
        {
            PropertyReadLock();
            uint val = iDetailsCount.Value();
            PropertyReadUnlock();
            return val;
        }

        /// <summary>
        /// Query the value of the MetatextCount property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <param name="aMetatextCount">Will be set to the value of the property</param>
        public uint PropertyMetatextCount()
        {
            PropertyReadLock();
            uint val = iMetatextCount.Value();
            PropertyReadUnlock();
            return val;
        }

        /// <summary>
        /// Query the value of the Uri property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <param name="aUri">Will be set to the value of the property</param>
        public String PropertyUri()
        {
            PropertyReadLock();
            String val = iUri.Value();
            PropertyReadUnlock();
            return val;
        }

        /// <summary>
        /// Query the value of the Metadata property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <param name="aMetadata">Will be set to the value of the property</param>
        public String PropertyMetadata()
        {
            PropertyReadLock();
            String val = iMetadata.Value();
            PropertyReadUnlock();
            return val;
        }

        /// <summary>
        /// Query the value of the Duration property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <param name="aDuration">Will be set to the value of the property</param>
        public uint PropertyDuration()
        {
            PropertyReadLock();
            uint val = iDuration.Value();
            PropertyReadUnlock();
            return val;
        }

        /// <summary>
        /// Query the value of the BitRate property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <param name="aBitRate">Will be set to the value of the property</param>
        public uint PropertyBitRate()
        {
            PropertyReadLock();
            uint val = iBitRate.Value();
            PropertyReadUnlock();
            return val;
        }

        /// <summary>
        /// Query the value of the BitDepth property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <param name="aBitDepth">Will be set to the value of the property</param>
        public uint PropertyBitDepth()
        {
            PropertyReadLock();
            uint val = iBitDepth.Value();
            PropertyReadUnlock();
            return val;
        }

        /// <summary>
        /// Query the value of the SampleRate property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <param name="aSampleRate">Will be set to the value of the property</param>
        public uint PropertySampleRate()
        {
            PropertyReadLock();
            uint val = iSampleRate.Value();
            PropertyReadUnlock();
            return val;
        }

        /// <summary>
        /// Query the value of the Lossless property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <param name="aLossless">Will be set to the value of the property</param>
        public bool PropertyLossless()
        {
            PropertyReadLock();
            bool val = iLossless.Value();
            PropertyReadUnlock();
            return val;
        }

        /// <summary>
        /// Query the value of the CodecName property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <param name="aCodecName">Will be set to the value of the property</param>
        public String PropertyCodecName()
        {
            PropertyReadLock();
            String val = iCodecName.Value();
            PropertyReadUnlock();
            return val;
        }

        /// <summary>
        /// Query the value of the Metatext property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <param name="aMetatext">Will be set to the value of the property</param>
        public String PropertyMetatext()
        {
            PropertyReadLock();
            String val = iMetatext.Value();
            PropertyReadUnlock();
            return val;
        }

        /// <summary>
        /// Must be called for each class instance.  Must be called before Core.Library.Close().
        /// </summary>
        public void Dispose()
        {
            DoDispose(true);
        }

        ~CpProxyLinnCoUkInfo1()
        {
            DoDispose(false);
        }

        private void DoDispose(bool aDisposing)
        {
            lock (this)
            {
                if (iHandle == IntPtr.Zero)
                {
                    return;
                }
                DisposeProxy();
                iHandle = IntPtr.Zero;
                iActionCounters.Dispose();
                iActionTrack.Dispose();
                iActionDetails.Dispose();
                iActionMetatext.Dispose();
                iTrackCount.Dispose();
                iDetailsCount.Dispose();
                iMetatextCount.Dispose();
                iUri.Dispose();
                iMetadata.Dispose();
                iDuration.Dispose();
                iBitRate.Dispose();
                iBitDepth.Dispose();
                iSampleRate.Dispose();
                iLossless.Dispose();
                iCodecName.Dispose();
                iMetatext.Dispose();
            }
            if (aDisposing)
            {
                GC.SuppressFinalize(this);
            }
        }
    }
}

