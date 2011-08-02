using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenHome.Net.Core;
using OpenHome.Net.ControlPoint;

namespace OpenHome.Net.ControlPoint.Proxies
{
    public interface ICpProxyAvOpenhomeOrgPlaylistManager1 : ICpProxy, IDisposable
    {
        void SyncMetadata(out String aMetadata);
        void BeginMetadata(CpProxy.CallbackAsyncComplete aCallback);
        void EndMetadata(IntPtr aAsyncHandle, out String aMetadata);
        void SyncImagesXml(out String aImagesXml);
        void BeginImagesXml(CpProxy.CallbackAsyncComplete aCallback);
        void EndImagesXml(IntPtr aAsyncHandle, out String aImagesXml);
        void SyncPlaylistReadArray(uint aId, out byte[] aArray);
        void BeginPlaylistReadArray(uint aId, CpProxy.CallbackAsyncComplete aCallback);
        void EndPlaylistReadArray(IntPtr aAsyncHandle, out byte[] aArray);
        void SyncPlaylistReadMetadata(String aIdList, out String aMetadata);
        void BeginPlaylistReadMetadata(String aIdList, CpProxy.CallbackAsyncComplete aCallback);
        void EndPlaylistReadMetadata(IntPtr aAsyncHandle, out String aMetadata);
        void SyncPlaylistRead(uint aId, out String aName, out String aDescription, out uint aImageId);
        void BeginPlaylistRead(uint aId, CpProxy.CallbackAsyncComplete aCallback);
        void EndPlaylistRead(IntPtr aAsyncHandle, out String aName, out String aDescription, out uint aImageId);
        void SyncPlaylistUpdate(uint aId, String aName, String aDescription, uint aImageId);
        void BeginPlaylistUpdate(uint aId, String aName, String aDescription, uint aImageId, CpProxy.CallbackAsyncComplete aCallback);
        void EndPlaylistUpdate(IntPtr aAsyncHandle);
        void SyncPlaylistInsert(uint aAfterId, String aName, String aDescription, uint aImageId, out uint aNewId);
        void BeginPlaylistInsert(uint aAfterId, String aName, String aDescription, uint aImageId, CpProxy.CallbackAsyncComplete aCallback);
        void EndPlaylistInsert(IntPtr aAsyncHandle, out uint aNewId);
        void SyncPlaylistDeleteId(uint aValue);
        void BeginPlaylistDeleteId(uint aValue, CpProxy.CallbackAsyncComplete aCallback);
        void EndPlaylistDeleteId(IntPtr aAsyncHandle);
        void SyncPlaylistsMax(out uint aValue);
        void BeginPlaylistsMax(CpProxy.CallbackAsyncComplete aCallback);
        void EndPlaylistsMax(IntPtr aAsyncHandle, out uint aValue);
        void SyncTracksMax(out uint aValue);
        void BeginTracksMax(CpProxy.CallbackAsyncComplete aCallback);
        void EndTracksMax(IntPtr aAsyncHandle, out uint aValue);
        void SyncPlaylistArrays(out uint aToken, out byte[] aIdArray, out byte[] aTokenArray);
        void BeginPlaylistArrays(CpProxy.CallbackAsyncComplete aCallback);
        void EndPlaylistArrays(IntPtr aAsyncHandle, out uint aToken, out byte[] aIdArray, out byte[] aTokenArray);
        void SyncPlaylistArraysChanged(uint aToken, out bool aValue);
        void BeginPlaylistArraysChanged(uint aToken, CpProxy.CallbackAsyncComplete aCallback);
        void EndPlaylistArraysChanged(IntPtr aAsyncHandle, out bool aValue);
        void SyncRead(uint aId, uint aTrackId, out String aMetadata);
        void BeginRead(uint aId, uint aTrackId, CpProxy.CallbackAsyncComplete aCallback);
        void EndRead(IntPtr aAsyncHandle, out String aMetadata);
        void SyncReadList(uint aId, String aTrackIdList, out String aTrackList);
        void BeginReadList(uint aId, String aTrackIdList, CpProxy.CallbackAsyncComplete aCallback);
        void EndReadList(IntPtr aAsyncHandle, out String aTrackList);
        void SyncInsert(uint aId, uint aAfterTrackId, String aUdn, String aMetadataId, out uint aNewTrackId);
        void BeginInsert(uint aId, uint aAfterTrackId, String aUdn, String aMetadataId, CpProxy.CallbackAsyncComplete aCallback);
        void EndInsert(IntPtr aAsyncHandle, out uint aNewTrackId);
        void SyncDeleteId(uint aTrackId, uint aValue);
        void BeginDeleteId(uint aTrackId, uint aValue, CpProxy.CallbackAsyncComplete aCallback);
        void EndDeleteId(IntPtr aAsyncHandle);
        void SyncDeleteAll(uint aTrackId);
        void BeginDeleteAll(uint aTrackId, CpProxy.CallbackAsyncComplete aCallback);
        void EndDeleteAll(IntPtr aAsyncHandle);
        void SetPropertyMetadataChanged(System.Action aMetadataChanged);
        String PropertyMetadata();
        void SetPropertyImagesXmlChanged(System.Action aImagesXmlChanged);
        String PropertyImagesXml();
        void SetPropertyIdArrayChanged(System.Action aIdArrayChanged);
        byte[] PropertyIdArray();
        void SetPropertyTokenArrayChanged(System.Action aTokenArrayChanged);
        byte[] PropertyTokenArray();
        void SetPropertyPlaylistsMaxChanged(System.Action aPlaylistsMaxChanged);
        uint PropertyPlaylistsMax();
        void SetPropertyTracksMaxChanged(System.Action aTracksMaxChanged);
        uint PropertyTracksMax();
    }

    internal class SyncMetadataAvOpenhomeOrgPlaylistManager1 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgPlaylistManager1 iService;
        private String iMetadata;

        public SyncMetadataAvOpenhomeOrgPlaylistManager1(CpProxyAvOpenhomeOrgPlaylistManager1 aProxy)
        {
            iService = aProxy;
        }
        public String Metadata()
        {
            return iMetadata;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndMetadata(aAsyncHandle, out iMetadata);
        }
    };

    internal class SyncImagesXmlAvOpenhomeOrgPlaylistManager1 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgPlaylistManager1 iService;
        private String iImagesXml;

        public SyncImagesXmlAvOpenhomeOrgPlaylistManager1(CpProxyAvOpenhomeOrgPlaylistManager1 aProxy)
        {
            iService = aProxy;
        }
        public String ImagesXml()
        {
            return iImagesXml;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndImagesXml(aAsyncHandle, out iImagesXml);
        }
    };

    internal class SyncPlaylistReadArrayAvOpenhomeOrgPlaylistManager1 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgPlaylistManager1 iService;
        private byte[] iArray;

        public SyncPlaylistReadArrayAvOpenhomeOrgPlaylistManager1(CpProxyAvOpenhomeOrgPlaylistManager1 aProxy)
        {
            iService = aProxy;
        }
        public byte[] Array()
        {
            return iArray;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndPlaylistReadArray(aAsyncHandle, out iArray);
        }
    };

    internal class SyncPlaylistReadMetadataAvOpenhomeOrgPlaylistManager1 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgPlaylistManager1 iService;
        private String iMetadata;

        public SyncPlaylistReadMetadataAvOpenhomeOrgPlaylistManager1(CpProxyAvOpenhomeOrgPlaylistManager1 aProxy)
        {
            iService = aProxy;
        }
        public String Metadata()
        {
            return iMetadata;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndPlaylistReadMetadata(aAsyncHandle, out iMetadata);
        }
    };

    internal class SyncPlaylistReadAvOpenhomeOrgPlaylistManager1 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgPlaylistManager1 iService;
        private String iName;
        private String iDescription;
        private uint iImageId;

        public SyncPlaylistReadAvOpenhomeOrgPlaylistManager1(CpProxyAvOpenhomeOrgPlaylistManager1 aProxy)
        {
            iService = aProxy;
        }
        public String Name()
        {
            return iName;
        }
        public String Description()
        {
            return iDescription;
        }
        public uint ImageId()
        {
            return iImageId;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndPlaylistRead(aAsyncHandle, out iName, out iDescription, out iImageId);
        }
    };

    internal class SyncPlaylistUpdateAvOpenhomeOrgPlaylistManager1 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgPlaylistManager1 iService;

        public SyncPlaylistUpdateAvOpenhomeOrgPlaylistManager1(CpProxyAvOpenhomeOrgPlaylistManager1 aProxy)
        {
            iService = aProxy;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndPlaylistUpdate(aAsyncHandle);
        }
    };

    internal class SyncPlaylistInsertAvOpenhomeOrgPlaylistManager1 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgPlaylistManager1 iService;
        private uint iNewId;

        public SyncPlaylistInsertAvOpenhomeOrgPlaylistManager1(CpProxyAvOpenhomeOrgPlaylistManager1 aProxy)
        {
            iService = aProxy;
        }
        public uint NewId()
        {
            return iNewId;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndPlaylistInsert(aAsyncHandle, out iNewId);
        }
    };

    internal class SyncPlaylistDeleteIdAvOpenhomeOrgPlaylistManager1 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgPlaylistManager1 iService;

        public SyncPlaylistDeleteIdAvOpenhomeOrgPlaylistManager1(CpProxyAvOpenhomeOrgPlaylistManager1 aProxy)
        {
            iService = aProxy;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndPlaylistDeleteId(aAsyncHandle);
        }
    };

    internal class SyncPlaylistsMaxAvOpenhomeOrgPlaylistManager1 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgPlaylistManager1 iService;
        private uint iValue;

        public SyncPlaylistsMaxAvOpenhomeOrgPlaylistManager1(CpProxyAvOpenhomeOrgPlaylistManager1 aProxy)
        {
            iService = aProxy;
        }
        public uint Value()
        {
            return iValue;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndPlaylistsMax(aAsyncHandle, out iValue);
        }
    };

    internal class SyncTracksMaxAvOpenhomeOrgPlaylistManager1 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgPlaylistManager1 iService;
        private uint iValue;

        public SyncTracksMaxAvOpenhomeOrgPlaylistManager1(CpProxyAvOpenhomeOrgPlaylistManager1 aProxy)
        {
            iService = aProxy;
        }
        public uint Value()
        {
            return iValue;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndTracksMax(aAsyncHandle, out iValue);
        }
    };

    internal class SyncPlaylistArraysAvOpenhomeOrgPlaylistManager1 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgPlaylistManager1 iService;
        private uint iToken;
        private byte[] iIdArray;
        private byte[] iTokenArray;

        public SyncPlaylistArraysAvOpenhomeOrgPlaylistManager1(CpProxyAvOpenhomeOrgPlaylistManager1 aProxy)
        {
            iService = aProxy;
        }
        public uint Token()
        {
            return iToken;
        }
        public byte[] IdArray()
        {
            return iIdArray;
        }
        public byte[] TokenArray()
        {
            return iTokenArray;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndPlaylistArrays(aAsyncHandle, out iToken, out iIdArray, out iTokenArray);
        }
    };

    internal class SyncPlaylistArraysChangedAvOpenhomeOrgPlaylistManager1 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgPlaylistManager1 iService;
        private bool iValue;

        public SyncPlaylistArraysChangedAvOpenhomeOrgPlaylistManager1(CpProxyAvOpenhomeOrgPlaylistManager1 aProxy)
        {
            iService = aProxy;
        }
        public bool Value()
        {
            return iValue;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndPlaylistArraysChanged(aAsyncHandle, out iValue);
        }
    };

    internal class SyncReadAvOpenhomeOrgPlaylistManager1 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgPlaylistManager1 iService;
        private String iMetadata;

        public SyncReadAvOpenhomeOrgPlaylistManager1(CpProxyAvOpenhomeOrgPlaylistManager1 aProxy)
        {
            iService = aProxy;
        }
        public String Metadata()
        {
            return iMetadata;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndRead(aAsyncHandle, out iMetadata);
        }
    };

    internal class SyncReadListAvOpenhomeOrgPlaylistManager1 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgPlaylistManager1 iService;
        private String iTrackList;

        public SyncReadListAvOpenhomeOrgPlaylistManager1(CpProxyAvOpenhomeOrgPlaylistManager1 aProxy)
        {
            iService = aProxy;
        }
        public String TrackList()
        {
            return iTrackList;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndReadList(aAsyncHandle, out iTrackList);
        }
    };

    internal class SyncInsertAvOpenhomeOrgPlaylistManager1 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgPlaylistManager1 iService;
        private uint iNewTrackId;

        public SyncInsertAvOpenhomeOrgPlaylistManager1(CpProxyAvOpenhomeOrgPlaylistManager1 aProxy)
        {
            iService = aProxy;
        }
        public uint NewTrackId()
        {
            return iNewTrackId;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndInsert(aAsyncHandle, out iNewTrackId);
        }
    };

    internal class SyncDeleteIdAvOpenhomeOrgPlaylistManager1 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgPlaylistManager1 iService;

        public SyncDeleteIdAvOpenhomeOrgPlaylistManager1(CpProxyAvOpenhomeOrgPlaylistManager1 aProxy)
        {
            iService = aProxy;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndDeleteId(aAsyncHandle);
        }
    };

    internal class SyncDeleteAllAvOpenhomeOrgPlaylistManager1 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgPlaylistManager1 iService;

        public SyncDeleteAllAvOpenhomeOrgPlaylistManager1(CpProxyAvOpenhomeOrgPlaylistManager1 aProxy)
        {
            iService = aProxy;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndDeleteAll(aAsyncHandle);
        }
    };

    /// <summary>
    /// Proxy for the av.openhome.org:PlaylistManager:1 UPnP service
    /// </summary>
    public class CpProxyAvOpenhomeOrgPlaylistManager1 : CpProxy, IDisposable, ICpProxyAvOpenhomeOrgPlaylistManager1
    {
        private OpenHome.Net.Core.Action iActionMetadata;
        private OpenHome.Net.Core.Action iActionImagesXml;
        private OpenHome.Net.Core.Action iActionPlaylistReadArray;
        private OpenHome.Net.Core.Action iActionPlaylistReadMetadata;
        private OpenHome.Net.Core.Action iActionPlaylistRead;
        private OpenHome.Net.Core.Action iActionPlaylistUpdate;
        private OpenHome.Net.Core.Action iActionPlaylistInsert;
        private OpenHome.Net.Core.Action iActionPlaylistDeleteId;
        private OpenHome.Net.Core.Action iActionPlaylistsMax;
        private OpenHome.Net.Core.Action iActionTracksMax;
        private OpenHome.Net.Core.Action iActionPlaylistArrays;
        private OpenHome.Net.Core.Action iActionPlaylistArraysChanged;
        private OpenHome.Net.Core.Action iActionRead;
        private OpenHome.Net.Core.Action iActionReadList;
        private OpenHome.Net.Core.Action iActionInsert;
        private OpenHome.Net.Core.Action iActionDeleteId;
        private OpenHome.Net.Core.Action iActionDeleteAll;
        private PropertyString iMetadata;
        private PropertyString iImagesXml;
        private PropertyBinary iIdArray;
        private PropertyBinary iTokenArray;
        private PropertyUint iPlaylistsMax;
        private PropertyUint iTracksMax;
        private System.Action iMetadataChanged;
        private System.Action iImagesXmlChanged;
        private System.Action iIdArrayChanged;
        private System.Action iTokenArrayChanged;
        private System.Action iPlaylistsMaxChanged;
        private System.Action iTracksMaxChanged;
        private Mutex iPropertyLock;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <remarks>Use CpProxy::[Un]Subscribe() to enable/disable querying of state variable and reporting of their changes.</remarks>
        /// <param name="aDevice">The device to use</param>
        public CpProxyAvOpenhomeOrgPlaylistManager1(CpDevice aDevice)
            : base("av-openhome-org", "PlaylistManager", 1, aDevice)
        {
            OpenHome.Net.Core.Parameter param;
            List<String> allowedValues = new List<String>();

            iActionMetadata = new OpenHome.Net.Core.Action("Metadata");
            param = new ParameterString("Metadata", allowedValues);
            iActionMetadata.AddOutputParameter(param);

            iActionImagesXml = new OpenHome.Net.Core.Action("ImagesXml");
            param = new ParameterString("ImagesXml", allowedValues);
            iActionImagesXml.AddOutputParameter(param);

            iActionPlaylistReadArray = new OpenHome.Net.Core.Action("PlaylistReadArray");
            param = new ParameterUint("Id");
            iActionPlaylistReadArray.AddInputParameter(param);
            param = new ParameterBinary("Array");
            iActionPlaylistReadArray.AddOutputParameter(param);

            iActionPlaylistReadMetadata = new OpenHome.Net.Core.Action("PlaylistReadMetadata");
            param = new ParameterString("IdList", allowedValues);
            iActionPlaylistReadMetadata.AddInputParameter(param);
            param = new ParameterString("Metadata", allowedValues);
            iActionPlaylistReadMetadata.AddOutputParameter(param);

            iActionPlaylistRead = new OpenHome.Net.Core.Action("PlaylistRead");
            param = new ParameterUint("Id");
            iActionPlaylistRead.AddInputParameter(param);
            param = new ParameterString("Name", allowedValues);
            iActionPlaylistRead.AddOutputParameter(param);
            param = new ParameterString("Description", allowedValues);
            iActionPlaylistRead.AddOutputParameter(param);
            param = new ParameterUint("ImageId");
            iActionPlaylistRead.AddOutputParameter(param);

            iActionPlaylistUpdate = new OpenHome.Net.Core.Action("PlaylistUpdate");
            param = new ParameterUint("Id");
            iActionPlaylistUpdate.AddInputParameter(param);
            param = new ParameterString("Name", allowedValues);
            iActionPlaylistUpdate.AddInputParameter(param);
            param = new ParameterString("Description", allowedValues);
            iActionPlaylistUpdate.AddInputParameter(param);
            param = new ParameterUint("ImageId");
            iActionPlaylistUpdate.AddInputParameter(param);

            iActionPlaylistInsert = new OpenHome.Net.Core.Action("PlaylistInsert");
            param = new ParameterUint("AfterId");
            iActionPlaylistInsert.AddInputParameter(param);
            param = new ParameterString("Name", allowedValues);
            iActionPlaylistInsert.AddInputParameter(param);
            param = new ParameterString("Description", allowedValues);
            iActionPlaylistInsert.AddInputParameter(param);
            param = new ParameterUint("ImageId");
            iActionPlaylistInsert.AddInputParameter(param);
            param = new ParameterUint("NewId");
            iActionPlaylistInsert.AddOutputParameter(param);

            iActionPlaylistDeleteId = new OpenHome.Net.Core.Action("PlaylistDeleteId");
            param = new ParameterUint("Value");
            iActionPlaylistDeleteId.AddInputParameter(param);

            iActionPlaylistsMax = new OpenHome.Net.Core.Action("PlaylistsMax");
            param = new ParameterUint("Value");
            iActionPlaylistsMax.AddOutputParameter(param);

            iActionTracksMax = new OpenHome.Net.Core.Action("TracksMax");
            param = new ParameterUint("Value");
            iActionTracksMax.AddOutputParameter(param);

            iActionPlaylistArrays = new OpenHome.Net.Core.Action("PlaylistArrays");
            param = new ParameterUint("Token");
            iActionPlaylistArrays.AddOutputParameter(param);
            param = new ParameterBinary("IdArray");
            iActionPlaylistArrays.AddOutputParameter(param);
            param = new ParameterBinary("TokenArray");
            iActionPlaylistArrays.AddOutputParameter(param);

            iActionPlaylistArraysChanged = new OpenHome.Net.Core.Action("PlaylistArraysChanged");
            param = new ParameterUint("Token");
            iActionPlaylistArraysChanged.AddInputParameter(param);
            param = new ParameterBool("Value");
            iActionPlaylistArraysChanged.AddOutputParameter(param);

            iActionRead = new OpenHome.Net.Core.Action("Read");
            param = new ParameterUint("Id");
            iActionRead.AddInputParameter(param);
            param = new ParameterUint("TrackId");
            iActionRead.AddInputParameter(param);
            param = new ParameterString("Metadata", allowedValues);
            iActionRead.AddOutputParameter(param);

            iActionReadList = new OpenHome.Net.Core.Action("ReadList");
            param = new ParameterUint("Id");
            iActionReadList.AddInputParameter(param);
            param = new ParameterString("TrackIdList", allowedValues);
            iActionReadList.AddInputParameter(param);
            param = new ParameterString("TrackList", allowedValues);
            iActionReadList.AddOutputParameter(param);

            iActionInsert = new OpenHome.Net.Core.Action("Insert");
            param = new ParameterUint("Id");
            iActionInsert.AddInputParameter(param);
            param = new ParameterUint("AfterTrackId");
            iActionInsert.AddInputParameter(param);
            param = new ParameterString("Udn", allowedValues);
            iActionInsert.AddInputParameter(param);
            param = new ParameterString("MetadataId", allowedValues);
            iActionInsert.AddInputParameter(param);
            param = new ParameterUint("NewTrackId");
            iActionInsert.AddOutputParameter(param);

            iActionDeleteId = new OpenHome.Net.Core.Action("DeleteId");
            param = new ParameterUint("TrackId");
            iActionDeleteId.AddInputParameter(param);
            param = new ParameterUint("Value");
            iActionDeleteId.AddInputParameter(param);

            iActionDeleteAll = new OpenHome.Net.Core.Action("DeleteAll");
            param = new ParameterUint("TrackId");
            iActionDeleteAll.AddInputParameter(param);

            iMetadata = new PropertyString("Metadata", MetadataPropertyChanged);
            AddProperty(iMetadata);
            iImagesXml = new PropertyString("ImagesXml", ImagesXmlPropertyChanged);
            AddProperty(iImagesXml);
            iIdArray = new PropertyBinary("IdArray", IdArrayPropertyChanged);
            AddProperty(iIdArray);
            iTokenArray = new PropertyBinary("TokenArray", TokenArrayPropertyChanged);
            AddProperty(iTokenArray);
            iPlaylistsMax = new PropertyUint("PlaylistsMax", PlaylistsMaxPropertyChanged);
            AddProperty(iPlaylistsMax);
            iTracksMax = new PropertyUint("TracksMax", TracksMaxPropertyChanged);
            AddProperty(iTracksMax);
            
            iPropertyLock = new Mutex();
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aMetadata"></param>
        public void SyncMetadata(out String aMetadata)
        {
            SyncMetadataAvOpenhomeOrgPlaylistManager1 sync = new SyncMetadataAvOpenhomeOrgPlaylistManager1(this);
            BeginMetadata(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aMetadata = sync.Metadata();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndMetadata().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginMetadata(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionMetadata, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionMetadata.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aMetadata"></param>
        public void EndMetadata(IntPtr aAsyncHandle, out String aMetadata)
        {
            if (Invocation.Error(aAsyncHandle))
            {
                throw new ProxyError();
            }
            uint index = 0;
            aMetadata = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aImagesXml"></param>
        public void SyncImagesXml(out String aImagesXml)
        {
            SyncImagesXmlAvOpenhomeOrgPlaylistManager1 sync = new SyncImagesXmlAvOpenhomeOrgPlaylistManager1(this);
            BeginImagesXml(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aImagesXml = sync.ImagesXml();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndImagesXml().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginImagesXml(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionImagesXml, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionImagesXml.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aImagesXml"></param>
        public void EndImagesXml(IntPtr aAsyncHandle, out String aImagesXml)
        {
            if (Invocation.Error(aAsyncHandle))
            {
                throw new ProxyError();
            }
            uint index = 0;
            aImagesXml = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aId"></param>
        /// <param name="aArray"></param>
        public void SyncPlaylistReadArray(uint aId, out byte[] aArray)
        {
            SyncPlaylistReadArrayAvOpenhomeOrgPlaylistManager1 sync = new SyncPlaylistReadArrayAvOpenhomeOrgPlaylistManager1(this);
            BeginPlaylistReadArray(aId, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aArray = sync.Array();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndPlaylistReadArray().</remarks>
        /// <param name="aId"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginPlaylistReadArray(uint aId, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionPlaylistReadArray, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionPlaylistReadArray.InputParameter(inIndex++), aId));
            int outIndex = 0;
            invocation.AddOutput(new ArgumentBinary((ParameterBinary)iActionPlaylistReadArray.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aArray"></param>
        public void EndPlaylistReadArray(IntPtr aAsyncHandle, out byte[] aArray)
        {
            if (Invocation.Error(aAsyncHandle))
            {
                throw new ProxyError();
            }
            uint index = 0;
            aArray = Invocation.OutputBinary(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aIdList"></param>
        /// <param name="aMetadata"></param>
        public void SyncPlaylistReadMetadata(String aIdList, out String aMetadata)
        {
            SyncPlaylistReadMetadataAvOpenhomeOrgPlaylistManager1 sync = new SyncPlaylistReadMetadataAvOpenhomeOrgPlaylistManager1(this);
            BeginPlaylistReadMetadata(aIdList, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aMetadata = sync.Metadata();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndPlaylistReadMetadata().</remarks>
        /// <param name="aIdList"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginPlaylistReadMetadata(String aIdList, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionPlaylistReadMetadata, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentString((ParameterString)iActionPlaylistReadMetadata.InputParameter(inIndex++), aIdList));
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionPlaylistReadMetadata.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aMetadata"></param>
        public void EndPlaylistReadMetadata(IntPtr aAsyncHandle, out String aMetadata)
        {
            if (Invocation.Error(aAsyncHandle))
            {
                throw new ProxyError();
            }
            uint index = 0;
            aMetadata = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aId"></param>
        /// <param name="aName"></param>
        /// <param name="aDescription"></param>
        /// <param name="aImageId"></param>
        public void SyncPlaylistRead(uint aId, out String aName, out String aDescription, out uint aImageId)
        {
            SyncPlaylistReadAvOpenhomeOrgPlaylistManager1 sync = new SyncPlaylistReadAvOpenhomeOrgPlaylistManager1(this);
            BeginPlaylistRead(aId, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aName = sync.Name();
            aDescription = sync.Description();
            aImageId = sync.ImageId();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndPlaylistRead().</remarks>
        /// <param name="aId"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginPlaylistRead(uint aId, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionPlaylistRead, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionPlaylistRead.InputParameter(inIndex++), aId));
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionPlaylistRead.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentString((ParameterString)iActionPlaylistRead.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentUint((ParameterUint)iActionPlaylistRead.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aName"></param>
        /// <param name="aDescription"></param>
        /// <param name="aImageId"></param>
        public void EndPlaylistRead(IntPtr aAsyncHandle, out String aName, out String aDescription, out uint aImageId)
        {
            if (Invocation.Error(aAsyncHandle))
            {
                throw new ProxyError();
            }
            uint index = 0;
            aName = Invocation.OutputString(aAsyncHandle, index++);
            aDescription = Invocation.OutputString(aAsyncHandle, index++);
            aImageId = Invocation.OutputUint(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aId"></param>
        /// <param name="aName"></param>
        /// <param name="aDescription"></param>
        /// <param name="aImageId"></param>
        public void SyncPlaylistUpdate(uint aId, String aName, String aDescription, uint aImageId)
        {
            SyncPlaylistUpdateAvOpenhomeOrgPlaylistManager1 sync = new SyncPlaylistUpdateAvOpenhomeOrgPlaylistManager1(this);
            BeginPlaylistUpdate(aId, aName, aDescription, aImageId, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndPlaylistUpdate().</remarks>
        /// <param name="aId"></param>
        /// <param name="aName"></param>
        /// <param name="aDescription"></param>
        /// <param name="aImageId"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginPlaylistUpdate(uint aId, String aName, String aDescription, uint aImageId, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionPlaylistUpdate, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionPlaylistUpdate.InputParameter(inIndex++), aId));
            invocation.AddInput(new ArgumentString((ParameterString)iActionPlaylistUpdate.InputParameter(inIndex++), aName));
            invocation.AddInput(new ArgumentString((ParameterString)iActionPlaylistUpdate.InputParameter(inIndex++), aDescription));
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionPlaylistUpdate.InputParameter(inIndex++), aImageId));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        public void EndPlaylistUpdate(IntPtr aAsyncHandle)
        {
            if (Invocation.Error(aAsyncHandle))
            {
                throw new ProxyError();
            }
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aAfterId"></param>
        /// <param name="aName"></param>
        /// <param name="aDescription"></param>
        /// <param name="aImageId"></param>
        /// <param name="aNewId"></param>
        public void SyncPlaylistInsert(uint aAfterId, String aName, String aDescription, uint aImageId, out uint aNewId)
        {
            SyncPlaylistInsertAvOpenhomeOrgPlaylistManager1 sync = new SyncPlaylistInsertAvOpenhomeOrgPlaylistManager1(this);
            BeginPlaylistInsert(aAfterId, aName, aDescription, aImageId, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aNewId = sync.NewId();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndPlaylistInsert().</remarks>
        /// <param name="aAfterId"></param>
        /// <param name="aName"></param>
        /// <param name="aDescription"></param>
        /// <param name="aImageId"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginPlaylistInsert(uint aAfterId, String aName, String aDescription, uint aImageId, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionPlaylistInsert, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionPlaylistInsert.InputParameter(inIndex++), aAfterId));
            invocation.AddInput(new ArgumentString((ParameterString)iActionPlaylistInsert.InputParameter(inIndex++), aName));
            invocation.AddInput(new ArgumentString((ParameterString)iActionPlaylistInsert.InputParameter(inIndex++), aDescription));
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionPlaylistInsert.InputParameter(inIndex++), aImageId));
            int outIndex = 0;
            invocation.AddOutput(new ArgumentUint((ParameterUint)iActionPlaylistInsert.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aNewId"></param>
        public void EndPlaylistInsert(IntPtr aAsyncHandle, out uint aNewId)
        {
            if (Invocation.Error(aAsyncHandle))
            {
                throw new ProxyError();
            }
            uint index = 0;
            aNewId = Invocation.OutputUint(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aValue"></param>
        public void SyncPlaylistDeleteId(uint aValue)
        {
            SyncPlaylistDeleteIdAvOpenhomeOrgPlaylistManager1 sync = new SyncPlaylistDeleteIdAvOpenhomeOrgPlaylistManager1(this);
            BeginPlaylistDeleteId(aValue, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndPlaylistDeleteId().</remarks>
        /// <param name="aValue"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginPlaylistDeleteId(uint aValue, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionPlaylistDeleteId, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionPlaylistDeleteId.InputParameter(inIndex++), aValue));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        public void EndPlaylistDeleteId(IntPtr aAsyncHandle)
        {
            if (Invocation.Error(aAsyncHandle))
            {
                throw new ProxyError();
            }
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aValue"></param>
        public void SyncPlaylistsMax(out uint aValue)
        {
            SyncPlaylistsMaxAvOpenhomeOrgPlaylistManager1 sync = new SyncPlaylistsMaxAvOpenhomeOrgPlaylistManager1(this);
            BeginPlaylistsMax(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aValue = sync.Value();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndPlaylistsMax().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginPlaylistsMax(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionPlaylistsMax, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentUint((ParameterUint)iActionPlaylistsMax.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aValue"></param>
        public void EndPlaylistsMax(IntPtr aAsyncHandle, out uint aValue)
        {
            if (Invocation.Error(aAsyncHandle))
            {
                throw new ProxyError();
            }
            uint index = 0;
            aValue = Invocation.OutputUint(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aValue"></param>
        public void SyncTracksMax(out uint aValue)
        {
            SyncTracksMaxAvOpenhomeOrgPlaylistManager1 sync = new SyncTracksMaxAvOpenhomeOrgPlaylistManager1(this);
            BeginTracksMax(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aValue = sync.Value();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndTracksMax().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginTracksMax(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionTracksMax, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentUint((ParameterUint)iActionTracksMax.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aValue"></param>
        public void EndTracksMax(IntPtr aAsyncHandle, out uint aValue)
        {
            if (Invocation.Error(aAsyncHandle))
            {
                throw new ProxyError();
            }
            uint index = 0;
            aValue = Invocation.OutputUint(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aToken"></param>
        /// <param name="aIdArray"></param>
        /// <param name="aTokenArray"></param>
        public void SyncPlaylistArrays(out uint aToken, out byte[] aIdArray, out byte[] aTokenArray)
        {
            SyncPlaylistArraysAvOpenhomeOrgPlaylistManager1 sync = new SyncPlaylistArraysAvOpenhomeOrgPlaylistManager1(this);
            BeginPlaylistArrays(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aToken = sync.Token();
            aIdArray = sync.IdArray();
            aTokenArray = sync.TokenArray();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndPlaylistArrays().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginPlaylistArrays(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionPlaylistArrays, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentUint((ParameterUint)iActionPlaylistArrays.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentBinary((ParameterBinary)iActionPlaylistArrays.OutputParameter(outIndex++)));
            invocation.AddOutput(new ArgumentBinary((ParameterBinary)iActionPlaylistArrays.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aToken"></param>
        /// <param name="aIdArray"></param>
        /// <param name="aTokenArray"></param>
        public void EndPlaylistArrays(IntPtr aAsyncHandle, out uint aToken, out byte[] aIdArray, out byte[] aTokenArray)
        {
            if (Invocation.Error(aAsyncHandle))
            {
                throw new ProxyError();
            }
            uint index = 0;
            aToken = Invocation.OutputUint(aAsyncHandle, index++);
            aIdArray = Invocation.OutputBinary(aAsyncHandle, index++);
            aTokenArray = Invocation.OutputBinary(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aToken"></param>
        /// <param name="aValue"></param>
        public void SyncPlaylistArraysChanged(uint aToken, out bool aValue)
        {
            SyncPlaylistArraysChangedAvOpenhomeOrgPlaylistManager1 sync = new SyncPlaylistArraysChangedAvOpenhomeOrgPlaylistManager1(this);
            BeginPlaylistArraysChanged(aToken, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aValue = sync.Value();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndPlaylistArraysChanged().</remarks>
        /// <param name="aToken"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginPlaylistArraysChanged(uint aToken, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionPlaylistArraysChanged, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionPlaylistArraysChanged.InputParameter(inIndex++), aToken));
            int outIndex = 0;
            invocation.AddOutput(new ArgumentBool((ParameterBool)iActionPlaylistArraysChanged.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aValue"></param>
        public void EndPlaylistArraysChanged(IntPtr aAsyncHandle, out bool aValue)
        {
            if (Invocation.Error(aAsyncHandle))
            {
                throw new ProxyError();
            }
            uint index = 0;
            aValue = Invocation.OutputBool(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aId"></param>
        /// <param name="aTrackId"></param>
        /// <param name="aMetadata"></param>
        public void SyncRead(uint aId, uint aTrackId, out String aMetadata)
        {
            SyncReadAvOpenhomeOrgPlaylistManager1 sync = new SyncReadAvOpenhomeOrgPlaylistManager1(this);
            BeginRead(aId, aTrackId, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aMetadata = sync.Metadata();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndRead().</remarks>
        /// <param name="aId"></param>
        /// <param name="aTrackId"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginRead(uint aId, uint aTrackId, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionRead, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionRead.InputParameter(inIndex++), aId));
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionRead.InputParameter(inIndex++), aTrackId));
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionRead.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aMetadata"></param>
        public void EndRead(IntPtr aAsyncHandle, out String aMetadata)
        {
            if (Invocation.Error(aAsyncHandle))
            {
                throw new ProxyError();
            }
            uint index = 0;
            aMetadata = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aId"></param>
        /// <param name="aTrackIdList"></param>
        /// <param name="aTrackList"></param>
        public void SyncReadList(uint aId, String aTrackIdList, out String aTrackList)
        {
            SyncReadListAvOpenhomeOrgPlaylistManager1 sync = new SyncReadListAvOpenhomeOrgPlaylistManager1(this);
            BeginReadList(aId, aTrackIdList, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aTrackList = sync.TrackList();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndReadList().</remarks>
        /// <param name="aId"></param>
        /// <param name="aTrackIdList"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginReadList(uint aId, String aTrackIdList, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionReadList, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionReadList.InputParameter(inIndex++), aId));
            invocation.AddInput(new ArgumentString((ParameterString)iActionReadList.InputParameter(inIndex++), aTrackIdList));
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionReadList.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aTrackList"></param>
        public void EndReadList(IntPtr aAsyncHandle, out String aTrackList)
        {
            if (Invocation.Error(aAsyncHandle))
            {
                throw new ProxyError();
            }
            uint index = 0;
            aTrackList = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aId"></param>
        /// <param name="aAfterTrackId"></param>
        /// <param name="aUdn"></param>
        /// <param name="aMetadataId"></param>
        /// <param name="aNewTrackId"></param>
        public void SyncInsert(uint aId, uint aAfterTrackId, String aUdn, String aMetadataId, out uint aNewTrackId)
        {
            SyncInsertAvOpenhomeOrgPlaylistManager1 sync = new SyncInsertAvOpenhomeOrgPlaylistManager1(this);
            BeginInsert(aId, aAfterTrackId, aUdn, aMetadataId, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aNewTrackId = sync.NewTrackId();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndInsert().</remarks>
        /// <param name="aId"></param>
        /// <param name="aAfterTrackId"></param>
        /// <param name="aUdn"></param>
        /// <param name="aMetadataId"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginInsert(uint aId, uint aAfterTrackId, String aUdn, String aMetadataId, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionInsert, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionInsert.InputParameter(inIndex++), aId));
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionInsert.InputParameter(inIndex++), aAfterTrackId));
            invocation.AddInput(new ArgumentString((ParameterString)iActionInsert.InputParameter(inIndex++), aUdn));
            invocation.AddInput(new ArgumentString((ParameterString)iActionInsert.InputParameter(inIndex++), aMetadataId));
            int outIndex = 0;
            invocation.AddOutput(new ArgumentUint((ParameterUint)iActionInsert.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aNewTrackId"></param>
        public void EndInsert(IntPtr aAsyncHandle, out uint aNewTrackId)
        {
            if (Invocation.Error(aAsyncHandle))
            {
                throw new ProxyError();
            }
            uint index = 0;
            aNewTrackId = Invocation.OutputUint(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aTrackId"></param>
        /// <param name="aValue"></param>
        public void SyncDeleteId(uint aTrackId, uint aValue)
        {
            SyncDeleteIdAvOpenhomeOrgPlaylistManager1 sync = new SyncDeleteIdAvOpenhomeOrgPlaylistManager1(this);
            BeginDeleteId(aTrackId, aValue, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndDeleteId().</remarks>
        /// <param name="aTrackId"></param>
        /// <param name="aValue"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginDeleteId(uint aTrackId, uint aValue, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionDeleteId, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionDeleteId.InputParameter(inIndex++), aTrackId));
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionDeleteId.InputParameter(inIndex++), aValue));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        public void EndDeleteId(IntPtr aAsyncHandle)
        {
            if (Invocation.Error(aAsyncHandle))
            {
                throw new ProxyError();
            }
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aTrackId"></param>
        public void SyncDeleteAll(uint aTrackId)
        {
            SyncDeleteAllAvOpenhomeOrgPlaylistManager1 sync = new SyncDeleteAllAvOpenhomeOrgPlaylistManager1(this);
            BeginDeleteAll(aTrackId, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndDeleteAll().</remarks>
        /// <param name="aTrackId"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginDeleteAll(uint aTrackId, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionDeleteAll, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionDeleteAll.InputParameter(inIndex++), aTrackId));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        public void EndDeleteAll(IntPtr aAsyncHandle)
        {
            if (Invocation.Error(aAsyncHandle))
            {
                throw new ProxyError();
            }
        }

        /// <summary>
        /// Set a delegate to be run when the Metadata state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyAvOpenhomeOrgPlaylistManager1 instance will not overlap.</remarks>
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
        /// Set a delegate to be run when the ImagesXml state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyAvOpenhomeOrgPlaylistManager1 instance will not overlap.</remarks>
        /// <param name="aImagesXmlChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyImagesXmlChanged(System.Action aImagesXmlChanged)
        {
            lock (iPropertyLock)
            {
                iImagesXmlChanged = aImagesXmlChanged;
            }
        }

        private void ImagesXmlPropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iImagesXmlChanged);
            }
        }

        /// <summary>
        /// Set a delegate to be run when the IdArray state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyAvOpenhomeOrgPlaylistManager1 instance will not overlap.</remarks>
        /// <param name="aIdArrayChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyIdArrayChanged(System.Action aIdArrayChanged)
        {
            lock (iPropertyLock)
            {
                iIdArrayChanged = aIdArrayChanged;
            }
        }

        private void IdArrayPropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iIdArrayChanged);
            }
        }

        /// <summary>
        /// Set a delegate to be run when the TokenArray state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyAvOpenhomeOrgPlaylistManager1 instance will not overlap.</remarks>
        /// <param name="aTokenArrayChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyTokenArrayChanged(System.Action aTokenArrayChanged)
        {
            lock (iPropertyLock)
            {
                iTokenArrayChanged = aTokenArrayChanged;
            }
        }

        private void TokenArrayPropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iTokenArrayChanged);
            }
        }

        /// <summary>
        /// Set a delegate to be run when the PlaylistsMax state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyAvOpenhomeOrgPlaylistManager1 instance will not overlap.</remarks>
        /// <param name="aPlaylistsMaxChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyPlaylistsMaxChanged(System.Action aPlaylistsMaxChanged)
        {
            lock (iPropertyLock)
            {
                iPlaylistsMaxChanged = aPlaylistsMaxChanged;
            }
        }

        private void PlaylistsMaxPropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iPlaylistsMaxChanged);
            }
        }

        /// <summary>
        /// Set a delegate to be run when the TracksMax state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyAvOpenhomeOrgPlaylistManager1 instance will not overlap.</remarks>
        /// <param name="aTracksMaxChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyTracksMaxChanged(System.Action aTracksMaxChanged)
        {
            lock (iPropertyLock)
            {
                iTracksMaxChanged = aTracksMaxChanged;
            }
        }

        private void TracksMaxPropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iTracksMaxChanged);
            }
        }

        /// <summary>
        /// Query the value of the Metadata property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <returns>Value of the Metadata property</returns>
        public String PropertyMetadata()
        {
            PropertyReadLock();
            String val = iMetadata.Value();
            PropertyReadUnlock();
            return val;
        }

        /// <summary>
        /// Query the value of the ImagesXml property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <returns>Value of the ImagesXml property</returns>
        public String PropertyImagesXml()
        {
            PropertyReadLock();
            String val = iImagesXml.Value();
            PropertyReadUnlock();
            return val;
        }

        /// <summary>
        /// Query the value of the IdArray property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <returns>Value of the IdArray property</returns>
        public byte[] PropertyIdArray()
        {
            PropertyReadLock();
            byte[] val = iIdArray.Value();
            PropertyReadUnlock();
            return val;
        }

        /// <summary>
        /// Query the value of the TokenArray property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <returns>Value of the TokenArray property</returns>
        public byte[] PropertyTokenArray()
        {
            PropertyReadLock();
            byte[] val = iTokenArray.Value();
            PropertyReadUnlock();
            return val;
        }

        /// <summary>
        /// Query the value of the PlaylistsMax property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <returns>Value of the PlaylistsMax property</returns>
        public uint PropertyPlaylistsMax()
        {
            PropertyReadLock();
            uint val = iPlaylistsMax.Value();
            PropertyReadUnlock();
            return val;
        }

        /// <summary>
        /// Query the value of the TracksMax property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <returns>Value of the TracksMax property</returns>
        public uint PropertyTracksMax()
        {
            PropertyReadLock();
            uint val = iTracksMax.Value();
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

        ~CpProxyAvOpenhomeOrgPlaylistManager1()
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
                iActionMetadata.Dispose();
                iActionImagesXml.Dispose();
                iActionPlaylistReadArray.Dispose();
                iActionPlaylistReadMetadata.Dispose();
                iActionPlaylistRead.Dispose();
                iActionPlaylistUpdate.Dispose();
                iActionPlaylistInsert.Dispose();
                iActionPlaylistDeleteId.Dispose();
                iActionPlaylistsMax.Dispose();
                iActionTracksMax.Dispose();
                iActionPlaylistArrays.Dispose();
                iActionPlaylistArraysChanged.Dispose();
                iActionRead.Dispose();
                iActionReadList.Dispose();
                iActionInsert.Dispose();
                iActionDeleteId.Dispose();
                iActionDeleteAll.Dispose();
                iMetadata.Dispose();
                iImagesXml.Dispose();
                iIdArray.Dispose();
                iTokenArray.Dispose();
                iPlaylistsMax.Dispose();
                iTracksMax.Dispose();
            }
            if (aDisposing)
            {
                GC.SuppressFinalize(this);
            }
        }
    }
}

