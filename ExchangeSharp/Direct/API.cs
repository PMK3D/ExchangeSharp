using System;
using System.Runtime.InteropServices;

namespace TS3D.Exchange.Direct
{
    public class API
    {
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DVector2dData(ref A3DVector2dData s);
        public static bool Initialize(out A3DVector2dData s)
        {
            s = new A3DVector2dData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DVector2dData));
            return InitializeA3DVector2dData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DVector3dData(ref A3DVector3dData s);
        public static bool Initialize(out A3DVector3dData s)
        {
            s = new A3DVector3dData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DVector3dData));
            return InitializeA3DVector3dData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DIntervalData(ref A3DIntervalData s);
        public static bool Initialize(out A3DIntervalData s)
        {
            s = new A3DIntervalData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DIntervalData));
            return InitializeA3DIntervalData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DDomainData(ref A3DDomainData s);
        public static bool Initialize(out A3DDomainData s)
        {
            s = new A3DDomainData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDomainData));
            return InitializeA3DDomainData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DBoundingBoxData(ref A3DBoundingBoxData s);
        public static bool Initialize(out A3DBoundingBoxData s)
        {
            s = new A3DBoundingBoxData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DBoundingBoxData));
            return InitializeA3DBoundingBoxData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DParameterizationData(ref A3DParameterizationData s);
        public static bool Initialize(out A3DParameterizationData s)
        {
            s = new A3DParameterizationData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DParameterizationData));
            return InitializeA3DParameterizationData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DUVParameterizationData(ref A3DUVParameterizationData s);
        public static bool Initialize(out A3DUVParameterizationData s)
        {
            s = new A3DUVParameterizationData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DUVParameterizationData));
            return InitializeA3DUVParameterizationData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DTessBaseData(ref A3DTessBaseData s);
        public static bool Initialize(out A3DTessBaseData s)
        {
            s = new A3DTessBaseData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTessBaseData));
            return InitializeA3DTessBaseData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DTessFaceData(ref A3DTessFaceData s);
        public static bool Initialize(out A3DTessFaceData s)
        {
            s = new A3DTessFaceData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTessFaceData));
            return InitializeA3DTessFaceData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DTess3DData(ref A3DTess3DData s);
        public static bool Initialize(out A3DTess3DData s)
        {
            s = new A3DTess3DData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTess3DData));
            return InitializeA3DTess3DData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DTess3DWireData(ref A3DTess3DWireData s);
        public static bool Initialize(out A3DTess3DWireData s)
        {
            s = new A3DTess3DWireData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTess3DWireData));
            return InitializeA3DTess3DWireData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DTessMarkupData(ref A3DTessMarkupData s);
        public static bool Initialize(out A3DTessMarkupData s)
        {
            s = new A3DTessMarkupData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTessMarkupData));
            return InitializeA3DTessMarkupData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DGraphicsData(ref A3DGraphicsData s);
        public static bool Initialize(out A3DGraphicsData s)
        {
            s = new A3DGraphicsData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphicsData));
            return InitializeA3DGraphicsData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DGraphStyleData(ref A3DGraphStyleData s);
        public static bool Initialize(out A3DGraphStyleData s)
        {
            s = new A3DGraphStyleData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphStyleData));
            return InitializeA3DGraphStyleData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DGraphRgbColorData(ref A3DGraphRgbColorData s);
        public static bool Initialize(out A3DGraphRgbColorData s)
        {
            s = new A3DGraphRgbColorData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphRgbColorData));
            return InitializeA3DGraphRgbColorData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DGraphLinePatternData(ref A3DGraphLinePatternData s);
        public static bool Initialize(out A3DGraphLinePatternData s)
        {
            s = new A3DGraphLinePatternData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphLinePatternData));
            return InitializeA3DGraphLinePatternData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DGraphMaterialData(ref A3DGraphMaterialData s);
        public static bool Initialize(out A3DGraphMaterialData s)
        {
            s = new A3DGraphMaterialData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphMaterialData));
            return InitializeA3DGraphMaterialData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DGraphPictureData(ref A3DGraphPictureData s);
        public static bool Initialize(out A3DGraphPictureData s)
        {
            s = new A3DGraphPictureData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphPictureData));
            return InitializeA3DGraphPictureData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DGraphDottingPatternData(ref A3DGraphDottingPatternData s);
        public static bool Initialize(out A3DGraphDottingPatternData s)
        {
            s = new A3DGraphDottingPatternData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphDottingPatternData));
            return InitializeA3DGraphDottingPatternData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DGraphHatchingPatternLineData(ref A3DGraphHatchingPatternLineData s);
        public static bool Initialize(out A3DGraphHatchingPatternLineData s)
        {
            s = new A3DGraphHatchingPatternLineData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphHatchingPatternLineData));
            return InitializeA3DGraphHatchingPatternLineData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DGraphHatchingPatternData(ref A3DGraphHatchingPatternData s);
        public static bool Initialize(out A3DGraphHatchingPatternData s)
        {
            s = new A3DGraphHatchingPatternData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphHatchingPatternData));
            return InitializeA3DGraphHatchingPatternData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DGraphSolidPatternData(ref A3DGraphSolidPatternData s);
        public static bool Initialize(out A3DGraphSolidPatternData s)
        {
            s = new A3DGraphSolidPatternData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphSolidPatternData));
            return InitializeA3DGraphSolidPatternData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DGraphVPicturePatternData(ref A3DGraphVPicturePatternData s);
        public static bool Initialize(out A3DGraphVPicturePatternData s)
        {
            s = new A3DGraphVPicturePatternData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphVPicturePatternData));
            return InitializeA3DGraphVPicturePatternData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DGraphCameraData(ref A3DGraphCameraData s);
        public static bool Initialize(out A3DGraphCameraData s)
        {
            s = new A3DGraphCameraData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphCameraData));
            return InitializeA3DGraphCameraData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DGraphAmbientLightData(ref A3DGraphAmbientLightData s);
        public static bool Initialize(out A3DGraphAmbientLightData s)
        {
            s = new A3DGraphAmbientLightData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphAmbientLightData));
            return InitializeA3DGraphAmbientLightData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DGraphPointLightData(ref A3DGraphPointLightData s);
        public static bool Initialize(out A3DGraphPointLightData s)
        {
            s = new A3DGraphPointLightData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphPointLightData));
            return InitializeA3DGraphPointLightData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DGraphSpotLightData(ref A3DGraphSpotLightData s);
        public static bool Initialize(out A3DGraphSpotLightData s)
        {
            s = new A3DGraphSpotLightData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphSpotLightData));
            return InitializeA3DGraphSpotLightData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DGraphDirectionalLightData(ref A3DGraphDirectionalLightData s);
        public static bool Initialize(out A3DGraphDirectionalLightData s)
        {
            s = new A3DGraphDirectionalLightData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphDirectionalLightData));
            return InitializeA3DGraphDirectionalLightData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DGraphSceneDisplayParametersData(ref A3DGraphSceneDisplayParametersData s);
        public static bool Initialize(out A3DGraphSceneDisplayParametersData s)
        {
            s = new A3DGraphSceneDisplayParametersData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphSceneDisplayParametersData));
            return InitializeA3DGraphSceneDisplayParametersData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMiscCascadedAttributesData(ref A3DMiscCascadedAttributesData s);
        public static bool Initialize(out A3DMiscCascadedAttributesData s)
        {
            s = new A3DMiscCascadedAttributesData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscCascadedAttributesData));
            return InitializeA3DMiscCascadedAttributesData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMiscGeneralTransformationData(ref A3DMiscGeneralTransformationData s);
        public static bool Initialize(out A3DMiscGeneralTransformationData s)
        {
            s = new A3DMiscGeneralTransformationData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscGeneralTransformationData));
            return InitializeA3DMiscGeneralTransformationData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMiscCartesianTransformationData(ref A3DMiscCartesianTransformationData s);
        public static bool Initialize(out A3DMiscCartesianTransformationData s)
        {
            s = new A3DMiscCartesianTransformationData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscCartesianTransformationData));
            return InitializeA3DMiscCartesianTransformationData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMiscEntityReferenceData(ref A3DMiscEntityReferenceData s);
        public static bool Initialize(out A3DMiscEntityReferenceData s)
        {
            s = new A3DMiscEntityReferenceData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscEntityReferenceData));
            return InitializeA3DMiscEntityReferenceData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMiscReferenceOnTopologyData(ref A3DMiscReferenceOnTopologyData s);
        public static bool Initialize(out A3DMiscReferenceOnTopologyData s)
        {
            s = new A3DMiscReferenceOnTopologyData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscReferenceOnTopologyData));
            return InitializeA3DMiscReferenceOnTopologyData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMiscReferenceOnTessData(ref A3DMiscReferenceOnTessData s);
        public static bool Initialize(out A3DMiscReferenceOnTessData s)
        {
            s = new A3DMiscReferenceOnTessData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscReferenceOnTessData));
            return InitializeA3DMiscReferenceOnTessData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMiscReferenceOnCsysItemData(ref A3DMiscReferenceOnCsysItemData s);
        public static bool Initialize(out A3DMiscReferenceOnCsysItemData s)
        {
            s = new A3DMiscReferenceOnCsysItemData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscReferenceOnCsysItemData));
            return InitializeA3DMiscReferenceOnCsysItemData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMiscPhysicMaterialData(ref A3DMiscPhysicMaterialData s);
        public static bool Initialize(out A3DMiscPhysicMaterialData s)
        {
            s = new A3DMiscPhysicMaterialData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscPhysicMaterialData));
            return InitializeA3DMiscPhysicMaterialData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMiscMaterialFiberData(ref A3DMiscMaterialFiberData s);
        public static bool Initialize(out A3DMiscMaterialFiberData s)
        {
            s = new A3DMiscMaterialFiberData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscMaterialFiberData));
            return InitializeA3DMiscMaterialFiberData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMiscMaterialHoneyCombData(ref A3DMiscMaterialHoneyCombData s);
        public static bool Initialize(out A3DMiscMaterialHoneyCombData s)
        {
            s = new A3DMiscMaterialHoneyCombData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscMaterialHoneyCombData));
            return InitializeA3DMiscMaterialHoneyCombData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMiscMaterialIsotropicData(ref A3DMiscMaterialIsotropicData s);
        public static bool Initialize(out A3DMiscMaterialIsotropicData s)
        {
            s = new A3DMiscMaterialIsotropicData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscMaterialIsotropicData));
            return InitializeA3DMiscMaterialIsotropicData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMiscMaterialOrthotropic2DData(ref A3DMiscMaterialOrthotropic2DData s);
        public static bool Initialize(out A3DMiscMaterialOrthotropic2DData s)
        {
            s = new A3DMiscMaterialOrthotropic2DData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscMaterialOrthotropic2DData));
            return InitializeA3DMiscMaterialOrthotropic2DData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMiscMaterialOrthotropic3DData(ref A3DMiscMaterialOrthotropic3DData s);
        public static bool Initialize(out A3DMiscMaterialOrthotropic3DData s)
        {
            s = new A3DMiscMaterialOrthotropic3DData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscMaterialOrthotropic3DData));
            return InitializeA3DMiscMaterialOrthotropic3DData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMiscMaterialAnisotropicData(ref A3DMiscMaterialAnisotropicData s);
        public static bool Initialize(out A3DMiscMaterialAnisotropicData s)
        {
            s = new A3DMiscMaterialAnisotropicData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscMaterialAnisotropicData));
            return InitializeA3DMiscMaterialAnisotropicData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMiscMaterialPropertiesData(ref A3DMiscMaterialPropertiesData s);
        public static bool Initialize(out A3DMiscMaterialPropertiesData s)
        {
            s = new A3DMiscMaterialPropertiesData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscMaterialPropertiesData));
            return InitializeA3DMiscMaterialPropertiesData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DAsmModelFileData(ref A3DAsmModelFileData s);
        public static bool Initialize(out A3DAsmModelFileData s)
        {
            s = new A3DAsmModelFileData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmModelFileData));
            return InitializeA3DAsmModelFileData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DAsmProductOccurrenceData(ref A3DAsmProductOccurrenceData s);
        public static bool Initialize(out A3DAsmProductOccurrenceData s)
        {
            s = new A3DAsmProductOccurrenceData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmProductOccurrenceData));
            return InitializeA3DAsmProductOccurrenceData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DAsmProductOccurrenceDataSLW(ref A3DAsmProductOccurrenceDataSLW s);
        public static bool Initialize(out A3DAsmProductOccurrenceDataSLW s)
        {
            s = new A3DAsmProductOccurrenceDataSLW();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmProductOccurrenceDataSLW));
            return InitializeA3DAsmProductOccurrenceDataSLW(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DAsmProductOccurrenceDataCat(ref A3DAsmProductOccurrenceDataCat s);
        public static bool Initialize(out A3DAsmProductOccurrenceDataCat s)
        {
            s = new A3DAsmProductOccurrenceDataCat();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmProductOccurrenceDataCat));
            return InitializeA3DAsmProductOccurrenceDataCat(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DAsmProductOccurrenceDataCV5(ref A3DAsmProductOccurrenceDataCV5 s);
        public static bool Initialize(out A3DAsmProductOccurrenceDataCV5 s)
        {
            s = new A3DAsmProductOccurrenceDataCV5();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmProductOccurrenceDataCV5));
            return InitializeA3DAsmProductOccurrenceDataCV5(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DAsmProductOccurrenceDataUg(ref A3DAsmProductOccurrenceDataUg s);
        public static bool Initialize(out A3DAsmProductOccurrenceDataUg s)
        {
            s = new A3DAsmProductOccurrenceDataUg();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmProductOccurrenceDataUg));
            return InitializeA3DAsmProductOccurrenceDataUg(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DAsmProductOccurrenceDataProe(ref A3DAsmProductOccurrenceDataProe s);
        public static bool Initialize(out A3DAsmProductOccurrenceDataProe s)
        {
            s = new A3DAsmProductOccurrenceDataProe();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmProductOccurrenceDataProe));
            return InitializeA3DAsmProductOccurrenceDataProe(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DAsmProductOccurrenceDataInv(ref A3DAsmProductOccurrenceDataInv s);
        public static bool Initialize(out A3DAsmProductOccurrenceDataInv s)
        {
            s = new A3DAsmProductOccurrenceDataInv();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmProductOccurrenceDataInv));
            return InitializeA3DAsmProductOccurrenceDataInv(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DAsmProductOccurrenceDataJT(ref A3DAsmProductOccurrenceDataJT s);
        public static bool Initialize(out A3DAsmProductOccurrenceDataJT s)
        {
            s = new A3DAsmProductOccurrenceDataJT();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmProductOccurrenceDataJT));
            return InitializeA3DAsmProductOccurrenceDataJT(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DAsmPartDefinitionData(ref A3DAsmPartDefinitionData s);
        public static bool Initialize(out A3DAsmPartDefinitionData s)
        {
            s = new A3DAsmPartDefinitionData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmPartDefinitionData));
            return InitializeA3DAsmPartDefinitionData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DAsmLayerFilterItemData(ref A3DAsmLayerFilterItemData s);
        public static bool Initialize(out A3DAsmLayerFilterItemData s)
        {
            s = new A3DAsmLayerFilterItemData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmLayerFilterItemData));
            return InitializeA3DAsmLayerFilterItemData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DAsmEntityFilterItemData(ref A3DAsmEntityFilterItemData s);
        public static bool Initialize(out A3DAsmEntityFilterItemData s)
        {
            s = new A3DAsmEntityFilterItemData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmEntityFilterItemData));
            return InitializeA3DAsmEntityFilterItemData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DAsmFilterData(ref A3DAsmFilterData s);
        public static bool Initialize(out A3DAsmFilterData s)
        {
            s = new A3DAsmFilterData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmFilterData));
            return InitializeA3DAsmFilterData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsGeneralData(ref A3DRWParamsGeneralData s);
        public static bool Initialize(out A3DRWParamsGeneralData s)
        {
            s = new A3DRWParamsGeneralData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsGeneralData));
            return InitializeA3DRWParamsGeneralData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsPmiData(ref A3DRWParamsPmiData s);
        public static bool Initialize(out A3DRWParamsPmiData s)
        {
            s = new A3DRWParamsPmiData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsPmiData));
            return InitializeA3DRWParamsPmiData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsTessellationData(ref A3DRWParamsTessellationData s);
        public static bool Initialize(out A3DRWParamsTessellationData s)
        {
            s = new A3DRWParamsTessellationData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsTessellationData));
            return InitializeA3DRWParamsTessellationData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsSearchDirData(ref A3DRWParamsSearchDirData s);
        public static bool Initialize(out A3DRWParamsSearchDirData s)
        {
            s = new A3DRWParamsSearchDirData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsSearchDirData));
            return InitializeA3DRWParamsSearchDirData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsAssemblyData(ref A3DRWParamsAssemblyData s);
        public static bool Initialize(out A3DRWParamsAssemblyData s)
        {
            s = new A3DRWParamsAssemblyData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsAssemblyData));
            return InitializeA3DRWParamsAssemblyData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsMultiEntriesData(ref A3DRWParamsMultiEntriesData s);
        public static bool Initialize(out A3DRWParamsMultiEntriesData s)
        {
            s = new A3DRWParamsMultiEntriesData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsMultiEntriesData));
            return InitializeA3DRWParamsMultiEntriesData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsCatiaV4Data(ref A3DRWParamsCatiaV4Data s);
        public static bool Initialize(out A3DRWParamsCatiaV4Data s)
        {
            s = new A3DRWParamsCatiaV4Data();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsCatiaV4Data));
            return InitializeA3DRWParamsCatiaV4Data(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsCatiaV5Data(ref A3DRWParamsCatiaV5Data s);
        public static bool Initialize(out A3DRWParamsCatiaV5Data s)
        {
            s = new A3DRWParamsCatiaV5Data();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsCatiaV5Data));
            return InitializeA3DRWParamsCatiaV5Data(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsUnigraphicsData(ref A3DRWParamsUnigraphicsData s);
        public static bool Initialize(out A3DRWParamsUnigraphicsData s)
        {
            s = new A3DRWParamsUnigraphicsData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsUnigraphicsData));
            return InitializeA3DRWParamsUnigraphicsData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsProEData(ref A3DRWParamsProEData s);
        public static bool Initialize(out A3DRWParamsProEData s)
        {
            s = new A3DRWParamsProEData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsProEData));
            return InitializeA3DRWParamsProEData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWValidationPropertiesThresholdData(ref A3DRWValidationPropertiesThresholdData s);
        public static bool Initialize(out A3DRWValidationPropertiesThresholdData s)
        {
            s = new A3DRWValidationPropertiesThresholdData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWValidationPropertiesThresholdData));
            return InitializeA3DRWValidationPropertiesThresholdData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsStepData(ref A3DRWParamsStepData s);
        public static bool Initialize(out A3DRWParamsStepData s)
        {
            s = new A3DRWParamsStepData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsStepData));
            return InitializeA3DRWParamsStepData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsIGESData(ref A3DRWParamsIGESData s);
        public static bool Initialize(out A3DRWParamsIGESData s)
        {
            s = new A3DRWParamsIGESData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsIGESData));
            return InitializeA3DRWParamsIGESData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsIFCData(ref A3DRWParamsIFCData s);
        public static bool Initialize(out A3DRWParamsIFCData s)
        {
            s = new A3DRWParamsIFCData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsIFCData));
            return InitializeA3DRWParamsIFCData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsJTData(ref A3DRWParamsJTData s);
        public static bool Initialize(out A3DRWParamsJTData s)
        {
            s = new A3DRWParamsJTData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsJTData));
            return InitializeA3DRWParamsJTData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsParasolidData(ref A3DRWParamsParasolidData s);
        public static bool Initialize(out A3DRWParamsParasolidData s)
        {
            s = new A3DRWParamsParasolidData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsParasolidData));
            return InitializeA3DRWParamsParasolidData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsSolidworksData(ref A3DRWParamsSolidworksData s);
        public static bool Initialize(out A3DRWParamsSolidworksData s)
        {
            s = new A3DRWParamsSolidworksData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsSolidworksData));
            return InitializeA3DRWParamsSolidworksData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsInventorData(ref A3DRWParamsInventorData s);
        public static bool Initialize(out A3DRWParamsInventorData s)
        {
            s = new A3DRWParamsInventorData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsInventorData));
            return InitializeA3DRWParamsInventorData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsRhinoData(ref A3DRWParamsRhinoData s);
        public static bool Initialize(out A3DRWParamsRhinoData s)
        {
            s = new A3DRWParamsRhinoData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsRhinoData));
            return InitializeA3DRWParamsRhinoData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsRevitData(ref A3DRWParamsRevitData s);
        public static bool Initialize(out A3DRWParamsRevitData s)
        {
            s = new A3DRWParamsRevitData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsRevitData));
            return InitializeA3DRWParamsRevitData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsSpecificLoadData(ref A3DRWParamsSpecificLoadData s);
        public static bool Initialize(out A3DRWParamsSpecificLoadData s)
        {
            s = new A3DRWParamsSpecificLoadData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsSpecificLoadData));
            return InitializeA3DRWParamsSpecificLoadData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsIncrementalLoadData(ref A3DRWParamsIncrementalLoadData s);
        public static bool Initialize(out A3DRWParamsIncrementalLoadData s)
        {
            s = new A3DRWParamsIncrementalLoadData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsIncrementalLoadData));
            return InitializeA3DRWParamsIncrementalLoadData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsLoadData(ref A3DRWParamsLoadData s);
        public static bool Initialize(out A3DRWParamsLoadData s)
        {
            s = new A3DRWParamsLoadData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsLoadData));
            return InitializeA3DRWParamsLoadData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DStream3DPDFData(ref A3DStream3DPDFData s);
        public static bool Initialize(out A3DStream3DPDFData s)
        {
            s = new A3DStream3DPDFData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DStream3DPDFData));
            return InitializeA3DStream3DPDFData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsExportPrcData(ref A3DRWParamsExportPrcData s);
        public static bool Initialize(out A3DRWParamsExportPrcData s)
        {
            s = new A3DRWParamsExportPrcData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportPrcData));
            return InitializeA3DRWParamsExportPrcData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsExportU3DData(ref A3DRWParamsExportU3DData s);
        public static bool Initialize(out A3DRWParamsExportU3DData s)
        {
            s = new A3DRWParamsExportU3DData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportU3DData));
            return InitializeA3DRWParamsExportU3DData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsExportStepData(ref A3DRWParamsExportStepData s);
        public static bool Initialize(out A3DRWParamsExportStepData s)
        {
            s = new A3DRWParamsExportStepData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportStepData));
            return InitializeA3DRWParamsExportStepData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsExportJTData(ref A3DRWParamsExportJTData s);
        public static bool Initialize(out A3DRWParamsExportJTData s)
        {
            s = new A3DRWParamsExportJTData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportJTData));
            return InitializeA3DRWParamsExportJTData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsExportIgesData(ref A3DRWParamsExportIgesData s);
        public static bool Initialize(out A3DRWParamsExportIgesData s)
        {
            s = new A3DRWParamsExportIgesData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportIgesData));
            return InitializeA3DRWParamsExportIgesData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsExportStlData(ref A3DRWParamsExportStlData s);
        public static bool Initialize(out A3DRWParamsExportStlData s)
        {
            s = new A3DRWParamsExportStlData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportStlData));
            return InitializeA3DRWParamsExportStlData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsExport3mfData(ref A3DRWParamsExport3mfData s);
        public static bool Initialize(out A3DRWParamsExport3mfData s)
        {
            s = new A3DRWParamsExport3mfData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExport3mfData));
            return InitializeA3DRWParamsExport3mfData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsExportXMLData(ref A3DRWParamsExportXMLData s);
        public static bool Initialize(out A3DRWParamsExportXMLData s)
        {
            s = new A3DRWParamsExportXMLData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportXMLData));
            return InitializeA3DRWParamsExportXMLData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsExportObjData(ref A3DRWParamsExportObjData s);
        public static bool Initialize(out A3DRWParamsExportObjData s)
        {
            s = new A3DRWParamsExportObjData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportObjData));
            return InitializeA3DRWParamsExportObjData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsExportFbxData(ref A3DRWParamsExportFbxData s);
        public static bool Initialize(out A3DRWParamsExportFbxData s)
        {
            s = new A3DRWParamsExportFbxData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportFbxData));
            return InitializeA3DRWParamsExportFbxData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DSewOptionsData(ref A3DSewOptionsData s);
        public static bool Initialize(out A3DSewOptionsData s)
        {
            s = new A3DSewOptionsData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSewOptionsData));
            return InitializeA3DSewOptionsData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DFaceUVPointInsideManagerData(ref A3DFaceUVPointInsideManagerData s);
        public static bool Initialize(out A3DFaceUVPointInsideManagerData s)
        {
            s = new A3DFaceUVPointInsideManagerData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFaceUVPointInsideManagerData));
            return InitializeA3DFaceUVPointInsideManagerData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DProjectedPointCloudData(ref A3DProjectedPointCloudData s);
        public static bool Initialize(out A3DProjectedPointCloudData s)
        {
            s = new A3DProjectedPointCloudData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DProjectedPointCloudData));
            return InitializeA3DProjectedPointCloudData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DProjectPointCloudManagerDataFromRI(ref A3DProjectPointCloudManagerDataFromRI s);
        public static bool Initialize(out A3DProjectPointCloudManagerDataFromRI s)
        {
            s = new A3DProjectPointCloudManagerDataFromRI();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DProjectPointCloudManagerDataFromRI));
            return InitializeA3DProjectPointCloudManagerDataFromRI(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DPlanarSectionData(ref A3DPlanarSectionData s);
        public static bool Initialize(out A3DPlanarSectionData s)
        {
            s = new A3DPlanarSectionData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DPlanarSectionData));
            return InitializeA3DPlanarSectionData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCompareInputData(ref A3DCompareInputData s);
        public static bool Initialize(out A3DCompareInputData s)
        {
            s = new A3DCompareInputData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCompareInputData));
            return InitializeA3DCompareInputData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCompareOutputData(ref A3DCompareOutputData s);
        public static bool Initialize(out A3DCompareOutputData s)
        {
            s = new A3DCompareOutputData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCompareOutputData));
            return InitializeA3DCompareOutputData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMultiPlanarSectionData(ref A3DMultiPlanarSectionData s);
        public static bool Initialize(out A3DMultiPlanarSectionData s)
        {
            s = new A3DMultiPlanarSectionData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMultiPlanarSectionData));
            return InitializeA3DMultiPlanarSectionData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DHLRViewPlaneData(ref A3DHLRViewPlaneData s);
        public static bool Initialize(out A3DHLRViewPlaneData s)
        {
            s = new A3DHLRViewPlaneData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DHLRViewPlaneData));
            return InitializeA3DHLRViewPlaneData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DHLRCurveData(ref A3DHLRCurveData s);
        public static bool Initialize(out A3DHLRCurveData s)
        {
            s = new A3DHLRCurveData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DHLRCurveData));
            return InitializeA3DHLRCurveData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DHLRSectionFaceData(ref A3DHLRSectionFaceData s);
        public static bool Initialize(out A3DHLRSectionFaceData s)
        {
            s = new A3DHLRSectionFaceData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DHLRSectionFaceData));
            return InitializeA3DHLRSectionFaceData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DHLRRepresentationItemData(ref A3DHLRRepresentationItemData s);
        public static bool Initialize(out A3DHLRRepresentationItemData s)
        {
            s = new A3DHLRRepresentationItemData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DHLRRepresentationItemData));
            return InitializeA3DHLRRepresentationItemData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DHLROptionsData(ref A3DHLROptionsData s);
        public static bool Initialize(out A3DHLROptionsData s)
        {
            s = new A3DHLROptionsData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DHLROptionsData));
            return InitializeA3DHLROptionsData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DTransfoRepresentationItemData(ref A3DTransfoRepresentationItemData s);
        public static bool Initialize(out A3DTransfoRepresentationItemData s)
        {
            s = new A3DTransfoRepresentationItemData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTransfoRepresentationItemData));
            return InitializeA3DTransfoRepresentationItemData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCollisionGroupData(ref A3DCollisionGroupData s);
        public static bool Initialize(out A3DCollisionGroupData s)
        {
            s = new A3DCollisionGroupData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCollisionGroupData));
            return InitializeA3DCollisionGroupData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCollisionParameterData(ref A3DCollisionParameterData s);
        public static bool Initialize(out A3DCollisionParameterData s)
        {
            s = new A3DCollisionParameterData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCollisionParameterData));
            return InitializeA3DCollisionParameterData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCollisionResultData(ref A3DCollisionResultData s);
        public static bool Initialize(out A3DCollisionResultData s)
        {
            s = new A3DCollisionResultData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCollisionResultData));
            return InitializeA3DCollisionResultData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMkpLeaderData(ref A3DMkpLeaderData s);
        public static bool Initialize(out A3DMkpLeaderData s)
        {
            s = new A3DMkpLeaderData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMkpLeaderData));
            return InitializeA3DMkpLeaderData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMkpAnnotationItemData(ref A3DMkpAnnotationItemData s);
        public static bool Initialize(out A3DMkpAnnotationItemData s)
        {
            s = new A3DMkpAnnotationItemData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMkpAnnotationItemData));
            return InitializeA3DMkpAnnotationItemData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMkpAnnotationSetData(ref A3DMkpAnnotationSetData s);
        public static bool Initialize(out A3DMkpAnnotationSetData s)
        {
            s = new A3DMkpAnnotationSetData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMkpAnnotationSetData));
            return InitializeA3DMkpAnnotationSetData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMkpAnnotationReferenceData(ref A3DMkpAnnotationReferenceData s);
        public static bool Initialize(out A3DMkpAnnotationReferenceData s)
        {
            s = new A3DMkpAnnotationReferenceData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMkpAnnotationReferenceData));
            return InitializeA3DMkpAnnotationReferenceData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMkpViewData(ref A3DMkpViewData s);
        public static bool Initialize(out A3DMkpViewData s)
        {
            s = new A3DMkpViewData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMkpViewData));
            return InitializeA3DMkpViewData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMkpViewFlagsData(ref A3DMkpViewFlagsData s);
        public static bool Initialize(out A3DMkpViewFlagsData s)
        {
            s = new A3DMkpViewFlagsData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMkpViewFlagsData));
            return InitializeA3DMkpViewFlagsData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMiscMarkupLinkedItemData(ref A3DMiscMarkupLinkedItemData s);
        public static bool Initialize(out A3DMiscMarkupLinkedItemData s)
        {
            s = new A3DMiscMarkupLinkedItemData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscMarkupLinkedItemData));
            return InitializeA3DMiscMarkupLinkedItemData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMkpMarkupData(ref A3DMkpMarkupData s);
        public static bool Initialize(out A3DMkpMarkupData s)
        {
            s = new A3DMkpMarkupData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMkpMarkupData));
            return InitializeA3DMkpMarkupData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMkpRTFFieldData(ref A3DMkpRTFFieldData s);
        public static bool Initialize(out A3DMkpRTFFieldData s)
        {
            s = new A3DMkpRTFFieldData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMkpRTFFieldData));
            return InitializeA3DMkpRTFFieldData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DFontKeyData(ref A3DFontKeyData s);
        public static bool Initialize(out A3DFontKeyData s)
        {
            s = new A3DFontKeyData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFontKeyData));
            return InitializeA3DFontKeyData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DFontData(ref A3DFontData s);
        public static bool Initialize(out A3DFontData s)
        {
            s = new A3DFontData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFontData));
            return InitializeA3DFontData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DGraphTextureTransformationData(ref A3DGraphTextureTransformationData s);
        public static bool Initialize(out A3DGraphTextureTransformationData s)
        {
            s = new A3DGraphTextureTransformationData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphTextureTransformationData));
            return InitializeA3DGraphTextureTransformationData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DGraphTextureDefinitionData(ref A3DGraphTextureDefinitionData s);
        public static bool Initialize(out A3DGraphTextureDefinitionData s)
        {
            s = new A3DGraphTextureDefinitionData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphTextureDefinitionData));
            return InitializeA3DGraphTextureDefinitionData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DGraphTextureApplicationData(ref A3DGraphTextureApplicationData s);
        public static bool Initialize(out A3DGraphTextureApplicationData s)
        {
            s = new A3DGraphTextureApplicationData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphTextureApplicationData));
            return InitializeA3DGraphTextureApplicationData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DDrawCallbacksData(ref A3DDrawCallbacksData s);
        public static bool Initialize(out A3DDrawCallbacksData s)
        {
            s = new A3DDrawCallbacksData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawCallbacksData));
            return InitializeA3DDrawCallbacksData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DDrawingModelData(ref A3DDrawingModelData s);
        public static bool Initialize(out A3DDrawingModelData s)
        {
            s = new A3DDrawingModelData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingModelData));
            return InitializeA3DDrawingModelData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DDrawingSheetFormatData(ref A3DDrawingSheetFormatData s);
        public static bool Initialize(out A3DDrawingSheetFormatData s)
        {
            s = new A3DDrawingSheetFormatData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingSheetFormatData));
            return InitializeA3DDrawingSheetFormatData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DDrawingSheetData(ref A3DDrawingSheetData s);
        public static bool Initialize(out A3DDrawingSheetData s)
        {
            s = new A3DDrawingSheetData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingSheetData));
            return InitializeA3DDrawingSheetData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DDrawingClipFrameData(ref A3DDrawingClipFrameData s);
        public static bool Initialize(out A3DDrawingClipFrameData s)
        {
            s = new A3DDrawingClipFrameData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingClipFrameData));
            return InitializeA3DDrawingClipFrameData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DDrawingViewData(ref A3DDrawingViewData s);
        public static bool Initialize(out A3DDrawingViewData s)
        {
            s = new A3DDrawingViewData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingViewData));
            return InitializeA3DDrawingViewData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DDrawingBlockBasicData(ref A3DDrawingBlockBasicData s);
        public static bool Initialize(out A3DDrawingBlockBasicData s)
        {
            s = new A3DDrawingBlockBasicData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingBlockBasicData));
            return InitializeA3DDrawingBlockBasicData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DDrawingBlockOperatorData(ref A3DDrawingBlockOperatorData s);
        public static bool Initialize(out A3DDrawingBlockOperatorData s)
        {
            s = new A3DDrawingBlockOperatorData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingBlockOperatorData));
            return InitializeA3DDrawingBlockOperatorData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DDrawingCurveData(ref A3DDrawingCurveData s);
        public static bool Initialize(out A3DDrawingCurveData s)
        {
            s = new A3DDrawingCurveData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingCurveData));
            return InitializeA3DDrawingCurveData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DDrawingFilledAreaData(ref A3DDrawingFilledAreaData s);
        public static bool Initialize(out A3DDrawingFilledAreaData s)
        {
            s = new A3DDrawingFilledAreaData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingFilledAreaData));
            return InitializeA3DDrawingFilledAreaData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DDrawingPictureData(ref A3DDrawingPictureData s);
        public static bool Initialize(out A3DDrawingPictureData s)
        {
            s = new A3DDrawingPictureData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingPictureData));
            return InitializeA3DDrawingPictureData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DDrawingVerticesData(ref A3DDrawingVerticesData s);
        public static bool Initialize(out A3DDrawingVerticesData s)
        {
            s = new A3DDrawingVerticesData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingVerticesData));
            return InitializeA3DDrawingVerticesData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DThumbnailData(ref A3DThumbnailData s);
        public static bool Initialize(out A3DThumbnailData s)
        {
            s = new A3DThumbnailData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DThumbnailData));
            return InitializeA3DThumbnailData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DFileInformationData(ref A3DFileInformationData s);
        public static bool Initialize(out A3DFileInformationData s)
        {
            s = new A3DFileInformationData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFileInformationData));
            return InitializeA3DFileInformationData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DFileContextData(ref A3DFileContextData s);
        public static bool Initialize(out A3DFileContextData s)
        {
            s = new A3DFileContextData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFileContextData));
            return InitializeA3DFileContextData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsExportParasolidData(ref A3DRWParamsExportParasolidData s);
        public static bool Initialize(out A3DRWParamsExportParasolidData s)
        {
            s = new A3DRWParamsExportParasolidData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportParasolidData));
            return InitializeA3DRWParamsExportParasolidData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsTranslateToPkPartsData(ref A3DRWParamsTranslateToPkPartsData s);
        public static bool Initialize(out A3DRWParamsTranslateToPkPartsData s)
        {
            s = new A3DRWParamsTranslateToPkPartsData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsTranslateToPkPartsData));
            return InitializeA3DRWParamsTranslateToPkPartsData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRWParamsExportAcisData(ref A3DRWParamsExportAcisData s);
        public static bool Initialize(out A3DRWParamsExportAcisData s)
        {
            s = new A3DRWParamsExportAcisData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportAcisData));
            return InitializeA3DRWParamsExportAcisData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRiRepresentationItemData(ref A3DRiRepresentationItemData s);
        public static bool Initialize(out A3DRiRepresentationItemData s)
        {
            s = new A3DRiRepresentationItemData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRiRepresentationItemData));
            return InitializeA3DRiRepresentationItemData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRiSetData(ref A3DRiSetData s);
        public static bool Initialize(out A3DRiSetData s)
        {
            s = new A3DRiSetData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRiSetData));
            return InitializeA3DRiSetData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRiPointSetData(ref A3DRiPointSetData s);
        public static bool Initialize(out A3DRiPointSetData s)
        {
            s = new A3DRiPointSetData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRiPointSetData));
            return InitializeA3DRiPointSetData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRiDirectionData(ref A3DRiDirectionData s);
        public static bool Initialize(out A3DRiDirectionData s)
        {
            s = new A3DRiDirectionData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRiDirectionData));
            return InitializeA3DRiDirectionData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRiCoordinateSystemData(ref A3DRiCoordinateSystemData s);
        public static bool Initialize(out A3DRiCoordinateSystemData s)
        {
            s = new A3DRiCoordinateSystemData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRiCoordinateSystemData));
            return InitializeA3DRiCoordinateSystemData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRiCurveData(ref A3DRiCurveData s);
        public static bool Initialize(out A3DRiCurveData s)
        {
            s = new A3DRiCurveData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRiCurveData));
            return InitializeA3DRiCurveData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRiPlaneData(ref A3DRiPlaneData s);
        public static bool Initialize(out A3DRiPlaneData s)
        {
            s = new A3DRiPlaneData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRiPlaneData));
            return InitializeA3DRiPlaneData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRiBrepModelData(ref A3DRiBrepModelData s);
        public static bool Initialize(out A3DRiBrepModelData s)
        {
            s = new A3DRiBrepModelData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRiBrepModelData));
            return InitializeA3DRiBrepModelData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRiPolyBrepModelData(ref A3DRiPolyBrepModelData s);
        public static bool Initialize(out A3DRiPolyBrepModelData s)
        {
            s = new A3DRiPolyBrepModelData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRiPolyBrepModelData));
            return InitializeA3DRiPolyBrepModelData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRiPolyWireData(ref A3DRiPolyWireData s);
        public static bool Initialize(out A3DRiPolyWireData s)
        {
            s = new A3DRiPolyWireData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRiPolyWireData));
            return InitializeA3DRiPolyWireData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DFRMFeatureTreeData(ref A3DFRMFeatureTreeData s);
        public static bool Initialize(out A3DFRMFeatureTreeData s)
        {
            s = new A3DFRMFeatureTreeData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFRMFeatureTreeData));
            return InitializeA3DFRMFeatureTreeData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DFRMParameterData(ref A3DFRMParameterData s);
        public static bool Initialize(out A3DFRMParameterData s)
        {
            s = new A3DFRMParameterData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFRMParameterData));
            return InitializeA3DFRMParameterData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DFRMFeatureTypeData(ref A3DFRMFeatureTypeData s);
        public static bool Initialize(out A3DFRMFeatureTypeData s)
        {
            s = new A3DFRMFeatureTypeData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFRMFeatureTypeData));
            return InitializeA3DFRMFeatureTypeData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DFRMStringData(ref A3DFRMStringData s);
        public static bool Initialize(out A3DFRMStringData s)
        {
            s = new A3DFRMStringData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFRMStringData));
            return InitializeA3DFRMStringData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DFRMDoubleData(ref A3DFRMDoubleData s);
        public static bool Initialize(out A3DFRMDoubleData s)
        {
            s = new A3DFRMDoubleData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFRMDoubleData));
            return InitializeA3DFRMDoubleData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DFRMIntegerData(ref A3DFRMIntegerData s);
        public static bool Initialize(out A3DFRMIntegerData s)
        {
            s = new A3DFRMIntegerData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFRMIntegerData));
            return InitializeA3DFRMIntegerData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DFRMFeatureLinkedItemData(ref A3DFRMFeatureLinkedItemData s);
        public static bool Initialize(out A3DFRMFeatureLinkedItemData s)
        {
            s = new A3DFRMFeatureLinkedItemData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFRMFeatureLinkedItemData));
            return InitializeA3DFRMFeatureLinkedItemData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DFRMFeatureData(ref A3DFRMFeatureData s);
        public static bool Initialize(out A3DFRMFeatureData s)
        {
            s = new A3DFRMFeatureData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFRMFeatureData));
            return InitializeA3DFRMFeatureData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DFRMFeatureGeomEntitiesData(ref A3DFRMFeatureGeomEntitiesData s);
        public static bool Initialize(out A3DFRMFeatureGeomEntitiesData s)
        {
            s = new A3DFRMFeatureGeomEntitiesData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFRMFeatureGeomEntitiesData));
            return InitializeA3DFRMFeatureGeomEntitiesData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCrvNurbsData(ref A3DCrvNurbsData s);
        public static bool Initialize(out A3DCrvNurbsData s)
        {
            s = new A3DCrvNurbsData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvNurbsData));
            return InitializeA3DCrvNurbsData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCrvLineData(ref A3DCrvLineData s);
        public static bool Initialize(out A3DCrvLineData s)
        {
            s = new A3DCrvLineData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvLineData));
            return InitializeA3DCrvLineData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCrvCircleData(ref A3DCrvCircleData s);
        public static bool Initialize(out A3DCrvCircleData s)
        {
            s = new A3DCrvCircleData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvCircleData));
            return InitializeA3DCrvCircleData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCrvEllipseData(ref A3DCrvEllipseData s);
        public static bool Initialize(out A3DCrvEllipseData s)
        {
            s = new A3DCrvEllipseData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvEllipseData));
            return InitializeA3DCrvEllipseData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCrvParabolaData(ref A3DCrvParabolaData s);
        public static bool Initialize(out A3DCrvParabolaData s)
        {
            s = new A3DCrvParabolaData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvParabolaData));
            return InitializeA3DCrvParabolaData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCrvHyperbolaData(ref A3DCrvHyperbolaData s);
        public static bool Initialize(out A3DCrvHyperbolaData s)
        {
            s = new A3DCrvHyperbolaData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvHyperbolaData));
            return InitializeA3DCrvHyperbolaData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCrvPolyLineData(ref A3DCrvPolyLineData s);
        public static bool Initialize(out A3DCrvPolyLineData s)
        {
            s = new A3DCrvPolyLineData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvPolyLineData));
            return InitializeA3DCrvPolyLineData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCrvCompositeData(ref A3DCrvCompositeData s);
        public static bool Initialize(out A3DCrvCompositeData s)
        {
            s = new A3DCrvCompositeData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvCompositeData));
            return InitializeA3DCrvCompositeData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCrvEquationData(ref A3DCrvEquationData s);
        public static bool Initialize(out A3DCrvEquationData s)
        {
            s = new A3DCrvEquationData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvEquationData));
            return InitializeA3DCrvEquationData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCrvTransformData(ref A3DCrvTransformData s);
        public static bool Initialize(out A3DCrvTransformData s)
        {
            s = new A3DCrvTransformData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvTransformData));
            return InitializeA3DCrvTransformData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCrvOnSurfData(ref A3DCrvOnSurfData s);
        public static bool Initialize(out A3DCrvOnSurfData s)
        {
            s = new A3DCrvOnSurfData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvOnSurfData));
            return InitializeA3DCrvOnSurfData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCrvOffsetData(ref A3DCrvOffsetData s);
        public static bool Initialize(out A3DCrvOffsetData s)
        {
            s = new A3DCrvOffsetData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvOffsetData));
            return InitializeA3DCrvOffsetData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCrvHelixPitchCstData(ref A3DCrvHelixPitchCstData s);
        public static bool Initialize(out A3DCrvHelixPitchCstData s)
        {
            s = new A3DCrvHelixPitchCstData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvHelixPitchCstData));
            return InitializeA3DCrvHelixPitchCstData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCrvHelixPitchVarData(ref A3DCrvHelixPitchVarData s);
        public static bool Initialize(out A3DCrvHelixPitchVarData s)
        {
            s = new A3DCrvHelixPitchVarData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvHelixPitchVarData));
            return InitializeA3DCrvHelixPitchVarData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCrvHelixData(ref A3DCrvHelixData s);
        public static bool Initialize(out A3DCrvHelixData s)
        {
            s = new A3DCrvHelixData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvHelixData));
            return InitializeA3DCrvHelixData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCrossingPointsCrvIntersectionData(ref A3DCrossingPointsCrvIntersectionData s);
        public static bool Initialize(out A3DCrossingPointsCrvIntersectionData s)
        {
            s = new A3DCrossingPointsCrvIntersectionData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrossingPointsCrvIntersectionData));
            return InitializeA3DCrossingPointsCrvIntersectionData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCrvIntersectionData(ref A3DCrvIntersectionData s);
        public static bool Initialize(out A3DCrvIntersectionData s)
        {
            s = new A3DCrvIntersectionData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvIntersectionData));
            return InitializeA3DCrvIntersectionData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCrvBlend02BoundaryData(ref A3DCrvBlend02BoundaryData s);
        public static bool Initialize(out A3DCrvBlend02BoundaryData s)
        {
            s = new A3DCrvBlend02BoundaryData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvBlend02BoundaryData));
            return InitializeA3DCrvBlend02BoundaryData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DSurfNurbsData(ref A3DSurfNurbsData s);
        public static bool Initialize(out A3DSurfNurbsData s)
        {
            s = new A3DSurfNurbsData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfNurbsData));
            return InitializeA3DSurfNurbsData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DSurfSphereData(ref A3DSurfSphereData s);
        public static bool Initialize(out A3DSurfSphereData s)
        {
            s = new A3DSurfSphereData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfSphereData));
            return InitializeA3DSurfSphereData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DSurfCylinderData(ref A3DSurfCylinderData s);
        public static bool Initialize(out A3DSurfCylinderData s)
        {
            s = new A3DSurfCylinderData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfCylinderData));
            return InitializeA3DSurfCylinderData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DSurfTorusData(ref A3DSurfTorusData s);
        public static bool Initialize(out A3DSurfTorusData s)
        {
            s = new A3DSurfTorusData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfTorusData));
            return InitializeA3DSurfTorusData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DSurfRevolutionData(ref A3DSurfRevolutionData s);
        public static bool Initialize(out A3DSurfRevolutionData s)
        {
            s = new A3DSurfRevolutionData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfRevolutionData));
            return InitializeA3DSurfRevolutionData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DSurfExtrusionData(ref A3DSurfExtrusionData s);
        public static bool Initialize(out A3DSurfExtrusionData s)
        {
            s = new A3DSurfExtrusionData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfExtrusionData));
            return InitializeA3DSurfExtrusionData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DSurfOffsetData(ref A3DSurfOffsetData s);
        public static bool Initialize(out A3DSurfOffsetData s)
        {
            s = new A3DSurfOffsetData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfOffsetData));
            return InitializeA3DSurfOffsetData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DSurfPlaneData(ref A3DSurfPlaneData s);
        public static bool Initialize(out A3DSurfPlaneData s)
        {
            s = new A3DSurfPlaneData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfPlaneData));
            return InitializeA3DSurfPlaneData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DSurfBlend01Data(ref A3DSurfBlend01Data s);
        public static bool Initialize(out A3DSurfBlend01Data s)
        {
            s = new A3DSurfBlend01Data();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfBlend01Data));
            return InitializeA3DSurfBlend01Data(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DSurfBlend02Data(ref A3DSurfBlend02Data s);
        public static bool Initialize(out A3DSurfBlend02Data s)
        {
            s = new A3DSurfBlend02Data();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfBlend02Data));
            return InitializeA3DSurfBlend02Data(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DSurfBlend03Data(ref A3DSurfBlend03Data s);
        public static bool Initialize(out A3DSurfBlend03Data s)
        {
            s = new A3DSurfBlend03Data();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfBlend03Data));
            return InitializeA3DSurfBlend03Data(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DSurfConeData(ref A3DSurfConeData s);
        public static bool Initialize(out A3DSurfConeData s)
        {
            s = new A3DSurfConeData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfConeData));
            return InitializeA3DSurfConeData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DSurfCylindricalData(ref A3DSurfCylindricalData s);
        public static bool Initialize(out A3DSurfCylindricalData s)
        {
            s = new A3DSurfCylindricalData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfCylindricalData));
            return InitializeA3DSurfCylindricalData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DSurfRuledData(ref A3DSurfRuledData s);
        public static bool Initialize(out A3DSurfRuledData s)
        {
            s = new A3DSurfRuledData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfRuledData));
            return InitializeA3DSurfRuledData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DSurfPipeData(ref A3DSurfPipeData s);
        public static bool Initialize(out A3DSurfPipeData s)
        {
            s = new A3DSurfPipeData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfPipeData));
            return InitializeA3DSurfPipeData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DSurfTransformData(ref A3DSurfTransformData s);
        public static bool Initialize(out A3DSurfTransformData s)
        {
            s = new A3DSurfTransformData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfTransformData));
            return InitializeA3DSurfTransformData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DSurfFromCurvesData(ref A3DSurfFromCurvesData s);
        public static bool Initialize(out A3DSurfFromCurvesData s)
        {
            s = new A3DSurfFromCurvesData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfFromCurvesData));
            return InitializeA3DSurfFromCurvesData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DGlobalData(ref A3DGlobalData s);
        public static bool Initialize(out A3DGlobalData s)
        {
            s = new A3DGlobalData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGlobalData));
            return InitializeA3DGlobalData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDPosition3DData(ref A3DMDPosition3DData s);
        public static bool Initialize(out A3DMDPosition3DData s)
        {
            s = new A3DMDPosition3DData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDPosition3DData));
            return InitializeA3DMDPosition3DData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDPosition2DData(ref A3DMDPosition2DData s);
        public static bool Initialize(out A3DMDPosition2DData s)
        {
            s = new A3DMDPosition2DData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDPosition2DData));
            return InitializeA3DMDPosition2DData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDPositionReferenceData(ref A3DMDPositionReferenceData s);
        public static bool Initialize(out A3DMDPositionReferenceData s)
        {
            s = new A3DMDPositionReferenceData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDPositionReferenceData));
            return InitializeA3DMDPositionReferenceData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDLeaderSymbolData(ref A3DMDLeaderSymbolData s);
        public static bool Initialize(out A3DMDLeaderSymbolData s)
        {
            s = new A3DMDLeaderSymbolData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDLeaderSymbolData));
            return InitializeA3DMDLeaderSymbolData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDMarkupLeaderStubData(ref A3DMDMarkupLeaderStubData s);
        public static bool Initialize(out A3DMDMarkupLeaderStubData s)
        {
            s = new A3DMDMarkupLeaderStubData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDMarkupLeaderStubData));
            return InitializeA3DMDMarkupLeaderStubData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDLeaderDefinitionData(ref A3DMDLeaderDefinitionData s);
        public static bool Initialize(out A3DMDLeaderDefinitionData s)
        {
            s = new A3DMDLeaderDefinitionData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDLeaderDefinitionData));
            return InitializeA3DMDLeaderDefinitionData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDTextPropertiesData(ref A3DMDTextPropertiesData s);
        public static bool Initialize(out A3DMDTextPropertiesData s)
        {
            s = new A3DMDTextPropertiesData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDTextPropertiesData));
            return InitializeA3DMDTextPropertiesData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMarkupDefinitionData(ref A3DMarkupDefinitionData s);
        public static bool Initialize(out A3DMarkupDefinitionData s)
        {
            s = new A3DMarkupDefinitionData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupDefinitionData));
            return InitializeA3DMarkupDefinitionData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDDimensionValueFormatData(ref A3DMDDimensionValueFormatData s);
        public static bool Initialize(out A3DMDDimensionValueFormatData s)
        {
            s = new A3DMDDimensionValueFormatData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionValueFormatData));
            return InitializeA3DMDDimensionValueFormatData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDDimensionSimpleToleranceFormatData(ref A3DMDDimensionSimpleToleranceFormatData s);
        public static bool Initialize(out A3DMDDimensionSimpleToleranceFormatData s)
        {
            s = new A3DMDDimensionSimpleToleranceFormatData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionSimpleToleranceFormatData));
            return InitializeA3DMDDimensionSimpleToleranceFormatData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDDimensionCombinedToleranceFormatData(ref A3DMDDimensionCombinedToleranceFormatData s);
        public static bool Initialize(out A3DMDDimensionCombinedToleranceFormatData s)
        {
            s = new A3DMDDimensionCombinedToleranceFormatData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionCombinedToleranceFormatData));
            return InitializeA3DMDDimensionCombinedToleranceFormatData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDDimensionValueData(ref A3DMDDimensionValueData s);
        public static bool Initialize(out A3DMDDimensionValueData s)
        {
            s = new A3DMDDimensionValueData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionValueData));
            return InitializeA3DMDDimensionValueData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDDimensionSecondPartData(ref A3DMDDimensionSecondPartData s);
        public static bool Initialize(out A3DMDDimensionSecondPartData s)
        {
            s = new A3DMDDimensionSecondPartData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionSecondPartData));
            return InitializeA3DMDDimensionSecondPartData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDDimensionForeshortenedData(ref A3DMDDimensionForeshortenedData s);
        public static bool Initialize(out A3DMDDimensionForeshortenedData s)
        {
            s = new A3DMDDimensionForeshortenedData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionForeshortenedData));
            return InitializeA3DMDDimensionForeshortenedData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDDimensionLineSymbolData(ref A3DMDDimensionLineSymbolData s);
        public static bool Initialize(out A3DMDDimensionLineSymbolData s)
        {
            s = new A3DMDDimensionLineSymbolData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionLineSymbolData));
            return InitializeA3DMDDimensionLineSymbolData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDDimensionLineData(ref A3DMDDimensionLineData s);
        public static bool Initialize(out A3DMDDimensionLineData s)
        {
            s = new A3DMDDimensionLineData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionLineData));
            return InitializeA3DMDDimensionLineData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDDimensionFunnelData(ref A3DMDDimensionFunnelData s);
        public static bool Initialize(out A3DMDDimensionFunnelData s)
        {
            s = new A3DMDDimensionFunnelData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionFunnelData));
            return InitializeA3DMDDimensionFunnelData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDDimensionExtremityData(ref A3DMDDimensionExtremityData s);
        public static bool Initialize(out A3DMDDimensionExtremityData s)
        {
            s = new A3DMDDimensionExtremityData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionExtremityData));
            return InitializeA3DMDDimensionExtremityData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDDimensionExtentionLineData(ref A3DMDDimensionExtentionLineData s);
        public static bool Initialize(out A3DMDDimensionExtentionLineData s)
        {
            s = new A3DMDDimensionExtentionLineData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionExtentionLineData));
            return InitializeA3DMDDimensionExtentionLineData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMarkupDimensionData(ref A3DMarkupDimensionData s);
        public static bool Initialize(out A3DMarkupDimensionData s)
        {
            s = new A3DMarkupDimensionData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupDimensionData));
            return InitializeA3DMarkupDimensionData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMarkupRoughnessData(ref A3DMarkupRoughnessData s);
        public static bool Initialize(out A3DMarkupRoughnessData s)
        {
            s = new A3DMarkupRoughnessData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupRoughnessData));
            return InitializeA3DMarkupRoughnessData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMarkupBalloonData(ref A3DMarkupBalloonData s);
        public static bool Initialize(out A3DMarkupBalloonData s)
        {
            s = new A3DMarkupBalloonData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupBalloonData));
            return InitializeA3DMarkupBalloonData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMarkupFastenerData(ref A3DMarkupFastenerData s);
        public static bool Initialize(out A3DMarkupFastenerData s)
        {
            s = new A3DMarkupFastenerData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupFastenerData));
            return InitializeA3DMarkupFastenerData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMarkupLocatorData(ref A3DMarkupLocatorData s);
        public static bool Initialize(out A3DMarkupLocatorData s)
        {
            s = new A3DMarkupLocatorData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupLocatorData));
            return InitializeA3DMarkupLocatorData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMarkupMeasurementPointData(ref A3DMarkupMeasurementPointData s);
        public static bool Initialize(out A3DMarkupMeasurementPointData s)
        {
            s = new A3DMarkupMeasurementPointData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupMeasurementPointData));
            return InitializeA3DMarkupMeasurementPointData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDTextPositionData(ref A3DMDTextPositionData s);
        public static bool Initialize(out A3DMDTextPositionData s)
        {
            s = new A3DMDTextPositionData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDTextPositionData));
            return InitializeA3DMDTextPositionData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMarkupTextData(ref A3DMarkupTextData s);
        public static bool Initialize(out A3DMarkupTextData s)
        {
            s = new A3DMarkupTextData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupTextData));
            return InitializeA3DMarkupTextData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMarkupCoordinateData(ref A3DMarkupCoordinateData s);
        public static bool Initialize(out A3DMarkupCoordinateData s)
        {
            s = new A3DMarkupCoordinateData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupCoordinateData));
            return InitializeA3DMarkupCoordinateData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMarkupRichTextData(ref A3DMarkupRichTextData s);
        public static bool Initialize(out A3DMarkupRichTextData s)
        {
            s = new A3DMarkupRichTextData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupRichTextData));
            return InitializeA3DMarkupRichTextData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMarkupDatumData(ref A3DMarkupDatumData s);
        public static bool Initialize(out A3DMarkupDatumData s)
        {
            s = new A3DMarkupDatumData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupDatumData));
            return InitializeA3DMarkupDatumData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDFCFDraftingRowData(ref A3DMDFCFDraftingRowData s);
        public static bool Initialize(out A3DMDFCFDraftingRowData s)
        {
            s = new A3DMDFCFDraftingRowData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDFCFDraftingRowData));
            return InitializeA3DMDFCFDraftingRowData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDFCValueData(ref A3DMDFCValueData s);
        public static bool Initialize(out A3DMDFCValueData s)
        {
            s = new A3DMDFCValueData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDFCValueData));
            return InitializeA3DMDFCValueData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDFCTolerancePerUnitData(ref A3DMDFCTolerancePerUnitData s);
        public static bool Initialize(out A3DMDFCTolerancePerUnitData s)
        {
            s = new A3DMDFCTolerancePerUnitData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDFCTolerancePerUnitData));
            return InitializeA3DMDFCTolerancePerUnitData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDFCProjectedZoneData(ref A3DMDFCProjectedZoneData s);
        public static bool Initialize(out A3DMDFCProjectedZoneData s)
        {
            s = new A3DMDFCProjectedZoneData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDFCProjectedZoneData));
            return InitializeA3DMDFCProjectedZoneData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDFCFToleranceValueData(ref A3DMDFCFToleranceValueData s);
        public static bool Initialize(out A3DMDFCFToleranceValueData s)
        {
            s = new A3DMDFCFToleranceValueData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDFCFToleranceValueData));
            return InitializeA3DMDFCFToleranceValueData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDFCFRowDatumData(ref A3DMDFCFRowDatumData s);
        public static bool Initialize(out A3DMDFCFRowDatumData s)
        {
            s = new A3DMDFCFRowDatumData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDFCFRowDatumData));
            return InitializeA3DMDFCFRowDatumData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDFCFDrawingRowData(ref A3DMDFCFDrawingRowData s);
        public static bool Initialize(out A3DMDFCFDrawingRowData s)
        {
            s = new A3DMDFCFDrawingRowData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDFCFDrawingRowData));
            return InitializeA3DMDFCFDrawingRowData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDFCFIndicatorData(ref A3DMDFCFIndicatorData s);
        public static bool Initialize(out A3DMDFCFIndicatorData s)
        {
            s = new A3DMDFCFIndicatorData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDFCFIndicatorData));
            return InitializeA3DMDFCFIndicatorData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDFeatureControlFrameData(ref A3DMDFeatureControlFrameData s);
        public static bool Initialize(out A3DMDFeatureControlFrameData s)
        {
            s = new A3DMDFeatureControlFrameData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDFeatureControlFrameData));
            return InitializeA3DMDFeatureControlFrameData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDToleranceSizeValueData(ref A3DMDToleranceSizeValueData s);
        public static bool Initialize(out A3DMDToleranceSizeValueData s)
        {
            s = new A3DMDToleranceSizeValueData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDToleranceSizeValueData));
            return InitializeA3DMDToleranceSizeValueData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMDToleranceSizeData(ref A3DMDToleranceSizeData s);
        public static bool Initialize(out A3DMDToleranceSizeData s)
        {
            s = new A3DMDToleranceSizeData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDToleranceSizeData));
            return InitializeA3DMDToleranceSizeData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMarkupGDTData(ref A3DMarkupGDTData s);
        public static bool Initialize(out A3DMarkupGDTData s)
        {
            s = new A3DMarkupGDTData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupGDTData));
            return InitializeA3DMarkupGDTData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMarkupSpotWeldingData(ref A3DMarkupSpotWeldingData s);
        public static bool Initialize(out A3DMarkupSpotWeldingData s)
        {
            s = new A3DMarkupSpotWeldingData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupSpotWeldingData));
            return InitializeA3DMarkupSpotWeldingData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMarkupLineWeldingData(ref A3DMarkupLineWeldingData s);
        public static bool Initialize(out A3DMarkupLineWeldingData s)
        {
            s = new A3DMarkupLineWeldingData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupLineWeldingData));
            return InitializeA3DMarkupLineWeldingData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMathFct1DPolynomData(ref A3DMathFct1DPolynomData s);
        public static bool Initialize(out A3DMathFct1DPolynomData s)
        {
            s = new A3DMathFct1DPolynomData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMathFct1DPolynomData));
            return InitializeA3DMathFct1DPolynomData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMathFct1DTrigonometricData(ref A3DMathFct1DTrigonometricData s);
        public static bool Initialize(out A3DMathFct1DTrigonometricData s)
        {
            s = new A3DMathFct1DTrigonometricData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMathFct1DTrigonometricData));
            return InitializeA3DMathFct1DTrigonometricData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMathFct1DFractionData(ref A3DMathFct1DFractionData s);
        public static bool Initialize(out A3DMathFct1DFractionData s)
        {
            s = new A3DMathFct1DFractionData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMathFct1DFractionData));
            return InitializeA3DMathFct1DFractionData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMathFct1DArctanCosData(ref A3DMathFct1DArctanCosData s);
        public static bool Initialize(out A3DMathFct1DArctanCosData s)
        {
            s = new A3DMathFct1DArctanCosData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMathFct1DArctanCosData));
            return InitializeA3DMathFct1DArctanCosData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMathFct1DCombinationData(ref A3DMathFct1DCombinationData s);
        public static bool Initialize(out A3DMathFct1DCombinationData s)
        {
            s = new A3DMathFct1DCombinationData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMathFct1DCombinationData));
            return InitializeA3DMathFct1DCombinationData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMathFct3DLinearData(ref A3DMathFct3DLinearData s);
        public static bool Initialize(out A3DMathFct3DLinearData s)
        {
            s = new A3DMathFct3DLinearData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMathFct3DLinearData));
            return InitializeA3DMathFct3DLinearData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMathFct3DNonLinearData(ref A3DMathFct3DNonLinearData s);
        public static bool Initialize(out A3DMathFct3DNonLinearData s)
        {
            s = new A3DMathFct3DNonLinearData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMathFct3DNonLinearData));
            return InitializeA3DMathFct3DNonLinearData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRootBaseData(ref A3DRootBaseData s);
        public static bool Initialize(out A3DRootBaseData s)
        {
            s = new A3DRootBaseData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRootBaseData));
            return InitializeA3DRootBaseData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DRootBaseWithGraphicsData(ref A3DRootBaseWithGraphicsData s);
        public static bool Initialize(out A3DRootBaseWithGraphicsData s)
        {
            s = new A3DRootBaseWithGraphicsData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRootBaseWithGraphicsData));
            return InitializeA3DRootBaseWithGraphicsData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMiscSingleAttributeData(ref A3DMiscSingleAttributeData s);
        public static bool Initialize(out A3DMiscSingleAttributeData s)
        {
            s = new A3DMiscSingleAttributeData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscSingleAttributeData));
            return InitializeA3DMiscSingleAttributeData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMiscAttributeData(ref A3DMiscAttributeData s);
        public static bool Initialize(out A3DMiscAttributeData s)
        {
            s = new A3DMiscAttributeData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscAttributeData));
            return InitializeA3DMiscAttributeData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMiscAttributeBasicUnitData(ref A3DMiscAttributeBasicUnitData s);
        public static bool Initialize(out A3DMiscAttributeBasicUnitData s)
        {
            s = new A3DMiscAttributeBasicUnitData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscAttributeBasicUnitData));
            return InitializeA3DMiscAttributeBasicUnitData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DMiscAttributeUnitData(ref A3DMiscAttributeUnitData s);
        public static bool Initialize(out A3DMiscAttributeUnitData s)
        {
            s = new A3DMiscAttributeUnitData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscAttributeUnitData));
            return InitializeA3DMiscAttributeUnitData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DCopyAndAdaptBrepModelData(ref A3DCopyAndAdaptBrepModelData s);
        public static bool Initialize(out A3DCopyAndAdaptBrepModelData s)
        {
            s = new A3DCopyAndAdaptBrepModelData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCopyAndAdaptBrepModelData));
            return InitializeA3DCopyAndAdaptBrepModelData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DPhysicalPropertiesData(ref A3DPhysicalPropertiesData s);
        public static bool Initialize(out A3DPhysicalPropertiesData s)
        {
            s = new A3DPhysicalPropertiesData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DPhysicalPropertiesData));
            return InitializeA3DPhysicalPropertiesData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DTopoBodyData(ref A3DTopoBodyData s);
        public static bool Initialize(out A3DTopoBodyData s)
        {
            s = new A3DTopoBodyData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoBodyData));
            return InitializeA3DTopoBodyData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DTopoContextData(ref A3DTopoContextData s);
        public static bool Initialize(out A3DTopoContextData s)
        {
            s = new A3DTopoContextData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoContextData));
            return InitializeA3DTopoContextData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DTopoSingleWireBodyData(ref A3DTopoSingleWireBodyData s);
        public static bool Initialize(out A3DTopoSingleWireBodyData s)
        {
            s = new A3DTopoSingleWireBodyData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoSingleWireBodyData));
            return InitializeA3DTopoSingleWireBodyData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DTopoBrepDataData(ref A3DTopoBrepDataData s);
        public static bool Initialize(out A3DTopoBrepDataData s)
        {
            s = new A3DTopoBrepDataData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoBrepDataData));
            return InitializeA3DTopoBrepDataData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DTopoConnexData(ref A3DTopoConnexData s);
        public static bool Initialize(out A3DTopoConnexData s)
        {
            s = new A3DTopoConnexData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoConnexData));
            return InitializeA3DTopoConnexData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DTopoShellData(ref A3DTopoShellData s);
        public static bool Initialize(out A3DTopoShellData s)
        {
            s = new A3DTopoShellData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoShellData));
            return InitializeA3DTopoShellData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DTopoFaceData(ref A3DTopoFaceData s);
        public static bool Initialize(out A3DTopoFaceData s)
        {
            s = new A3DTopoFaceData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoFaceData));
            return InitializeA3DTopoFaceData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DTopoLoopData(ref A3DTopoLoopData s);
        public static bool Initialize(out A3DTopoLoopData s)
        {
            s = new A3DTopoLoopData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoLoopData));
            return InitializeA3DTopoLoopData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DTopoCoEdgeData(ref A3DTopoCoEdgeData s);
        public static bool Initialize(out A3DTopoCoEdgeData s)
        {
            s = new A3DTopoCoEdgeData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoCoEdgeData));
            return InitializeA3DTopoCoEdgeData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DTopoEdgeData(ref A3DTopoEdgeData s);
        public static bool Initialize(out A3DTopoEdgeData s)
        {
            s = new A3DTopoEdgeData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoEdgeData));
            return InitializeA3DTopoEdgeData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DTopoWireEdgeData(ref A3DTopoWireEdgeData s);
        public static bool Initialize(out A3DTopoWireEdgeData s)
        {
            s = new A3DTopoWireEdgeData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoWireEdgeData));
            return InitializeA3DTopoWireEdgeData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DTopoUniqueVertexData(ref A3DTopoUniqueVertexData s);
        public static bool Initialize(out A3DTopoUniqueVertexData s)
        {
            s = new A3DTopoUniqueVertexData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoUniqueVertexData));
            return InitializeA3DTopoUniqueVertexData(ref s);
        }
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitializeA3DTopoMultipleVertexData(ref A3DTopoMultipleVertexData s);
        public static bool Initialize(out A3DTopoMultipleVertexData s)
        {
            s = new A3DTopoMultipleVertexData();
            s.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoMultipleVertexData));
            return InitializeA3DTopoMultipleVertexData(ref s);
        }
        public delegate A3DStatus PFA3DTessBaseGet(IntPtr pTessBase, ref A3DTessBaseData pData);
        public static PFA3DTessBaseGet A3DTessBaseGet = Marshal.GetDelegateForFunctionPointer<PFA3DTessBaseGet>(Library.A3DGetProcAddress("A3DTessBaseGet", 1));
        public delegate A3DStatus PFA3DTessBaseSet(IntPtr pTessBase, ref A3DTessBaseData pData);
        public static PFA3DTessBaseSet A3DTessBaseSet = Marshal.GetDelegateForFunctionPointer<PFA3DTessBaseSet>(Library.A3DGetProcAddress("A3DTessBaseSet", 1));
        public delegate A3DStatus PFA3DTessBaseSetNoHash(IntPtr pTessBase, ref A3DTessBaseData pData);
        public static PFA3DTessBaseSetNoHash A3DTessBaseSetNoHash = Marshal.GetDelegateForFunctionPointer<PFA3DTessBaseSetNoHash>(Library.A3DGetProcAddress("A3DTessBaseSetNoHash", 1));
        public delegate A3DStatus PFA3DTess3DGet(IntPtr pTess, ref A3DTess3DData pData);
        public static PFA3DTess3DGet A3DTess3DGet = Marshal.GetDelegateForFunctionPointer<PFA3DTess3DGet>(Library.A3DGetProcAddress("A3DTess3DGet", 1));
        public delegate A3DStatus PFA3DTess3DCreate(ref A3DTess3DData pData, out IntPtr ppTess);
        public static PFA3DTess3DCreate A3DTess3DCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTess3DCreate>(Library.A3DGetProcAddress("A3DTess3DCreate", 1));
        public delegate A3DStatus PFA3DTess3DWireGet(IntPtr pTess, ref A3DTess3DWireData pData);
        public static PFA3DTess3DWireGet A3DTess3DWireGet = Marshal.GetDelegateForFunctionPointer<PFA3DTess3DWireGet>(Library.A3DGetProcAddress("A3DTess3DWireGet", 1));
        public delegate A3DStatus PFA3DTess3DWireCreate(ref A3DTess3DWireData pData, out IntPtr ppTess);
        public static PFA3DTess3DWireCreate A3DTess3DWireCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTess3DWireCreate>(Library.A3DGetProcAddress("A3DTess3DWireCreate", 1));
        public delegate A3DStatus PFA3DTessMarkupGet(IntPtr pTess, ref A3DTessMarkupData pData);
        public static PFA3DTessMarkupGet A3DTessMarkupGet = Marshal.GetDelegateForFunctionPointer<PFA3DTessMarkupGet>(Library.A3DGetProcAddress("A3DTessMarkupGet", 1));
        public delegate A3DStatus PFA3DTessMarkupCreate(ref A3DTessMarkupData pData, out IntPtr ppTess);
        public static PFA3DTessMarkupCreate A3DTessMarkupCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTessMarkupCreate>(Library.A3DGetProcAddress("A3DTessMarkupCreate", 1));
        public delegate A3DStatus PFA3DGraphicsGet(IntPtr pGraphics, ref A3DGraphicsData pData);
        public static PFA3DGraphicsGet A3DGraphicsGet = Marshal.GetDelegateForFunctionPointer<PFA3DGraphicsGet>(Library.A3DGetProcAddress("A3DGraphicsGet", 1));
        public delegate A3DStatus PFA3DGraphicsCreate(ref A3DGraphicsData pData, out IntPtr ppGraphics);
        public static PFA3DGraphicsCreate A3DGraphicsCreate = Marshal.GetDelegateForFunctionPointer<PFA3DGraphicsCreate>(Library.A3DGetProcAddress("A3DGraphicsCreate", 1));
        public delegate A3DStatus PFA3DGraphicsDelete(IntPtr pGraphics);
        public static PFA3DGraphicsDelete A3DGraphicsDelete = Marshal.GetDelegateForFunctionPointer<PFA3DGraphicsDelete>(Library.A3DGetProcAddress("A3DGraphicsDelete", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphStyleData(uint uiIndexStyle, ref A3DGraphStyleData pData);
        public static PFA3DGlobalGetGraphStyleData A3DGlobalGetGraphStyleData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphStyleData>(Library.A3DGetProcAddress("A3DGlobalGetGraphStyleData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphStyle(ref A3DGraphStyleData pData, out uint puiIndexStyle);
        public static PFA3DGlobalInsertGraphStyle A3DGlobalInsertGraphStyle = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphStyle>(Library.A3DGetProcAddress("A3DGlobalInsertGraphStyle", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphRgbColorData(uint uiIndexRgbColor, ref A3DGraphRgbColorData pData);
        public static PFA3DGlobalGetGraphRgbColorData A3DGlobalGetGraphRgbColorData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphRgbColorData>(Library.A3DGetProcAddress("A3DGlobalGetGraphRgbColorData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphRgbColor(ref A3DGraphRgbColorData pData, out uint puiIndexRgbColor);
        public static PFA3DGlobalInsertGraphRgbColor A3DGlobalInsertGraphRgbColor = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphRgbColor>(Library.A3DGetProcAddress("A3DGlobalInsertGraphRgbColor", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphLinePatternData(uint uiIndexLinePattern, ref A3DGraphLinePatternData pData);
        public static PFA3DGlobalGetGraphLinePatternData A3DGlobalGetGraphLinePatternData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphLinePatternData>(Library.A3DGetProcAddress("A3DGlobalGetGraphLinePatternData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphLinePattern(ref A3DGraphLinePatternData pData, out uint puiIndexLinePattern);
        public static PFA3DGlobalInsertGraphLinePattern A3DGlobalInsertGraphLinePattern = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphLinePattern>(Library.A3DGetProcAddress("A3DGlobalInsertGraphLinePattern", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphMaterialData(uint uiIndexMaterial, ref A3DGraphMaterialData pData);
        public static PFA3DGlobalGetGraphMaterialData A3DGlobalGetGraphMaterialData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphMaterialData>(Library.A3DGetProcAddress("A3DGlobalGetGraphMaterialData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphMaterial(ref A3DGraphMaterialData pData, out uint puiIndexMaterial);
        public static PFA3DGlobalInsertGraphMaterial A3DGlobalInsertGraphMaterial = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphMaterial>(Library.A3DGetProcAddress("A3DGlobalInsertGraphMaterial", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphPictureData(uint uiIndexPicture, ref A3DGraphPictureData pData);
        public static PFA3DGlobalGetGraphPictureData A3DGlobalGetGraphPictureData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphPictureData>(Library.A3DGetProcAddress("A3DGlobalGetGraphPictureData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphPicture(ref A3DGraphPictureData pData, out uint puiPictureIndex);
        public static PFA3DGlobalInsertGraphPicture A3DGlobalInsertGraphPicture = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphPicture>(Library.A3DGetProcAddress("A3DGlobalInsertGraphPicture", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphDottingPatternData(uint uiIndexDottingPattern, ref A3DGraphDottingPatternData pData);
        public static PFA3DGlobalGetGraphDottingPatternData A3DGlobalGetGraphDottingPatternData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphDottingPatternData>(Library.A3DGetProcAddress("A3DGlobalGetGraphDottingPatternData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphDottingPattern(ref A3DGraphDottingPatternData pData, out uint puiIndexDottingPattern);
        public static PFA3DGlobalInsertGraphDottingPattern A3DGlobalInsertGraphDottingPattern = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphDottingPattern>(Library.A3DGetProcAddress("A3DGlobalInsertGraphDottingPattern", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphHatchingPatternData(uint uiIndexHatchingPattern, ref A3DGraphHatchingPatternData pData);
        public static PFA3DGlobalGetGraphHatchingPatternData A3DGlobalGetGraphHatchingPatternData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphHatchingPatternData>(Library.A3DGetProcAddress("A3DGlobalGetGraphHatchingPatternData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphHatchingPattern(ref A3DGraphHatchingPatternData pData, out uint puiIndexHatchingPattern);
        public static PFA3DGlobalInsertGraphHatchingPattern A3DGlobalInsertGraphHatchingPattern = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphHatchingPattern>(Library.A3DGetProcAddress("A3DGlobalInsertGraphHatchingPattern", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphSolidPatternData(uint uiIndexSolidPattern, ref A3DGraphSolidPatternData pData);
        public static PFA3DGlobalGetGraphSolidPatternData A3DGlobalGetGraphSolidPatternData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphSolidPatternData>(Library.A3DGetProcAddress("A3DGlobalGetGraphSolidPatternData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphSolidPattern(ref A3DGraphSolidPatternData pData, out uint puiIndexSolidPattern);
        public static PFA3DGlobalInsertGraphSolidPattern A3DGlobalInsertGraphSolidPattern = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphSolidPattern>(Library.A3DGetProcAddress("A3DGlobalInsertGraphSolidPattern", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphVPicturePatternData(uint uiIndexVPicturePattern, ref A3DGraphVPicturePatternData pData);
        public static PFA3DGlobalGetGraphVPicturePatternData A3DGlobalGetGraphVPicturePatternData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphVPicturePatternData>(Library.A3DGetProcAddress("A3DGlobalGetGraphVPicturePatternData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphVPicturePattern(ref A3DGraphVPicturePatternData pData, out uint puiIndexVPicturePattern);
        public static PFA3DGlobalInsertGraphVPicturePattern A3DGlobalInsertGraphVPicturePattern = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphVPicturePattern>(Library.A3DGetProcAddress("A3DGlobalInsertGraphVPicturePattern", 1));
        public delegate A3DStatus PFA3DGraphCameraGet(IntPtr pCamera, ref A3DGraphCameraData pData);
        public static PFA3DGraphCameraGet A3DGraphCameraGet = Marshal.GetDelegateForFunctionPointer<PFA3DGraphCameraGet>(Library.A3DGetProcAddress("A3DGraphCameraGet", 1));
        public delegate A3DStatus PFA3DGraphCameraCreate(ref A3DGraphCameraData pData, out IntPtr ppCamera);
        public static PFA3DGraphCameraCreate A3DGraphCameraCreate = Marshal.GetDelegateForFunctionPointer<PFA3DGraphCameraCreate>(Library.A3DGetProcAddress("A3DGraphCameraCreate", 1));
        public delegate A3DStatus PFA3DGraphAmbientLightGet(IntPtr pLight, ref A3DGraphAmbientLightData pData);
        public static PFA3DGraphAmbientLightGet A3DGraphAmbientLightGet = Marshal.GetDelegateForFunctionPointer<PFA3DGraphAmbientLightGet>(Library.A3DGetProcAddress("A3DGraphAmbientLightGet", 1));
        public delegate A3DStatus PFA3DGraphAmbientLightCreate(ref A3DGraphAmbientLightData pData, out IntPtr ppLight);
        public static PFA3DGraphAmbientLightCreate A3DGraphAmbientLightCreate = Marshal.GetDelegateForFunctionPointer<PFA3DGraphAmbientLightCreate>(Library.A3DGetProcAddress("A3DGraphAmbientLightCreate", 1));
        public delegate A3DStatus PFA3DGraphPointLightGet(IntPtr pLight, ref A3DGraphPointLightData pData);
        public static PFA3DGraphPointLightGet A3DGraphPointLightGet = Marshal.GetDelegateForFunctionPointer<PFA3DGraphPointLightGet>(Library.A3DGetProcAddress("A3DGraphPointLightGet", 1));
        public delegate A3DStatus PFA3DGraphPointLightCreate(ref A3DGraphPointLightData pData, out IntPtr ppLight);
        public static PFA3DGraphPointLightCreate A3DGraphPointLightCreate = Marshal.GetDelegateForFunctionPointer<PFA3DGraphPointLightCreate>(Library.A3DGetProcAddress("A3DGraphPointLightCreate", 1));
        public delegate A3DStatus PFA3DGraphSpotLightGet(IntPtr pLight, ref A3DGraphSpotLightData pData);
        public static PFA3DGraphSpotLightGet A3DGraphSpotLightGet = Marshal.GetDelegateForFunctionPointer<PFA3DGraphSpotLightGet>(Library.A3DGetProcAddress("A3DGraphSpotLightGet", 1));
        public delegate A3DStatus PFA3DGraphSpotLightCreate(ref A3DGraphSpotLightData pData, out IntPtr ppLight);
        public static PFA3DGraphSpotLightCreate A3DGraphSpotLightCreate = Marshal.GetDelegateForFunctionPointer<PFA3DGraphSpotLightCreate>(Library.A3DGetProcAddress("A3DGraphSpotLightCreate", 1));
        public delegate A3DStatus PFA3DGraphDirectionalLightGet(IntPtr pLight, ref A3DGraphDirectionalLightData pData);
        public static PFA3DGraphDirectionalLightGet A3DGraphDirectionalLightGet = Marshal.GetDelegateForFunctionPointer<PFA3DGraphDirectionalLightGet>(Library.A3DGetProcAddress("A3DGraphDirectionalLightGet", 1));
        public delegate A3DStatus PFA3DGraphDirectionalLightCreate(ref A3DGraphDirectionalLightData pData, out IntPtr ppLight);
        public static PFA3DGraphDirectionalLightCreate A3DGraphDirectionalLightCreate = Marshal.GetDelegateForFunctionPointer<PFA3DGraphDirectionalLightCreate>(Library.A3DGetProcAddress("A3DGraphDirectionalLightCreate", 1));
        public delegate A3DStatus PFA3DGraphSceneDisplayParametersGet(IntPtr pSceneDisplayParameters, ref A3DGraphSceneDisplayParametersData pData);
        public static PFA3DGraphSceneDisplayParametersGet A3DGraphSceneDisplayParametersGet = Marshal.GetDelegateForFunctionPointer<PFA3DGraphSceneDisplayParametersGet>(Library.A3DGetProcAddress("A3DGraphSceneDisplayParametersGet", 1));
        public delegate A3DStatus PFA3DGraphSceneDisplayParametersCreate(ref A3DGraphSceneDisplayParametersData pData, out IntPtr ppSceneDisplayParameters);
        public static PFA3DGraphSceneDisplayParametersCreate A3DGraphSceneDisplayParametersCreate = Marshal.GetDelegateForFunctionPointer<PFA3DGraphSceneDisplayParametersCreate>(Library.A3DGetProcAddress("A3DGraphSceneDisplayParametersCreate", 1));
        public delegate A3DStatus PFA3DMiscCascadedAttributesCreate(out IntPtr ppAttr);
        public static PFA3DMiscCascadedAttributesCreate A3DMiscCascadedAttributesCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMiscCascadedAttributesCreate>(Library.A3DGetProcAddress("A3DMiscCascadedAttributesCreate", 1));
        public delegate A3DStatus PFA3DMiscCascadedAttributesDelete(IntPtr pAttr);
        public static PFA3DMiscCascadedAttributesDelete A3DMiscCascadedAttributesDelete = Marshal.GetDelegateForFunctionPointer<PFA3DMiscCascadedAttributesDelete>(Library.A3DGetProcAddress("A3DMiscCascadedAttributesDelete", 1));
        public delegate A3DStatus PFA3DMiscCascadedAttributesGet(IntPtr pAttr, ref A3DMiscCascadedAttributesData psData);
        public static PFA3DMiscCascadedAttributesGet A3DMiscCascadedAttributesGet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscCascadedAttributesGet>(Library.A3DGetProcAddress("A3DMiscCascadedAttributesGet", 1));
        public delegate A3DStatus PFA3DMiscCascadedAttributesPush(IntPtr pAttr, IntPtr pBase, IntPtr pFather);
        public static PFA3DMiscCascadedAttributesPush A3DMiscCascadedAttributesPush = Marshal.GetDelegateForFunctionPointer<PFA3DMiscCascadedAttributesPush>(Library.A3DGetProcAddress("A3DMiscCascadedAttributesPush", 1));
        public delegate A3DStatus PFA3DMiscCascadedAttributesPushTessFace(IntPtr pAttr, IntPtr pRepItem, IntPtr pTessBase, ref A3DTessFaceData psTessFaceData, uint uiFaceIndex, IntPtr pFather);
        public static PFA3DMiscCascadedAttributesPushTessFace A3DMiscCascadedAttributesPushTessFace = Marshal.GetDelegateForFunctionPointer<PFA3DMiscCascadedAttributesPushTessFace>(Library.A3DGetProcAddress("A3DMiscCascadedAttributesPushTessFace", 1));
        public delegate A3DStatus PFA3DMiscCascadedAttributesEntityReferencePush(IntPtr pAttr, IntPtr pOccurrence, out IntPtr ppPtr);
        public static PFA3DMiscCascadedAttributesEntityReferencePush A3DMiscCascadedAttributesEntityReferencePush = Marshal.GetDelegateForFunctionPointer<PFA3DMiscCascadedAttributesEntityReferencePush>(Library.A3DGetProcAddress("A3DMiscCascadedAttributesEntityReferencePush", 1));
        public delegate A3DStatus PFA3DMiscPointerFromIndexGet(uint uiIndex, A3DEEntityType eType, out IntPtr ppEntity);
        public static PFA3DMiscPointerFromIndexGet A3DMiscPointerFromIndexGet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscPointerFromIndexGet>(Library.A3DGetProcAddress("A3DMiscPointerFromIndexGet", 1));
        public delegate A3DStatus PFA3DMiscRootBaseInsertAttribute(IntPtr pRootBase, IntPtr pAttribute);
        public static PFA3DMiscRootBaseInsertAttribute A3DMiscRootBaseInsertAttribute = Marshal.GetDelegateForFunctionPointer<PFA3DMiscRootBaseInsertAttribute>(Library.A3DGetProcAddress("A3DMiscRootBaseInsertAttribute", 1));
        public delegate A3DStatus PFA3DMiscGeneralTransformationGet(IntPtr pGeneralTransformation3d, ref A3DMiscGeneralTransformationData pData);
        public static PFA3DMiscGeneralTransformationGet A3DMiscGeneralTransformationGet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscGeneralTransformationGet>(Library.A3DGetProcAddress("A3DMiscGeneralTransformationGet", 1));
        public delegate A3DStatus PFA3DMiscGeneralTransformationCreate(ref A3DMiscGeneralTransformationData pData, out IntPtr ppGeneralTransformation3d);
        public static PFA3DMiscGeneralTransformationCreate A3DMiscGeneralTransformationCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMiscGeneralTransformationCreate>(Library.A3DGetProcAddress("A3DMiscGeneralTransformationCreate", 1));
        public delegate A3DStatus PFA3DMiscCartesianTransformationGet(IntPtr pCartesianTransformation3d, ref A3DMiscCartesianTransformationData pData);
        public static PFA3DMiscCartesianTransformationGet A3DMiscCartesianTransformationGet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscCartesianTransformationGet>(Library.A3DGetProcAddress("A3DMiscCartesianTransformationGet", 1));
        public delegate A3DStatus PFA3DMiscCartesianTransformationCreate(ref A3DMiscCartesianTransformationData pData, out IntPtr ppCartesianTransformation3d);
        public static PFA3DMiscCartesianTransformationCreate A3DMiscCartesianTransformationCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMiscCartesianTransformationCreate>(Library.A3DGetProcAddress("A3DMiscCartesianTransformationCreate", 1));
        public delegate A3DStatus PFA3DMiscEntityReferenceGet(IntPtr pEntityReference, ref A3DMiscEntityReferenceData pData);
        public static PFA3DMiscEntityReferenceGet A3DMiscEntityReferenceGet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscEntityReferenceGet>(Library.A3DGetProcAddress("A3DMiscEntityReferenceGet", 1));
        public delegate A3DStatus PFA3DMiscEntityReferenceCreate(ref A3DMiscEntityReferenceData pData, out IntPtr ppEntityReference);
        public static PFA3DMiscEntityReferenceCreate A3DMiscEntityReferenceCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMiscEntityReferenceCreate>(Library.A3DGetProcAddress("A3DMiscEntityReferenceCreate", 1));
        public delegate A3DStatus PFA3DMiscEntityReferenceSet(IntPtr pEntityReference, ref A3DMiscEntityReferenceData pData);
        public static PFA3DMiscEntityReferenceSet A3DMiscEntityReferenceSet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscEntityReferenceSet>(Library.A3DGetProcAddress("A3DMiscEntityReferenceSet", 1));
        public delegate A3DStatus PFA3DMiscReferenceOnTopologyGet(IntPtr pReferenceOnTopoItem, ref A3DMiscReferenceOnTopologyData pData);
        public static PFA3DMiscReferenceOnTopologyGet A3DMiscReferenceOnTopologyGet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscReferenceOnTopologyGet>(Library.A3DGetProcAddress("A3DMiscReferenceOnTopologyGet", 1));
        public delegate A3DStatus PFA3DMiscReferenceOnTessGet(IntPtr pReferenceOnTess, ref A3DMiscReferenceOnTessData pData);
        public static PFA3DMiscReferenceOnTessGet A3DMiscReferenceOnTessGet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscReferenceOnTessGet>(Library.A3DGetProcAddress("A3DMiscReferenceOnTessGet", 1));
        public delegate A3DStatus PFA3DMiscReferenceOnTessCreate(ref A3DMiscReferenceOnTessData pData, out IntPtr ppReferenceOnTess);
        public static PFA3DMiscReferenceOnTessCreate A3DMiscReferenceOnTessCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMiscReferenceOnTessCreate>(Library.A3DGetProcAddress("A3DMiscReferenceOnTessCreate", 1));
        public delegate A3DStatus PFA3DMiscReferenceOnTopologyCreate(ref A3DMiscReferenceOnTopologyData pData, out IntPtr ppReferenceOnTopoItem);
        public static PFA3DMiscReferenceOnTopologyCreate A3DMiscReferenceOnTopologyCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMiscReferenceOnTopologyCreate>(Library.A3DGetProcAddress("A3DMiscReferenceOnTopologyCreate", 1));
        public delegate A3DStatus PFA3DMiscReferenceOnCsysItemGet(IntPtr pReferenceOnCSYSItem, ref A3DMiscReferenceOnCsysItemData pData);
        public static PFA3DMiscReferenceOnCsysItemGet A3DMiscReferenceOnCsysItemGet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscReferenceOnCsysItemGet>(Library.A3DGetProcAddress("A3DMiscReferenceOnCsysItemGet", 1));
        public delegate A3DStatus PFA3DMiscReferenceOnCsysItemCreate(ref A3DMiscReferenceOnCsysItemData pData, out IntPtr ppReferenceOnCSYSItem);
        public static PFA3DMiscReferenceOnCsysItemCreate A3DMiscReferenceOnCsysItemCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMiscReferenceOnCsysItemCreate>(Library.A3DGetProcAddress("A3DMiscReferenceOnCsysItemCreate", 1));
        public delegate A3DStatus PFA3DMiscUTF8ToUnicode([MarshalAs(UnmanagedType.LPStr)] string pcInputBuffer, IntPtr acOutputBuffer);
        public static PFA3DMiscUTF8ToUnicode A3DMiscUTF8ToUnicode = Marshal.GetDelegateForFunctionPointer<PFA3DMiscUTF8ToUnicode>(Library.A3DGetProcAddress("A3DMiscUTF8ToUnicode", 1));
        public delegate A3DStatus PFA3DMiscUnicodeToUTF8([MarshalAs(UnmanagedType.LPStr)] string pcInputBuffer, IntPtr acOutputBuffer);
        public static PFA3DMiscUnicodeToUTF8 A3DMiscUnicodeToUTF8 = Marshal.GetDelegateForFunctionPointer<PFA3DMiscUnicodeToUTF8>(Library.A3DGetProcAddress("A3DMiscUnicodeToUTF8", 1));
        public delegate A3DStatus PFA3DMiscUTF8ToUTF16([MarshalAs(UnmanagedType.LPStr)] string pcInputBuffer, IntPtr acOutputBuffer);
        public static PFA3DMiscUTF8ToUTF16 A3DMiscUTF8ToUTF16 = Marshal.GetDelegateForFunctionPointer<PFA3DMiscUTF8ToUTF16>(Library.A3DGetProcAddress("A3DMiscUTF8ToUTF16", 1));
        public delegate A3DStatus PFA3DMiscUTF16ToUTF8([MarshalAs(UnmanagedType.LPStr)] string pcInputBuffer, IntPtr acOutputBuffer);
        public static PFA3DMiscUTF16ToUTF8 A3DMiscUTF16ToUTF8 = Marshal.GetDelegateForFunctionPointer<PFA3DMiscUTF16ToUTF8>(Library.A3DGetProcAddress("A3DMiscUTF16ToUTF8", 1));
        public delegate byte PFA3DMiscGetErrorMsg(A3DStatus arg1);
        public static PFA3DMiscGetErrorMsg A3DMiscGetErrorMsg = Marshal.GetDelegateForFunctionPointer<PFA3DMiscGetErrorMsg>(Library.A3DGetProcAddress("A3DMiscGetErrorMsg", 1));
        public delegate byte PFA3DMiscGetEntityTypeMsg(A3DEEntityType eType);
        public static PFA3DMiscGetEntityTypeMsg A3DMiscGetEntityTypeMsg = Marshal.GetDelegateForFunctionPointer<PFA3DMiscGetEntityTypeMsg>(Library.A3DGetProcAddress("A3DMiscGetEntityTypeMsg", 1));
        public delegate A3DStatus PFA3DMiscGetMaterialProperties(IntPtr pEntity, ref A3DMiscMaterialPropertiesData pMaterialPropertiesData);
        public static PFA3DMiscGetMaterialProperties A3DMiscGetMaterialProperties = Marshal.GetDelegateForFunctionPointer<PFA3DMiscGetMaterialProperties>(Library.A3DGetProcAddress("A3DMiscGetMaterialProperties", 1));
        public delegate A3DStatus PFA3DMiscGetBoundingBox(IntPtr pEntity, ref A3DBoundingBoxData pAABB);
        public static PFA3DMiscGetBoundingBox A3DMiscGetBoundingBox = Marshal.GetDelegateForFunctionPointer<PFA3DMiscGetBoundingBox>(Library.A3DGetProcAddress("A3DMiscGetBoundingBox", 1));
        public delegate A3DStatus PFA3DMiscComputeBoundingBox(IntPtr pEntity, out double pOptPlacement, ref A3DBoundingBoxData pAABB);
        public static PFA3DMiscComputeBoundingBox A3DMiscComputeBoundingBox = Marshal.GetDelegateForFunctionPointer<PFA3DMiscComputeBoundingBox>(Library.A3DGetProcAddress("A3DMiscComputeBoundingBox", 1));
        public delegate A3DStatus PFA3DAsmModelFileGet(IntPtr pModelFile, ref A3DAsmModelFileData pData);
        public static PFA3DAsmModelFileGet A3DAsmModelFileGet = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileGet>(Library.A3DGetProcAddress("A3DAsmModelFileGet", 1));
        public delegate A3DStatus PFA3DAsmModelFileCreate(ref A3DAsmModelFileData pData, out IntPtr ppModelFile);
        public static PFA3DAsmModelFileCreate A3DAsmModelFileCreate = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileCreate>(Library.A3DGetProcAddress("A3DAsmModelFileCreate", 1));
        public delegate A3DStatus PFA3DAsmModelFileDelete(IntPtr pModelFile);
        public static PFA3DAsmModelFileDelete A3DAsmModelFileDelete = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileDelete>(Library.A3DGetProcAddress("A3DAsmModelFileDelete", 1));
        public delegate A3DStatus PFA3DAsmModelFileUnloadParts(IntPtr pModelFile, uint uiPartsSize, out IntPtr ppParts);
        public static PFA3DAsmModelFileUnloadParts A3DAsmModelFileUnloadParts = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileUnloadParts>(Library.A3DGetProcAddress("A3DAsmModelFileUnloadParts", 1));
        public delegate A3DStatus PFA3DAsmModelFileGetUnit(IntPtr pModelFile, out double pdUnit);
        public static PFA3DAsmModelFileGetUnit A3DAsmModelFileGetUnit = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileGetUnit>(Library.A3DGetProcAddress("A3DAsmModelFileGetUnit", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGet(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceData pData);
        public static PFA3DAsmProductOccurrenceGet A3DAsmProductOccurrenceGet = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGet>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGet", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceCreate(ref A3DAsmProductOccurrenceData pData, out IntPtr ppProductOccurrence);
        public static PFA3DAsmProductOccurrenceCreate A3DAsmProductOccurrenceCreate = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceCreate>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceCreate", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceSetProductPrototype(IntPtr pProductOccurrence, IntPtr pProductPrototype);
        public static PFA3DAsmProductOccurrenceSetProductPrototype A3DAsmProductOccurrenceSetProductPrototype = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceSetProductPrototype>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceSetProductPrototype", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceUnload(IntPtr pProductOccurrence);
        public static PFA3DAsmProductOccurrenceUnload A3DAsmProductOccurrenceUnload = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceUnload>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceUnload", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetFilePathName(IntPtr pProductOccurrence, IntPtr ppcFileName);
        public static PFA3DAsmProductOccurrenceGetFilePathName A3DAsmProductOccurrenceGetFilePathName = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetFilePathName>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetFilePathName", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetOriginalFilePathName(IntPtr pProductOccurrence, IntPtr ppcFileName);
        public static PFA3DAsmProductOccurrenceGetOriginalFilePathName A3DAsmProductOccurrenceGetOriginalFilePathName = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetOriginalFilePathName>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetOriginalFilePathName", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceAddView(IntPtr pProductOccurrence, IntPtr pView);
        public static PFA3DAsmProductOccurrenceAddView A3DAsmProductOccurrenceAddView = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceAddView>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceAddView", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceEdit(ref A3DAsmProductOccurrenceData pData, IntPtr pProductOccurrence);
        public static PFA3DAsmProductOccurrenceEdit A3DAsmProductOccurrenceEdit = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceEdit>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceEdit", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceDeepCopy(IntPtr pProductOccurrence, out IntPtr ppNewProductOccurrence);
        public static PFA3DAsmProductOccurrenceDeepCopy A3DAsmProductOccurrenceDeepCopy = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceDeepCopy>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceDeepCopy", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetFather(IntPtr pProductOccurrence, out IntPtr ppProductOccurrenceFather);
        public static PFA3DAsmProductOccurrenceGetFather A3DAsmProductOccurrenceGetFather = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetFather>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetFather", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetSLW(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceDataSLW pData);
        public static PFA3DAsmProductOccurrenceGetSLW A3DAsmProductOccurrenceGetSLW = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetSLW>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetSLW", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetCat(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceDataCat pData);
        public static PFA3DAsmProductOccurrenceGetCat A3DAsmProductOccurrenceGetCat = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetCat>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetCat", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetCV5(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceDataCV5 pData);
        public static PFA3DAsmProductOccurrenceGetCV5 A3DAsmProductOccurrenceGetCV5 = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetCV5>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetCV5", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetUg(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceDataUg pData);
        public static PFA3DAsmProductOccurrenceGetUg A3DAsmProductOccurrenceGetUg = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetUg>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetUg", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetProe(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceDataProe pData);
        public static PFA3DAsmProductOccurrenceGetProe A3DAsmProductOccurrenceGetProe = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetProe>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetProe", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetInv(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceDataInv pData);
        public static PFA3DAsmProductOccurrenceGetInv A3DAsmProductOccurrenceGetInv = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetInv>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetInv", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetJT(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceDataJT pData);
        public static PFA3DAsmProductOccurrenceGetJT A3DAsmProductOccurrenceGetJT = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetJT>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetJT", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetLayerList(IntPtr pProductOccurrence, out uint piLayers, IntPtr ppLayerArray);
        public static PFA3DAsmProductOccurrenceGetLayerList A3DAsmProductOccurrenceGetLayerList = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetLayerList>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetLayerList", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetIdentifier(IntPtr pProductOccurrence, IntPtr ppcIdentifier);
        public static PFA3DAsmProductOccurrenceGetIdentifier A3DAsmProductOccurrenceGetIdentifier = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetIdentifier>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetIdentifier", 1));
        public delegate A3DStatus PFA3DAsmPartDefinitionGet(IntPtr pPartDefinition, ref A3DAsmPartDefinitionData pData);
        public static PFA3DAsmPartDefinitionGet A3DAsmPartDefinitionGet = Marshal.GetDelegateForFunctionPointer<PFA3DAsmPartDefinitionGet>(Library.A3DGetProcAddress("A3DAsmPartDefinitionGet", 1));
        public delegate A3DStatus PFA3DAsmPartDefinitionCreate(ref A3DAsmPartDefinitionData pData, out IntPtr ppPartDefinition);
        public static PFA3DAsmPartDefinitionCreate A3DAsmPartDefinitionCreate = Marshal.GetDelegateForFunctionPointer<PFA3DAsmPartDefinitionCreate>(Library.A3DGetProcAddress("A3DAsmPartDefinitionCreate", 1));
        public delegate A3DStatus PFA3DDrawingGetReferencesList(IntPtr pPartDefinition, out uint puiNumberOfFilePaths, IntPtr pppcSrcFilePaths);
        public static PFA3DDrawingGetReferencesList A3DDrawingGetReferencesList = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingGetReferencesList>(Library.A3DGetProcAddress("A3DDrawingGetReferencesList", 1));
        public delegate A3DStatus PFA3DAsmPartDefinitionAddView(IntPtr pPartDefinition, IntPtr pView);
        public static PFA3DAsmPartDefinitionAddView A3DAsmPartDefinitionAddView = Marshal.GetDelegateForFunctionPointer<PFA3DAsmPartDefinitionAddView>(Library.A3DGetProcAddress("A3DAsmPartDefinitionAddView", 1));
        public delegate A3DStatus PFA3DAsmPartDefinitionEdit(ref A3DAsmPartDefinitionData pData, IntPtr pPartDefinition);
        public static PFA3DAsmPartDefinitionEdit A3DAsmPartDefinitionEdit = Marshal.GetDelegateForFunctionPointer<PFA3DAsmPartDefinitionEdit>(Library.A3DGetProcAddress("A3DAsmPartDefinitionEdit", 1));
        public delegate A3DStatus PFA3DAsmFilterGet(IntPtr pFilter, ref A3DAsmFilterData pData);
        public static PFA3DAsmFilterGet A3DAsmFilterGet = Marshal.GetDelegateForFunctionPointer<PFA3DAsmFilterGet>(Library.A3DGetProcAddress("A3DAsmFilterGet", 1));
        public delegate A3DStatus PFA3DAsmFilterCreate(ref A3DAsmFilterData pData, out IntPtr ppFilter);
        public static PFA3DAsmFilterCreate A3DAsmFilterCreate = Marshal.GetDelegateForFunctionPointer<PFA3DAsmFilterCreate>(Library.A3DGetProcAddress("A3DAsmFilterCreate", 1));
        public delegate A3DStatus PFA3DAsmGetFixedComponents(IntPtr pOwnerNode, out uint puiNumberOfFixedSubNodes, IntPtr pppFixedSubNodes);
        public static PFA3DAsmGetFixedComponents A3DAsmGetFixedComponents = Marshal.GetDelegateForFunctionPointer<PFA3DAsmGetFixedComponents>(Library.A3DGetProcAddress("A3DAsmGetFixedComponents", 1));
        public delegate A3DStatus PFA3DAsmGetFixedTogetherComponents(IntPtr pOwnerNode, out uint ppuiSizeCount, IntPtr ppuiSizeArray, IntPtr pppFixedTogetherNodes);
        public static PFA3DAsmGetFixedTogetherComponents A3DAsmGetFixedTogetherComponents = Marshal.GetDelegateForFunctionPointer<PFA3DAsmGetFixedTogetherComponents>(Library.A3DGetProcAddress("A3DAsmGetFixedTogetherComponents", 1));
        public delegate A3DStatus PFA3DAsmGetFlexibleComponents(IntPtr pOwnerNode, out uint puiNumberOfFlexibleSubNodes, IntPtr pppFlexibleSubNodes);
        public static PFA3DAsmGetFlexibleComponents A3DAsmGetFlexibleComponents = Marshal.GetDelegateForFunctionPointer<PFA3DAsmGetFlexibleComponents>(Library.A3DGetProcAddress("A3DAsmGetFlexibleComponents", 1));
        public delegate A3DStatus PFA3DAsmModelFileLoadFromFile([MarshalAs(UnmanagedType.LPStr)] string pcFileName, ref A3DRWParamsLoadData pLoadParametersData, out IntPtr ppModelFile);
        public static PFA3DAsmModelFileLoadFromFile A3DAsmModelFileLoadFromFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileLoadFromFile>(Library.A3DGetProcAddress("A3DAsmModelFileLoadFromFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileLoadFromPrcStream([MarshalAs(UnmanagedType.LPStr)] string pcBufferStream, uint uBufferLength, out IntPtr ppPrcReadHelper, out IntPtr ppModelFile);
        public static PFA3DAsmModelFileLoadFromPrcStream A3DAsmModelFileLoadFromPrcStream = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileLoadFromPrcStream>(Library.A3DGetProcAddress("A3DAsmModelFileLoadFromPrcStream", 1));
        public delegate void PFA3DRWParamsPrcReadHelperFree(IntPtr pA3DRWParamsPrcReadHelper);
        public static PFA3DRWParamsPrcReadHelperFree A3DRWParamsPrcReadHelperFree = Marshal.GetDelegateForFunctionPointer<PFA3DRWParamsPrcReadHelperFree>(Library.A3DGetProcAddress("A3DRWParamsPrcReadHelperFree", 1));
        public delegate A3DStatus PFA3DAsmModelFileLoadFromPrcFile([MarshalAs(UnmanagedType.LPStr)] string pcFileName, out IntPtr ppPrcReadHelper, out IntPtr ppModelFile);
        public static PFA3DAsmModelFileLoadFromPrcFile A3DAsmModelFileLoadFromPrcFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileLoadFromPrcFile>(Library.A3DGetProcAddress("A3DAsmModelFileLoadFromPrcFile", 1));
        public delegate A3DStatus PFA3DGet3DPDFStreams([MarshalAs(UnmanagedType.LPStr)] string pcFileName, IntPtr ppStreamData, out int piNumStreams);
        public static PFA3DGet3DPDFStreams A3DGet3DPDFStreams = Marshal.GetDelegateForFunctionPointer<PFA3DGet3DPDFStreams>(Library.A3DGetProcAddress("A3DGet3DPDFStreams", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToPrcFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportPrcData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName, out IntPtr ppPrcWriteHelper);
        public static PFA3DAsmModelFileExportToPrcFile A3DAsmModelFileExportToPrcFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToPrcFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToPrcFile", 1));
        public delegate void PFA3DRWParamsPrcWriteHelperFree(IntPtr pA3DRWParamsPrcWriteHelper);
        public static PFA3DRWParamsPrcWriteHelperFree A3DRWParamsPrcWriteHelperFree = Marshal.GetDelegateForFunctionPointer<PFA3DRWParamsPrcWriteHelperFree>(Library.A3DGetProcAddress("A3DRWParamsPrcWriteHelperFree", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToU3DFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportU3DData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToU3DFile A3DAsmModelFileExportToU3DFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToU3DFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToU3DFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToStepFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportStepData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToStepFile A3DAsmModelFileExportToStepFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToStepFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToStepFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToJTFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportJTData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToJTFile A3DAsmModelFileExportToJTFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToJTFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToJTFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToVrmlFile(IntPtr pA3DAsmModelFile, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToVrmlFile A3DAsmModelFileExportToVrmlFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToVrmlFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToVrmlFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToIgesFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportIgesData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToIgesFile A3DAsmModelFileExportToIgesFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToIgesFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToIgesFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToStlFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportStlData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToStlFile A3DAsmModelFileExportToStlFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToStlFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToStlFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportTo3mfFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExport3mfData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportTo3mfFile A3DAsmModelFileExportTo3mfFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportTo3mfFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportTo3mfFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToXMLFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportXMLData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcXMLFileName, IntPtr uMapSize, IntPtr puMapXmlIds, IntPtr ppMapProductOccurrences);
        public static PFA3DAsmModelFileExportToXMLFile A3DAsmModelFileExportToXMLFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToXMLFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToXMLFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToObjFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportObjData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToObjFile A3DAsmModelFileExportToObjFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToObjFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToObjFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToFbxFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportFbxData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToFbxFile A3DAsmModelFileExportToFbxFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToFbxFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToFbxFile", 1));
        public delegate A3DStatus PFA3DCrvGetInterval(IntPtr pCrv, ref A3DIntervalData pInterval);
        public static PFA3DCrvGetInterval A3DCrvGetInterval = Marshal.GetDelegateForFunctionPointer<PFA3DCrvGetInterval>(Library.A3DGetProcAddress("A3DCrvGetInterval", 1));
        public delegate A3DStatus PFA3DCrvEvaluate(IntPtr pCrv, double dParameter, uint uiNbDerivatives, ref A3DVector3dData pPointAndDerivatives);
        public static PFA3DCrvEvaluate A3DCrvEvaluate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvEvaluate>(Library.A3DGetProcAddress("A3DCrvEvaluate", 1));
        public delegate A3DStatus PFA3DCrvEvaluatePointAndNormal(IntPtr psCrv, double dParameter, uint uiNbSurfaces, out IntPtr ppsSurfaces, uint uiNbDerivatives, ref A3DVector3dData psPointAndDerivatives, ref A3DVector3dData psNormal);
        public static PFA3DCrvEvaluatePointAndNormal A3DCrvEvaluatePointAndNormal = Marshal.GetDelegateForFunctionPointer<PFA3DCrvEvaluatePointAndNormal>(Library.A3DGetProcAddress("A3DCrvEvaluatePointAndNormal", 1));
        public delegate A3DStatus PFA3DCrvIsPeriodic(IntPtr pCrv, out bool pbIsPeriodic);
        public static PFA3DCrvIsPeriodic A3DCrvIsPeriodic = Marshal.GetDelegateForFunctionPointer<PFA3DCrvIsPeriodic>(Library.A3DGetProcAddress("A3DCrvIsPeriodic", 1));
        public delegate A3DStatus PFA3DSrfGetDomain(IntPtr pSrf, ref A3DDomainData pDomain);
        public static PFA3DSrfGetDomain A3DSrfGetDomain = Marshal.GetDelegateForFunctionPointer<PFA3DSrfGetDomain>(Library.A3DGetProcAddress("A3DSrfGetDomain", 1));
        public delegate A3DStatus PFA3DSurfEvaluate(IntPtr pSurf, ref A3DVector2dData pUVParameter, uint uiNbDerivatives, ref A3DVector3dData pPointAndDerivatives);
        public static PFA3DSurfEvaluate A3DSurfEvaluate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfEvaluate>(Library.A3DGetProcAddress("A3DSurfEvaluate", 1));
        public delegate A3DStatus PFA3DSurfIsDegenerated(IntPtr pSurf, ref A3DVector2dData pUVParameter, double dTolerance, out bool pbIsDegenerated, out bool pbUDirection);
        public static PFA3DSurfIsDegenerated A3DSurfIsDegenerated = Marshal.GetDelegateForFunctionPointer<PFA3DSurfIsDegenerated>(Library.A3DGetProcAddress("A3DSurfIsDegenerated", 1));
        public delegate A3DStatus PFA3DSurfIsPeriodic(IntPtr pSrf, out bool pbUIsPeriodic, out bool pbVIsPeriodic);
        public static PFA3DSurfIsPeriodic A3DSurfIsPeriodic = Marshal.GetDelegateForFunctionPointer<PFA3DSurfIsPeriodic>(Library.A3DGetProcAddress("A3DSurfIsPeriodic", 1));
        public delegate A3DStatus PFA3DSurfIsG1Continuous(IntPtr pSurf, ref A3DVector2dData pUVParameter, double dAngleTolerance, out bool pbUG1Continuous, out bool pbVG1Continuous);
        public static PFA3DSurfIsG1Continuous A3DSurfIsG1Continuous = Marshal.GetDelegateForFunctionPointer<PFA3DSurfIsG1Continuous>(Library.A3DGetProcAddress("A3DSurfIsG1Continuous", 1));
        public delegate A3DStatus PFA3DGetCurveAsAnalytic(IntPtr pCurve, double dTol, out IntPtr pAnalyticCurve, ref A3DEAnalyticType peAnalyticType);
        public static PFA3DGetCurveAsAnalytic A3DGetCurveAsAnalytic = Marshal.GetDelegateForFunctionPointer<PFA3DGetCurveAsAnalytic>(Library.A3DGetProcAddress("A3DGetCurveAsAnalytic", 1));
        public delegate A3DStatus PFA3DSimplifyCurveWithAnalytics(IntPtr pCurve, double dTol, uint uNbRecognizedType, IntPtr pOptRecognizedType, out IntPtr pAnalyticCurve, ref A3DEAnalyticType peAnalyticType);
        public static PFA3DSimplifyCurveWithAnalytics A3DSimplifyCurveWithAnalytics = Marshal.GetDelegateForFunctionPointer<PFA3DSimplifyCurveWithAnalytics>(Library.A3DGetProcAddress("A3DSimplifyCurveWithAnalytics", 1));
        public delegate A3DStatus PFA3DGetCurveAsAnalyticFromCoEdge(IntPtr pCoEdge, double dTol, out IntPtr pAnalyticCurve, ref A3DEAnalyticType peAnalyticType);
        public static PFA3DGetCurveAsAnalyticFromCoEdge A3DGetCurveAsAnalyticFromCoEdge = Marshal.GetDelegateForFunctionPointer<PFA3DGetCurveAsAnalyticFromCoEdge>(Library.A3DGetProcAddress("A3DGetCurveAsAnalyticFromCoEdge", 1));
        public delegate A3DStatus PFA3DSimplifyCurveWithAnalyticsFromCoEdge(IntPtr pCoEdge, double dTol, uint uNbRecognizedType, IntPtr pOptRecognizedType, out IntPtr pAnalyticCurve, ref A3DEAnalyticType peAnalyticType);
        public static PFA3DSimplifyCurveWithAnalyticsFromCoEdge A3DSimplifyCurveWithAnalyticsFromCoEdge = Marshal.GetDelegateForFunctionPointer<PFA3DSimplifyCurveWithAnalyticsFromCoEdge>(Library.A3DGetProcAddress("A3DSimplifyCurveWithAnalyticsFromCoEdge", 1));
        public delegate A3DStatus PFA3DGetSurfaceAsAnalytic(IntPtr pSrf, double dTol, out IntPtr pAnalyticSurface, ref A3DEAnalyticType peAnalyticType);
        public static PFA3DGetSurfaceAsAnalytic A3DGetSurfaceAsAnalytic = Marshal.GetDelegateForFunctionPointer<PFA3DGetSurfaceAsAnalytic>(Library.A3DGetProcAddress("A3DGetSurfaceAsAnalytic", 1));
        public delegate A3DStatus PFA3DSimplifySurfaceWithAnalytics(IntPtr pSrf, double dTol, uint uNbRecognizedType, IntPtr pOptRecognizedType, out IntPtr pAnalyticSurface, ref A3DEAnalyticType peAnalyticType);
        public static PFA3DSimplifySurfaceWithAnalytics A3DSimplifySurfaceWithAnalytics = Marshal.GetDelegateForFunctionPointer<PFA3DSimplifySurfaceWithAnalytics>(Library.A3DGetProcAddress("A3DSimplifySurfaceWithAnalytics", 1));
        public delegate A3DStatus PFA3DCrvProjectPoint(IntPtr pCrv, ref A3DVector3dData pPointToProject, out uint puiNbSolutions, IntPtr ppdSolutionParameter, IntPtr ppdSolutionDistance);
        public static PFA3DCrvProjectPoint A3DCrvProjectPoint = Marshal.GetDelegateForFunctionPointer<PFA3DCrvProjectPoint>(Library.A3DGetProcAddress("A3DCrvProjectPoint", 1));
        public delegate A3DStatus PFA3DSurfProjectPoint(IntPtr pSurf, ref A3DVector3dData pPointToProject, out uint puiNbSolutions, IntPtr ppdSolutionParameters, IntPtr ppdSolutionDistance);
        public static PFA3DSurfProjectPoint A3DSurfProjectPoint = Marshal.GetDelegateForFunctionPointer<PFA3DSurfProjectPoint>(Library.A3DGetProcAddress("A3DSurfProjectPoint", 1));
        public delegate A3DStatus PFA3DCrvLocalProjectPoint(IntPtr pCrv, ref A3DVector3dData pPointToProject, double dGuessParameter, out bool pbFindSolution, out double pdSolutionParameter, out double pdSolutionDistance);
        public static PFA3DCrvLocalProjectPoint A3DCrvLocalProjectPoint = Marshal.GetDelegateForFunctionPointer<PFA3DCrvLocalProjectPoint>(Library.A3DGetProcAddress("A3DCrvLocalProjectPoint", 1));
        public delegate A3DStatus PFA3DSurfLocalProjectPoint(IntPtr pSurf, ref A3DVector3dData pPointToProject, ref A3DVector2dData pGuessPoint, out bool pbFindSolution, ref A3DVector2dData pSolutionParameter, out double pdSolutionDistance);
        public static PFA3DSurfLocalProjectPoint A3DSurfLocalProjectPoint = Marshal.GetDelegateForFunctionPointer<PFA3DSurfLocalProjectPoint>(Library.A3DGetProcAddress("A3DSurfLocalProjectPoint", 1));
        public delegate A3DStatus PFA3DSurfEvaluateNormal(IntPtr pSurf, ref A3DVector2dData pUVParameter, ref A3DVector3dData pNormal);
        public static PFA3DSurfEvaluateNormal A3DSurfEvaluateNormal = Marshal.GetDelegateForFunctionPointer<PFA3DSurfEvaluateNormal>(Library.A3DGetProcAddress("A3DSurfEvaluateNormal", 1));
        public delegate A3DStatus PFA3DSewBrep(IntPtr p, uint uNbBrepModels, double dTolerance, ref A3DSewOptionsData pData, IntPtr pBrepModelsOut, out uint uNbBrepOut);
        public static PFA3DSewBrep A3DSewBrep = Marshal.GetDelegateForFunctionPointer<PFA3DSewBrep>(Library.A3DGetProcAddress("A3DSewBrep", 1));
        public delegate A3DStatus PFA3DAsmModelFileSew(out IntPtr ppModelFile, double dToleranceInMM, ref A3DSewOptionsData pData);
        public static PFA3DAsmModelFileSew A3DAsmModelFileSew = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileSew>(Library.A3DGetProcAddress("A3DAsmModelFileSew", 1));
        public delegate A3DStatus PFA3DFaceUVPointInsideManagerCreate(ref A3DFaceUVPointInsideManagerData pData, out IntPtr pManager);
        public static PFA3DFaceUVPointInsideManagerCreate A3DFaceUVPointInsideManagerCreate = Marshal.GetDelegateForFunctionPointer<PFA3DFaceUVPointInsideManagerCreate>(Library.A3DGetProcAddress("A3DFaceUVPointInsideManagerCreate", 1));
        public delegate A3DStatus PFA3DFaceUVPointInsideManagerDelete(IntPtr pManager);
        public static PFA3DFaceUVPointInsideManagerDelete A3DFaceUVPointInsideManagerDelete = Marshal.GetDelegateForFunctionPointer<PFA3DFaceUVPointInsideManagerDelete>(Library.A3DGetProcAddress("A3DFaceUVPointInsideManagerDelete", 1));
        public delegate A3DStatus PFA3DFaceUVPointInside(IntPtr pManager, IntPtr psFace, ref A3DVector2dData pUVParameter, double dTol3D, out byte puiUVInFace);
        public static PFA3DFaceUVPointInside A3DFaceUVPointInside = Marshal.GetDelegateForFunctionPointer<PFA3DFaceUVPointInside>(Library.A3DGetProcAddress("A3DFaceUVPointInside", 1));
        public delegate A3DStatus PFA3DProjectPointCloud(uint uRiBrepModelSize, out IntPtr pRiBrepModel, uint uPointCloudSize, ref A3DVector3dData pPointCloudToProject, bool bUseExactComputation, uint uNbThreads, IntPtr ppProjectedPointCloud);
        public static PFA3DProjectPointCloud A3DProjectPointCloud = Marshal.GetDelegateForFunctionPointer<PFA3DProjectPointCloud>(Library.A3DGetProcAddress("A3DProjectPointCloud", 1));
        public delegate A3DStatus PFA3DProjectPointCloudManagerCreateFromRI(ref A3DProjectPointCloudManagerDataFromRI pData, out IntPtr pManager);
        public static PFA3DProjectPointCloudManagerCreateFromRI A3DProjectPointCloudManagerCreateFromRI = Marshal.GetDelegateForFunctionPointer<PFA3DProjectPointCloudManagerCreateFromRI>(Library.A3DGetProcAddress("A3DProjectPointCloudManagerCreateFromRI", 1));
        public delegate A3DStatus PFA3DProjectPointCloudManagerCreateFromModelFile(IntPtr pModelFile, out IntPtr pManager);
        public static PFA3DProjectPointCloudManagerCreateFromModelFile A3DProjectPointCloudManagerCreateFromModelFile = Marshal.GetDelegateForFunctionPointer<PFA3DProjectPointCloudManagerCreateFromModelFile>(Library.A3DGetProcAddress("A3DProjectPointCloudManagerCreateFromModelFile", 1));
        public delegate A3DStatus PFA3DProjectPointCloudManagerDelete(IntPtr pManager);
        public static PFA3DProjectPointCloudManagerDelete A3DProjectPointCloudManagerDelete = Marshal.GetDelegateForFunctionPointer<PFA3DProjectPointCloudManagerDelete>(Library.A3DGetProcAddress("A3DProjectPointCloudManagerDelete", 1));
        public delegate A3DStatus PFA3DProjectPointCloud2(IntPtr pManager, uint uPointCloudSize, ref A3DVector3dData pPointCloudToProject, bool bUseExactComputation, uint uNbThreads, double dInsidePointEdgeTolerance, IntPtr ppProjectedPointCloud);
        public static PFA3DProjectPointCloud2 A3DProjectPointCloud2 = Marshal.GetDelegateForFunctionPointer<PFA3DProjectPointCloud2>(Library.A3DGetProcAddress("A3DProjectPointCloud2", 1));
        public delegate A3DStatus PFA3DComputePlanarSectionOnRepresentationItem(IntPtr pRiBrepModel, ref A3DPlanarSectionData psSectionParametersData, out IntPtr ppRISectionResults);
        public static PFA3DComputePlanarSectionOnRepresentationItem A3DComputePlanarSectionOnRepresentationItem = Marshal.GetDelegateForFunctionPointer<PFA3DComputePlanarSectionOnRepresentationItem>(Library.A3DGetProcAddress("A3DComputePlanarSectionOnRepresentationItem", 1));
        public delegate A3DStatus PFA3DComputePlanarSectionOnModelFile(IntPtr pModelFile, ref A3DPlanarSectionData psSectionParametersData, out uint pNumberOfSections, IntPtr pppRISectionElements);
        public static PFA3DComputePlanarSectionOnModelFile A3DComputePlanarSectionOnModelFile = Marshal.GetDelegateForFunctionPointer<PFA3DComputePlanarSectionOnModelFile>(Library.A3DGetProcAddress("A3DComputePlanarSectionOnModelFile", 1));
        public delegate A3DStatus PFA3DCurveLength(IntPtr pCrv, ref A3DIntervalData pOptInterval, out double pdLength);
        public static PFA3DCurveLength A3DCurveLength = Marshal.GetDelegateForFunctionPointer<PFA3DCurveLength>(Library.A3DGetProcAddress("A3DCurveLength", 1));
        public delegate A3DStatus PFA3DCompareFaces(ref A3DCompareInputData pInput, ref A3DCompareOutputData pOutput);
        public static PFA3DCompareFaces A3DCompareFaces = Marshal.GetDelegateForFunctionPointer<PFA3DCompareFaces>(Library.A3DGetProcAddress("A3DCompareFaces", 1));
        public delegate A3DStatus PFA3DCompareFacesInBrepModels(IntPtr pFirstModelFile, IntPtr pSecondModelFile, double dTolerance, ref A3DCompareOutputData pOutput);
        public static PFA3DCompareFacesInBrepModels A3DCompareFacesInBrepModels = Marshal.GetDelegateForFunctionPointer<PFA3DCompareFacesInBrepModels>(Library.A3DGetProcAddress("A3DCompareFacesInBrepModels", 1));
        public delegate A3DStatus PFA3DCutWithMultiPlanarSectionOnRepresentationItems(uint uiNbRepItems, out IntPtr apRepItems, IntPtr pOptPlacements, ref A3DMultiPlanarSectionData psSectionParametersData, out uint pNumberOfRepItems, IntPtr pppRIRepresentationItem, IntPtr pppRIPlanarSections);
        public static PFA3DCutWithMultiPlanarSectionOnRepresentationItems A3DCutWithMultiPlanarSectionOnRepresentationItems = Marshal.GetDelegateForFunctionPointer<PFA3DCutWithMultiPlanarSectionOnRepresentationItems>(Library.A3DGetProcAddress("A3DCutWithMultiPlanarSectionOnRepresentationItems", 1));
        public delegate A3DStatus PFA3DCutWithMultiPlanarSectionOnModelFile(IntPtr pModelFile, IntPtr pOptMrkRView, ref A3DMultiPlanarSectionData psSectionParametersData, out uint pNumberOfRepItems, IntPtr pppRIRepresentationItem, IntPtr pppRIPlanarSections);
        public static PFA3DCutWithMultiPlanarSectionOnModelFile A3DCutWithMultiPlanarSectionOnModelFile = Marshal.GetDelegateForFunctionPointer<PFA3DCutWithMultiPlanarSectionOnModelFile>(Library.A3DGetProcAddress("A3DCutWithMultiPlanarSectionOnModelFile", 1));
        public delegate A3DStatus PFA3DComputeOrthoHLROnRepresentationItems(uint uiNbRepItems, out IntPtr apRepItems, IntPtr pOptPlacements, ref A3DHLRViewPlaneData psHLRViewPlaneData, out uint pNumberHLRData, IntPtr pppHLRData);
        public static PFA3DComputeOrthoHLROnRepresentationItems A3DComputeOrthoHLROnRepresentationItems = Marshal.GetDelegateForFunctionPointer<PFA3DComputeOrthoHLROnRepresentationItems>(Library.A3DGetProcAddress("A3DComputeOrthoHLROnRepresentationItems", 1));
        public delegate A3DStatus PFA3DComputeOrthoHLROnModelFile(IntPtr pModelFile, IntPtr pOptMrkRView, ref A3DHLRViewPlaneData psHLRViewPlaneData, out uint pNumberHLRData, IntPtr pppHLRData);
        public static PFA3DComputeOrthoHLROnModelFile A3DComputeOrthoHLROnModelFile = Marshal.GetDelegateForFunctionPointer<PFA3DComputeOrthoHLROnModelFile>(Library.A3DGetProcAddress("A3DComputeOrthoHLROnModelFile", 1));
        public delegate A3DStatus PFA3DComputeOrthoHLROnModelFile2(IntPtr pModelFile, IntPtr pOptMrkRView, ref A3DHLRViewPlaneData psHLRViewPlaneData, out uint pNumberHLRRepItem, IntPtr pppHLRRepItem);
        public static PFA3DComputeOrthoHLROnModelFile2 A3DComputeOrthoHLROnModelFile2 = Marshal.GetDelegateForFunctionPointer<PFA3DComputeOrthoHLROnModelFile2>(Library.A3DGetProcAddress("A3DComputeOrthoHLROnModelFile2", 1));
        public delegate A3DStatus PFA3DComputeOrthoHLROnModelFile3(IntPtr pModelFile, IntPtr pOptMrkRView, ref A3DHLRViewPlaneData psHLRViewPlaneData, ref A3DHLROptionsData psHLROptionsData, out uint pNumberHLRRepItem, IntPtr ppHLRRepItems);
        public static PFA3DComputeOrthoHLROnModelFile3 A3DComputeOrthoHLROnModelFile3 = Marshal.GetDelegateForFunctionPointer<PFA3DComputeOrthoHLROnModelFile3>(Library.A3DGetProcAddress("A3DComputeOrthoHLROnModelFile3", 1));
        public delegate A3DStatus PFA3DHLRRepresentationItemGet(IntPtr pHLRRepItem, ref A3DHLRRepresentationItemData psRIData);
        public static PFA3DHLRRepresentationItemGet A3DHLRRepresentationItemGet = Marshal.GetDelegateForFunctionPointer<PFA3DHLRRepresentationItemGet>(Library.A3DGetProcAddress("A3DHLRRepresentationItemGet", 1));
        public delegate void PFA3DDllActivateXMLTrace(bool activate);
        public static PFA3DDllActivateXMLTrace A3DDllActivateXMLTrace = Marshal.GetDelegateForFunctionPointer<PFA3DDllActivateXMLTrace>(Library.A3DGetProcAddress("A3DDllActivateXMLTrace", 1));
        public delegate A3DStatus PFA3DXmlParsing(IntPtr pModelfile, [MarshalAs(UnmanagedType.LPStr)] string pcFileName);
        public static PFA3DXmlParsing A3DXmlParsing = Marshal.GetDelegateForFunctionPointer<PFA3DXmlParsing>(Library.A3DGetProcAddress("A3DXmlParsing", 1));
        public delegate A3DStatus PFA3DCollisionCompute(ref A3DCollisionGroupData pGroup1, ref A3DCollisionGroupData pGroup2, ref A3DCollisionParameterData pParameterData, out uint uCollisionResultsSize, IntPtr pCollisionResults);
        public static PFA3DCollisionCompute A3DCollisionCompute = Marshal.GetDelegateForFunctionPointer<PFA3DCollisionCompute>(Library.A3DGetProcAddress("A3DCollisionCompute", 1));
        public delegate A3DStatus PFA3DDllInitialize(int iMajorVersion, int iMinorVersion);
        public static PFA3DDllInitialize A3DDllInitialize = Marshal.GetDelegateForFunctionPointer<PFA3DDllInitialize>(Library.A3DGetProcAddress("A3DDllInitialize", 1));
        public delegate A3DStatus PFA3DDllGetVersion(out int piMajorVersion, out int piMinorVersion);
        public static PFA3DDllGetVersion A3DDllGetVersion = Marshal.GetDelegateForFunctionPointer<PFA3DDllGetVersion>(Library.A3DGetProcAddress("A3DDllGetVersion", 1));
        public delegate void A3DCallbackMemoryFree(IntPtr arg1);
        public delegate A3DStatus PFA3DDllSetCallbacksMemory(IntPtr arg1, IntPtr arg2);
        public static PFA3DDllSetCallbacksMemory A3DDllSetCallbacksMemory = Marshal.GetDelegateForFunctionPointer<PFA3DDllSetCallbacksMemory>(Library.A3DGetProcAddress("A3DDllSetCallbacksMemory", 1));
        public delegate int A3DCallbackReportMessage([MarshalAs(UnmanagedType.LPStr)] string arg1);
        public delegate int A3DCallbackReportWarning([MarshalAs(UnmanagedType.LPStr)] string arg1, [MarshalAs(UnmanagedType.LPStr)] string arg2);
        public delegate int A3DCallbackReportError([MarshalAs(UnmanagedType.LPStr)] string arg1, [MarshalAs(UnmanagedType.LPStr)] string arg2);
        public delegate A3DStatus PFA3DDllSetCallbacksReport(IntPtr arg1, IntPtr arg2, IntPtr arg3);
        public static PFA3DDllSetCallbacksReport A3DDllSetCallbacksReport = Marshal.GetDelegateForFunctionPointer<PFA3DDllSetCallbacksReport>(Library.A3DGetProcAddress("A3DDllSetCallbacksReport", 1));
        public delegate void A3DCallbackAPITrace([MarshalAs(UnmanagedType.LPStr)] string arg1, uint arg2, IntPtr arg3, [MarshalAs(UnmanagedType.LPStr)] string arg4);
        public delegate A3DStatus PFA3DDllSetCallbackAPITrace(IntPtr arg1);
        public static PFA3DDllSetCallbackAPITrace A3DDllSetCallbackAPITrace = Marshal.GetDelegateForFunctionPointer<PFA3DDllSetCallbackAPITrace>(Library.A3DGetProcAddress("A3DDllSetCallbackAPITrace", 1));
        public delegate void A3DCallbackProgressStart(int arg1);
        public delegate void A3DCallbackProgressSize(int arg1);
        public delegate void A3DCallbackProgressIncrement(int arg1);
        public delegate void A3DCallbackProgressTitle([MarshalAs(UnmanagedType.LPStr)] string msg);
        public delegate A3DStatus PFA3DDllSetCallbacksProgress(IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, out int arg6);
        public static PFA3DDllSetCallbacksProgress A3DDllSetCallbacksProgress = Marshal.GetDelegateForFunctionPointer<PFA3DDllSetCallbacksProgress>(Library.A3DGetProcAddress("A3DDllSetCallbacksProgress", 1));
        public delegate A3DStatus PFA3DMkpLeaderGet(IntPtr pLeader, ref A3DMkpLeaderData pData);
        public static PFA3DMkpLeaderGet A3DMkpLeaderGet = Marshal.GetDelegateForFunctionPointer<PFA3DMkpLeaderGet>(Library.A3DGetProcAddress("A3DMkpLeaderGet", 1));
        public delegate A3DStatus PFA3DMkpLeaderCreate(ref A3DMkpLeaderData pData, out IntPtr ppLeader);
        public static PFA3DMkpLeaderCreate A3DMkpLeaderCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMkpLeaderCreate>(Library.A3DGetProcAddress("A3DMkpLeaderCreate", 1));
        public delegate A3DStatus PFA3DMkpAnnotationItemGet(IntPtr pAnnotation, ref A3DMkpAnnotationItemData pData);
        public static PFA3DMkpAnnotationItemGet A3DMkpAnnotationItemGet = Marshal.GetDelegateForFunctionPointer<PFA3DMkpAnnotationItemGet>(Library.A3DGetProcAddress("A3DMkpAnnotationItemGet", 1));
        public delegate A3DStatus PFA3DMkpAnnotationItemCreate(ref A3DMkpAnnotationItemData pData, out IntPtr ppAnnotation);
        public static PFA3DMkpAnnotationItemCreate A3DMkpAnnotationItemCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMkpAnnotationItemCreate>(Library.A3DGetProcAddress("A3DMkpAnnotationItemCreate", 1));
        public delegate A3DStatus PFA3DMkpAnnotationSetGet(IntPtr pAnnotation, ref A3DMkpAnnotationSetData pData);
        public static PFA3DMkpAnnotationSetGet A3DMkpAnnotationSetGet = Marshal.GetDelegateForFunctionPointer<PFA3DMkpAnnotationSetGet>(Library.A3DGetProcAddress("A3DMkpAnnotationSetGet", 1));
        public delegate A3DStatus PFA3DMkpAnnotationSetCreate(ref A3DMkpAnnotationSetData pData, out IntPtr ppAnnotation);
        public static PFA3DMkpAnnotationSetCreate A3DMkpAnnotationSetCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMkpAnnotationSetCreate>(Library.A3DGetProcAddress("A3DMkpAnnotationSetCreate", 1));
        public delegate A3DStatus PFA3DMkpAnnotationReferenceGet(IntPtr pAnnotation, ref A3DMkpAnnotationReferenceData pData);
        public static PFA3DMkpAnnotationReferenceGet A3DMkpAnnotationReferenceGet = Marshal.GetDelegateForFunctionPointer<PFA3DMkpAnnotationReferenceGet>(Library.A3DGetProcAddress("A3DMkpAnnotationReferenceGet", 1));
        public delegate A3DStatus PFA3DMkpAnnotationReferenceCreate(ref A3DMkpAnnotationReferenceData pData, out IntPtr ppAnnotation);
        public static PFA3DMkpAnnotationReferenceCreate A3DMkpAnnotationReferenceCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMkpAnnotationReferenceCreate>(Library.A3DGetProcAddress("A3DMkpAnnotationReferenceCreate", 1));
        public delegate A3DStatus PFA3DMkpViewGet(IntPtr pView, ref A3DMkpViewData pData);
        public static PFA3DMkpViewGet A3DMkpViewGet = Marshal.GetDelegateForFunctionPointer<PFA3DMkpViewGet>(Library.A3DGetProcAddress("A3DMkpViewGet", 1));
        public delegate A3DStatus PFA3DMkpViewCreate(ref A3DMkpViewData pData, out IntPtr ppView);
        public static PFA3DMkpViewCreate A3DMkpViewCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMkpViewCreate>(Library.A3DGetProcAddress("A3DMkpViewCreate", 1));
        public delegate A3DStatus PFA3DMkpViewGetFlags(IntPtr pView, ref A3DMkpViewFlagsData pFlags);
        public static PFA3DMkpViewGetFlags A3DMkpViewGetFlags = Marshal.GetDelegateForFunctionPointer<PFA3DMkpViewGetFlags>(Library.A3DGetProcAddress("A3DMkpViewGetFlags", 1));
        public delegate A3DStatus PFA3DMiscMarkupLinkedItemGet(IntPtr pLinkedItem, ref A3DMiscMarkupLinkedItemData pData);
        public static PFA3DMiscMarkupLinkedItemGet A3DMiscMarkupLinkedItemGet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscMarkupLinkedItemGet>(Library.A3DGetProcAddress("A3DMiscMarkupLinkedItemGet", 1));
        public delegate A3DStatus PFA3DMiscMarkupLinkedItemCreate(ref A3DMiscMarkupLinkedItemData pData, out IntPtr ppLinkedItem);
        public static PFA3DMiscMarkupLinkedItemCreate A3DMiscMarkupLinkedItemCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMiscMarkupLinkedItemCreate>(Library.A3DGetProcAddress("A3DMiscMarkupLinkedItemCreate", 1));
        public delegate A3DStatus PFA3DMkpMarkupGet(IntPtr pMarkup, ref A3DMkpMarkupData pData);
        public static PFA3DMkpMarkupGet A3DMkpMarkupGet = Marshal.GetDelegateForFunctionPointer<PFA3DMkpMarkupGet>(Library.A3DGetProcAddress("A3DMkpMarkupGet", 1));
        public delegate A3DStatus PFA3DMkpMarkupCreate(ref A3DMkpMarkupData pData, out IntPtr ppMarkup);
        public static PFA3DMkpMarkupCreate A3DMkpMarkupCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMkpMarkupCreate>(Library.A3DGetProcAddress("A3DMkpMarkupCreate", 1));
        public delegate A3DStatus PFA3DMkpLinkForMarkupReferenceGet(IntPtr pMarkup, out uint puiLinkedItemsSize, IntPtr ppLinkedItems);
        public static PFA3DMkpLinkForMarkupReferenceGet A3DMkpLinkForMarkupReferenceGet = Marshal.GetDelegateForFunctionPointer<PFA3DMkpLinkForMarkupReferenceGet>(Library.A3DGetProcAddress("A3DMkpLinkForMarkupReferenceGet", 1));
        public delegate A3DStatus PFA3DMkpLinkForAdditionalMarkupReferenceGet(IntPtr pMarkup, out uint puiLinkedItemsSize, IntPtr pppLinkedItems);
        public static PFA3DMkpLinkForAdditionalMarkupReferenceGet A3DMkpLinkForAdditionalMarkupReferenceGet = Marshal.GetDelegateForFunctionPointer<PFA3DMkpLinkForAdditionalMarkupReferenceGet>(Library.A3DGetProcAddress("A3DMkpLinkForAdditionalMarkupReferenceGet", 1));
        public delegate A3DStatus PFA3DMkpRTFFieldCreate([MarshalAs(UnmanagedType.LPStr)] string pRTFString, out IntPtr pRTFField);
        public static PFA3DMkpRTFFieldCreate A3DMkpRTFFieldCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMkpRTFFieldCreate>(Library.A3DGetProcAddress("A3DMkpRTFFieldCreate", 1));
        public delegate A3DStatus PFA3DMkpRTFInit([MarshalAs(UnmanagedType.LPStr)] string pRTF, out IntPtr pRTFData);
        public static PFA3DMkpRTFInit A3DMkpRTFInit = Marshal.GetDelegateForFunctionPointer<PFA3DMkpRTFInit>(Library.A3DGetProcAddress("A3DMkpRTFInit", 1));
        public delegate A3DStatus PFA3DMkpRTFFieldGet(IntPtr pRTFField, ref A3DMkpRTFFieldData pRTFFieldData);
        public static PFA3DMkpRTFFieldGet A3DMkpRTFFieldGet = Marshal.GetDelegateForFunctionPointer<PFA3DMkpRTFFieldGet>(Library.A3DGetProcAddress("A3DMkpRTFFieldGet", 1));
        public delegate A3DStatus PFA3DMkpRTFGetField(IntPtr pRTFData, out A3DMkpRTFFieldData pRTFField);
        public static PFA3DMkpRTFGetField A3DMkpRTFGetField = Marshal.GetDelegateForFunctionPointer<PFA3DMkpRTFGetField>(Library.A3DGetProcAddress("A3DMkpRTFGetField", 1));
        public delegate A3DStatus PFA3DMkpRTFFieldDelete(IntPtr pRTFField);
        public static PFA3DMkpRTFFieldDelete A3DMkpRTFFieldDelete = Marshal.GetDelegateForFunctionPointer<PFA3DMkpRTFFieldDelete>(Library.A3DGetProcAddress("A3DMkpRTFFieldDelete", 1));
        public delegate A3DStatus PFA3DMkpRTFDelete(IntPtr pRTFData);
        public static PFA3DMkpRTFDelete A3DMkpRTFDelete = Marshal.GetDelegateForFunctionPointer<PFA3DMkpRTFDelete>(Library.A3DGetProcAddress("A3DMkpRTFDelete", 1));
        public delegate A3DStatus PFA3DGlobalFontKeyGet(ref A3DFontKeyData pFontKeyData, ref A3DFontData pFontData);
        public static PFA3DGlobalFontKeyGet A3DGlobalFontKeyGet = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalFontKeyGet>(Library.A3DGetProcAddress("A3DGlobalFontKeyGet", 1));
        public delegate A3DStatus PFA3DGlobalFontTextBoxGet(ref A3DFontKeyData psFontKeyData, [MarshalAs(UnmanagedType.LPStr)] string pcText, out double pdLength, out double pdHeight);
        public static PFA3DGlobalFontTextBoxGet A3DGlobalFontTextBoxGet = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalFontTextBoxGet>(Library.A3DGetProcAddress("A3DGlobalFontTextBoxGet", 1));
        public delegate A3DStatus PFA3DGlobalFontTextBoxAndScaleGet(ref A3DFontKeyData psFontKeyData, [MarshalAs(UnmanagedType.LPStr)] string pcText, out double pdLength, out double pdHeight, out double pdScale);
        public static PFA3DGlobalFontTextBoxAndScaleGet A3DGlobalFontTextBoxAndScaleGet = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalFontTextBoxAndScaleGet>(Library.A3DGetProcAddress("A3DGlobalFontTextBoxAndScaleGet", 1));
        public delegate A3DStatus PFA3DGlobalFontKeyCreate(ref A3DFontData pFontData, ref A3DFontKeyData pFontKeyData);
        public static PFA3DGlobalFontKeyCreate A3DGlobalFontKeyCreate = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalFontKeyCreate>(Library.A3DGetProcAddress("A3DGlobalFontKeyCreate", 1));
        public delegate A3DStatus PFA3DGlobalFontTextTessellationGet(ref A3DFontKeyData psFontKeyData, [MarshalAs(UnmanagedType.LPStr)] string pcOneChar, out IntPtr ppset, out double pdCharWidth);
        public static PFA3DGlobalFontTextTessellationGet A3DGlobalFontTextTessellationGet = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalFontTextTessellationGet>(Library.A3DGetProcAddress("A3DGlobalFontTextTessellationGet", 1));
        public delegate A3DStatus PFA3DGraphTextureTransformationGet(IntPtr pTextureTransformation, ref A3DGraphTextureTransformationData pData);
        public static PFA3DGraphTextureTransformationGet A3DGraphTextureTransformationGet = Marshal.GetDelegateForFunctionPointer<PFA3DGraphTextureTransformationGet>(Library.A3DGetProcAddress("A3DGraphTextureTransformationGet", 1));
        public delegate A3DStatus PFA3DGraphTextureTransformationCreate(ref A3DGraphTextureTransformationData pData, out IntPtr ppTextureTransformation);
        public static PFA3DGraphTextureTransformationCreate A3DGraphTextureTransformationCreate = Marshal.GetDelegateForFunctionPointer<PFA3DGraphTextureTransformationCreate>(Library.A3DGetProcAddress("A3DGraphTextureTransformationCreate", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphTextureDefinitionData(uint uiIndexTextureDefinition, ref A3DGraphTextureDefinitionData pData);
        public static PFA3DGlobalGetGraphTextureDefinitionData A3DGlobalGetGraphTextureDefinitionData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphTextureDefinitionData>(Library.A3DGetProcAddress("A3DGlobalGetGraphTextureDefinitionData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphTextureDefinition(ref A3DGraphTextureDefinitionData pData, out uint puiIndexTextureDefinition);
        public static PFA3DGlobalInsertGraphTextureDefinition A3DGlobalInsertGraphTextureDefinition = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphTextureDefinition>(Library.A3DGetProcAddress("A3DGlobalInsertGraphTextureDefinition", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphTextureApplicationData(uint uiIndexTextureApplication, ref A3DGraphTextureApplicationData pData);
        public static PFA3DGlobalGetGraphTextureApplicationData A3DGlobalGetGraphTextureApplicationData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphTextureApplicationData>(Library.A3DGetProcAddress("A3DGlobalGetGraphTextureApplicationData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphTextureApplication(ref A3DGraphTextureApplicationData pData, out uint puiIndexTextureApplication);
        public static PFA3DGlobalInsertGraphTextureApplication A3DGlobalInsertGraphTextureApplication = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphTextureApplication>(Library.A3DGetProcAddress("A3DGlobalInsertGraphTextureApplication", 1));
        public delegate A3DStatus PFA3DDrawingModelGet(IntPtr pDrawingModel, ref A3DDrawingModelData pData);
        public static PFA3DDrawingModelGet A3DDrawingModelGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingModelGet>(Library.A3DGetProcAddress("A3DDrawingModelGet", 1));
        public delegate A3DStatus PFA3DDrawingModelCreate(ref A3DDrawingModelData pData, out IntPtr ppDrawingModel);
        public static PFA3DDrawingModelCreate A3DDrawingModelCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingModelCreate>(Library.A3DGetProcAddress("A3DDrawingModelCreate", 1));
        public delegate A3DStatus PFA3DDrawingSheetFormatGet(IntPtr pDrwSheetFormat, ref A3DDrawingSheetFormatData pData);
        public static PFA3DDrawingSheetFormatGet A3DDrawingSheetFormatGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingSheetFormatGet>(Library.A3DGetProcAddress("A3DDrawingSheetFormatGet", 1));
        public delegate A3DStatus PFA3DDrawingSheetFormatCreate(ref A3DDrawingSheetFormatData pData, out IntPtr ppDrwSheetFormat);
        public static PFA3DDrawingSheetFormatCreate A3DDrawingSheetFormatCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingSheetFormatCreate>(Library.A3DGetProcAddress("A3DDrawingSheetFormatCreate", 1));
        public delegate A3DStatus PFA3DDrawingSheetGet(IntPtr pDrawingSheet, ref A3DDrawingSheetData pData);
        public static PFA3DDrawingSheetGet A3DDrawingSheetGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingSheetGet>(Library.A3DGetProcAddress("A3DDrawingSheetGet", 1));
        public delegate A3DStatus PFA3DDrawingSheetCreate(ref A3DDrawingSheetData pData, out IntPtr ppDrawingSheet);
        public static PFA3DDrawingSheetCreate A3DDrawingSheetCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingSheetCreate>(Library.A3DGetProcAddress("A3DDrawingSheetCreate", 1));
        public delegate A3DStatus PFA3DDrawingClipFrameGet(IntPtr pDrwClipFrame, ref A3DDrawingClipFrameData pData);
        public static PFA3DDrawingClipFrameGet A3DDrawingClipFrameGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingClipFrameGet>(Library.A3DGetProcAddress("A3DDrawingClipFrameGet", 1));
        public delegate A3DStatus PFA3DDrawingClipFrameCreate(ref A3DDrawingClipFrameData pData, out IntPtr ppDrwClipFrame);
        public static PFA3DDrawingClipFrameCreate A3DDrawingClipFrameCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingClipFrameCreate>(Library.A3DGetProcAddress("A3DDrawingClipFrameCreate", 1));
        public delegate A3DStatus PFA3DDrawingViewGet(IntPtr pDrawingView, ref A3DDrawingViewData pData);
        public static PFA3DDrawingViewGet A3DDrawingViewGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingViewGet>(Library.A3DGetProcAddress("A3DDrawingViewGet", 1));
        public delegate A3DStatus PFA3DDrawingViewCreate(ref A3DDrawingViewData pData, out IntPtr ppDrawingView);
        public static PFA3DDrawingViewCreate A3DDrawingViewCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingViewCreate>(Library.A3DGetProcAddress("A3DDrawingViewCreate", 1));
        public delegate A3DStatus PFA3DDrawingBlockBasicGet(IntPtr pDrawingBlock, ref A3DDrawingBlockBasicData pData);
        public static PFA3DDrawingBlockBasicGet A3DDrawingBlockBasicGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingBlockBasicGet>(Library.A3DGetProcAddress("A3DDrawingBlockBasicGet", 1));
        public delegate A3DStatus PFA3DDrawingBlockBasicCreate(ref A3DDrawingBlockBasicData pData, out IntPtr ppDrawingBlock);
        public static PFA3DDrawingBlockBasicCreate A3DDrawingBlockBasicCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingBlockBasicCreate>(Library.A3DGetProcAddress("A3DDrawingBlockBasicCreate", 1));
        public delegate A3DStatus PFA3DDrawingBlockOperatorGet(IntPtr pDrawingOperator, ref A3DDrawingBlockOperatorData pData);
        public static PFA3DDrawingBlockOperatorGet A3DDrawingBlockOperatorGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingBlockOperatorGet>(Library.A3DGetProcAddress("A3DDrawingBlockOperatorGet", 1));
        public delegate A3DStatus PFA3DDrawingBlockOperatorCreate(ref A3DDrawingBlockOperatorData pData, out IntPtr ppDrawingOperator);
        public static PFA3DDrawingBlockOperatorCreate A3DDrawingBlockOperatorCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingBlockOperatorCreate>(Library.A3DGetProcAddress("A3DDrawingBlockOperatorCreate", 1));
        public delegate A3DStatus PFA3DDrawingBlockPushMiscCascadedAttributes(IntPtr pAttr, IntPtr pBlock, uint uiEntityIndex, IntPtr pFather);
        public static PFA3DDrawingBlockPushMiscCascadedAttributes A3DDrawingBlockPushMiscCascadedAttributes = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingBlockPushMiscCascadedAttributes>(Library.A3DGetProcAddress("A3DDrawingBlockPushMiscCascadedAttributes", 1));
        public delegate A3DStatus PFA3DDrawingCurveGet(IntPtr pDrawingCrv, ref A3DDrawingCurveData pData);
        public static PFA3DDrawingCurveGet A3DDrawingCurveGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingCurveGet>(Library.A3DGetProcAddress("A3DDrawingCurveGet", 1));
        public delegate A3DStatus PFA3DDrawingCurveCreate(ref A3DDrawingCurveData pData, out IntPtr ppDrawingCrv);
        public static PFA3DDrawingCurveCreate A3DDrawingCurveCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingCurveCreate>(Library.A3DGetProcAddress("A3DDrawingCurveCreate", 1));
        public delegate A3DStatus PFA3DDrawingFilledAreaGet(IntPtr pDrwFilledArea, ref A3DDrawingFilledAreaData pData);
        public static PFA3DDrawingFilledAreaGet A3DDrawingFilledAreaGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingFilledAreaGet>(Library.A3DGetProcAddress("A3DDrawingFilledAreaGet", 1));
        public delegate A3DStatus PFA3DDrawingFilledAreaCreate(ref A3DDrawingFilledAreaData pData, out IntPtr ppDrwFilledArea);
        public static PFA3DDrawingFilledAreaCreate A3DDrawingFilledAreaCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingFilledAreaCreate>(Library.A3DGetProcAddress("A3DDrawingFilledAreaCreate", 1));
        public delegate A3DStatus PFA3DDrawingPictureGet(IntPtr pDrawingPicture, ref A3DDrawingPictureData pData);
        public static PFA3DDrawingPictureGet A3DDrawingPictureGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingPictureGet>(Library.A3DGetProcAddress("A3DDrawingPictureGet", 1));
        public delegate A3DStatus PFA3DDrawingPictureCreate(ref A3DDrawingPictureData pData, out IntPtr ppDrawingPicture);
        public static PFA3DDrawingPictureCreate A3DDrawingPictureCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingPictureCreate>(Library.A3DGetProcAddress("A3DDrawingPictureCreate", 1));
        public delegate A3DStatus PFA3DDrawingVerticesGet(IntPtr pDrawingVertices, ref A3DDrawingVerticesData pData);
        public static PFA3DDrawingVerticesGet A3DDrawingVerticesGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingVerticesGet>(Library.A3DGetProcAddress("A3DDrawingVerticesGet", 1));
        public delegate A3DStatus PFA3DDrawingVerticesCreate(ref A3DDrawingVerticesData pData, out IntPtr ppDrawingVertices);
        public static PFA3DDrawingVerticesCreate A3DDrawingVerticesCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingVerticesCreate>(Library.A3DGetProcAddress("A3DDrawingVerticesCreate", 1));
        public delegate A3DStatus PFA3DGetFileFormat([MarshalAs(UnmanagedType.LPStr)] string pcFileName, ref A3DEModellerType peModellerType);
        public static PFA3DGetFileFormat A3DGetFileFormat = Marshal.GetDelegateForFunctionPointer<PFA3DGetFileFormat>(Library.A3DGetProcAddress("A3DGetFileFormat", 1));
        public delegate A3DStatus PFA3DCheckFileFormat([MarshalAs(UnmanagedType.LPStr)] string pcFileName, A3DEModellerType eCadTypeWanted);
        public static PFA3DCheckFileFormat A3DCheckFileFormat = Marshal.GetDelegateForFunctionPointer<PFA3DCheckFileFormat>(Library.A3DGetProcAddress("A3DCheckFileFormat", 1));
        public delegate A3DStatus PFA3DExtractFileThumbnail([MarshalAs(UnmanagedType.LPStr)] string pcFileName, ref A3DThumbnailData pThumbnailData);
        public static PFA3DExtractFileThumbnail A3DExtractFileThumbnail = Marshal.GetDelegateForFunctionPointer<PFA3DExtractFileThumbnail>(Library.A3DGetProcAddress("A3DExtractFileThumbnail", 1));
        public delegate A3DStatus PFA3DGetFileInformation([MarshalAs(UnmanagedType.LPStr)] string pcFileName, ref A3DFileInformationData pFileInformationData);
        public static PFA3DGetFileInformation A3DGetFileInformation = Marshal.GetDelegateForFunctionPointer<PFA3DGetFileInformation>(Library.A3DGetProcAddress("A3DGetFileInformation", 1));
        public delegate A3DStatus PFA3DAsmGetFilesPathFromModelFile(IntPtr pA3DAsmModelFile, out uint uNbPartFiles, IntPtr ppPartFilesPaths, out uint uNbAssemblyFiles, IntPtr ppAssemblyFilesPaths, out uint uNbMissingFiles, IntPtr ppMissingFilesPaths);
        public static PFA3DAsmGetFilesPathFromModelFile A3DAsmGetFilesPathFromModelFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmGetFilesPathFromModelFile>(Library.A3DGetProcAddress("A3DAsmGetFilesPathFromModelFile", 1));
        public delegate A3DStatus PFA3DAsmGetFilesContextsFromModelFile(IntPtr pA3DAsmModelFile, out uint uNbFilesContexts, IntPtr ppFilesContexts);
        public static PFA3DAsmGetFilesContextsFromModelFile A3DAsmGetFilesContextsFromModelFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmGetFilesContextsFromModelFile>(Library.A3DGetProcAddress("A3DAsmGetFilesContextsFromModelFile", 1));
        public delegate A3DStatus PFA3DFileContextDelete(ref A3DFileContextData pData);
        public static PFA3DFileContextDelete A3DFileContextDelete = Marshal.GetDelegateForFunctionPointer<PFA3DFileContextDelete>(Library.A3DGetProcAddress("A3DFileContextDelete", 1));
        public delegate A3DStatus PFA3DAsmModelFileLoadFromPRCFiles([MarshalAs(UnmanagedType.LPStr)] string pcRootPrcFilePath, uint uNbFile, IntPtr ppPRCFilePath, IntPtr ppCADFilePath, ref A3DRWParamsLoadData pParamsLoadData, out IntPtr pA3DAsmModelFile);
        public static PFA3DAsmModelFileLoadFromPRCFiles A3DAsmModelFileLoadFromPRCFiles = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileLoadFromPRCFiles>(Library.A3DGetProcAddress("A3DAsmModelFileLoadFromPRCFiles", 1));
        public delegate A3DStatus PFA3DAsmModelFileLoadFromMultiplePrcFile([MarshalAs(UnmanagedType.LPStr)] string pcFileName, uint uNbPart, IntPtr ppCADFilePath, IntPtr ppPRCFilePath, ref A3DRWParamsLoadData pParamsLoadData, out IntPtr pA3DAsmModelFile);
        public static PFA3DAsmModelFileLoadFromMultiplePrcFile A3DAsmModelFileLoadFromMultiplePrcFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileLoadFromMultiplePrcFile>(Library.A3DGetProcAddress("A3DAsmModelFileLoadFromMultiplePrcFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToParasolidFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportParasolidData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToParasolidFile A3DAsmModelFileExportToParasolidFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToParasolidFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToParasolidFile", 1));
        public delegate A3DStatus PFA3DChainedBufferFree(ref A3DChainedBuffer pBuffer);
        public static PFA3DChainedBufferFree A3DChainedBufferFree = Marshal.GetDelegateForFunctionPointer<PFA3DChainedBufferFree>(Library.A3DGetProcAddress("A3DChainedBufferFree", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToParasolidBuffer(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportParasolidData pParamsExportData, IntPtr pBuffer);
        public static PFA3DAsmModelFileExportToParasolidBuffer A3DAsmModelFileExportToParasolidBuffer = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToParasolidBuffer>(Library.A3DGetProcAddress("A3DAsmModelFileExportToParasolidBuffer", 1));
        public delegate A3DStatus PFA3DRepresentationItemExportToParasolidFile(IntPtr pRepItem, [MarshalAs(UnmanagedType.LPStr)] string pcTempFileName, double dUnit);
        public static PFA3DRepresentationItemExportToParasolidFile A3DRepresentationItemExportToParasolidFile = Marshal.GetDelegateForFunctionPointer<PFA3DRepresentationItemExportToParasolidFile>(Library.A3DGetProcAddress("A3DRepresentationItemExportToParasolidFile", 1));
        public delegate A3DStatus PFA3DRepresentationItemExportToParasolidBuffer(IntPtr pRepItem, IntPtr pBuffer, double dUnit);
        public static PFA3DRepresentationItemExportToParasolidBuffer A3DRepresentationItemExportToParasolidBuffer = Marshal.GetDelegateForFunctionPointer<PFA3DRepresentationItemExportToParasolidBuffer>(Library.A3DGetProcAddress("A3DRepresentationItemExportToParasolidBuffer", 1));
        public delegate A3DStatus PFA3DAsmModelFileTranslateToPkParts(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportParasolidData pParamsExportData, ref A3DRWParamsTranslateToPkPartsData pParamsTranslateToPkPartsData, IntPtr pNbPkParts, IntPtr pPkParts);
        public static PFA3DAsmModelFileTranslateToPkParts A3DAsmModelFileTranslateToPkParts = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileTranslateToPkParts>(Library.A3DGetProcAddress("A3DAsmModelFileTranslateToPkParts", 1));
        public delegate A3DStatus PFA3DRepresentationItemTranslateToPkParts(IntPtr pRepItem, ref A3DRWParamsTranslateToPkPartsData pParamsTranslateToPkPartsData, double dUnit, IntPtr pNbPkParts, IntPtr pPkParts);
        public static PFA3DRepresentationItemTranslateToPkParts A3DRepresentationItemTranslateToPkParts = Marshal.GetDelegateForFunctionPointer<PFA3DRepresentationItemTranslateToPkParts>(Library.A3DGetProcAddress("A3DRepresentationItemTranslateToPkParts", 1));
        public delegate A3DStatus PFA3DRepresentationItemsTranslateToPkPartsMultiProcess(uint uiNbProc, ref A3DRWParamsTranslateToPkPartsData pParamsTranslateToPkPartsData, uint uiNbRepItem, out IntPtr pRepItem, out double padUnit, IntPtr pNbPkParts, IntPtr pPkParts);
        public static PFA3DRepresentationItemsTranslateToPkPartsMultiProcess A3DRepresentationItemsTranslateToPkPartsMultiProcess = Marshal.GetDelegateForFunctionPointer<PFA3DRepresentationItemsTranslateToPkPartsMultiProcess>(Library.A3DGetProcAddress("A3DRepresentationItemsTranslateToPkPartsMultiProcess", 1));
        public delegate A3DStatus PFA3DHealPkParts(IntPtr pNbPkParts, IntPtr pPkParts, ref A3DRWParamsTranslateToPkPartsData pParamsTranslateToPkPartsData);
        public static PFA3DHealPkParts A3DHealPkParts = Marshal.GetDelegateForFunctionPointer<PFA3DHealPkParts>(Library.A3DGetProcAddress("A3DHealPkParts", 1));
        public delegate A3DStatus PFA3DMiscPKMapperGetPKEntitiesFromA3DEntity(IntPtr pMapper, IntPtr pA3DEntity, IntPtr piNbPKEntities, IntPtr ppPKEntities);
        public static PFA3DMiscPKMapperGetPKEntitiesFromA3DEntity A3DMiscPKMapperGetPKEntitiesFromA3DEntity = Marshal.GetDelegateForFunctionPointer<PFA3DMiscPKMapperGetPKEntitiesFromA3DEntity>(Library.A3DGetProcAddress("A3DMiscPKMapperGetPKEntitiesFromA3DEntity", 1));
        public delegate A3DStatus PFA3DMiscPKMapperGetA3DEntitiesFromPKEntity(IntPtr pMapper, int pPKEntity, IntPtr piNbA3DEntities, IntPtr ppA3DEntities);
        public static PFA3DMiscPKMapperGetA3DEntitiesFromPKEntity A3DMiscPKMapperGetA3DEntitiesFromPKEntity = Marshal.GetDelegateForFunctionPointer<PFA3DMiscPKMapperGetA3DEntitiesFromPKEntity>(Library.A3DGetProcAddress("A3DMiscPKMapperGetA3DEntitiesFromPKEntity", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToParasolidFileWithMapper(IntPtr pA3DAsmModelFile, IntPtr pMapper, ref A3DRWParamsExportParasolidData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToParasolidFileWithMapper A3DAsmModelFileExportToParasolidFileWithMapper = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToParasolidFileWithMapper>(Library.A3DGetProcAddress("A3DAsmModelFileExportToParasolidFileWithMapper", 1));
        public delegate A3DStatus PFA3DPkPartsTranslateToA3DAsmModelFile(int pNbPkParts, IntPtr pPkParts, ref A3DRWParamsLoadData pLoadParam, out IntPtr ppA3DAsmModelFile, out IntPtr pMapper);
        public static PFA3DPkPartsTranslateToA3DAsmModelFile A3DPkPartsTranslateToA3DAsmModelFile = Marshal.GetDelegateForFunctionPointer<PFA3DPkPartsTranslateToA3DAsmModelFile>(Library.A3DGetProcAddress("A3DPkPartsTranslateToA3DAsmModelFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToParasolidBufferWithMapper(IntPtr pA3DAsmModelFile, IntPtr pMapper, ref A3DRWParamsExportParasolidData pParamsExportData, IntPtr pBuffer);
        public static PFA3DAsmModelFileExportToParasolidBufferWithMapper A3DAsmModelFileExportToParasolidBufferWithMapper = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToParasolidBufferWithMapper>(Library.A3DGetProcAddress("A3DAsmModelFileExportToParasolidBufferWithMapper", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToPrcStream(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportPrcData pParamsExportData, IntPtr pcStream, out uint uLength, out IntPtr ppPrcWriteHelper);
        public static PFA3DAsmModelFileExportToPrcStream A3DAsmModelFileExportToPrcStream = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToPrcStream>(Library.A3DGetProcAddress("A3DAsmModelFileExportToPrcStream", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToAcisFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportAcisData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToAcisFile A3DAsmModelFileExportToAcisFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToAcisFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToAcisFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToAcisBuffer(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportAcisData pParamsExportData, IntPtr pBuffer);
        public static PFA3DAsmModelFileExportToAcisBuffer A3DAsmModelFileExportToAcisBuffer = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToAcisBuffer>(Library.A3DGetProcAddress("A3DAsmModelFileExportToAcisBuffer", 1));
        public delegate A3DStatus PFA3DRepresentationItemExportToAcisBuffer(IntPtr pRepItem, IntPtr pBuffer, double dScale);
        public static PFA3DRepresentationItemExportToAcisBuffer A3DRepresentationItemExportToAcisBuffer = Marshal.GetDelegateForFunctionPointer<PFA3DRepresentationItemExportToAcisBuffer>(Library.A3DGetProcAddress("A3DRepresentationItemExportToAcisBuffer", 1));
        public delegate A3DStatus PFA3DAsmModelFileLoadFromXMLFile([MarshalAs(UnmanagedType.LPStr)] string pcFileName, ref A3DRWParamsLoadData pLoadParametersData, out IntPtr ppModelFile);
        public static PFA3DAsmModelFileLoadFromXMLFile A3DAsmModelFileLoadFromXMLFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileLoadFromXMLFile>(Library.A3DGetProcAddress("A3DAsmModelFileLoadFromXMLFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileLoadFromXMLStream([MarshalAs(UnmanagedType.LPStr)] string pcBuffer, ref A3DRWParamsLoadData pLoadParametersData, out IntPtr ppModelFile);
        public static PFA3DAsmModelFileLoadFromXMLStream A3DAsmModelFileLoadFromXMLStream = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileLoadFromXMLStream>(Library.A3DGetProcAddress("A3DAsmModelFileLoadFromXMLStream", 1));
        public delegate A3DStatus PFA3DRiRepresentationItemGet(IntPtr pRi, ref A3DRiRepresentationItemData pData);
        public static PFA3DRiRepresentationItemGet A3DRiRepresentationItemGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiRepresentationItemGet>(Library.A3DGetProcAddress("A3DRiRepresentationItemGet", 1));
        public delegate A3DStatus PFA3DRiRepresentationItemSet(IntPtr pRi, ref A3DRiRepresentationItemData pData);
        public static PFA3DRiRepresentationItemSet A3DRiRepresentationItemSet = Marshal.GetDelegateForFunctionPointer<PFA3DRiRepresentationItemSet>(Library.A3DGetProcAddress("A3DRiRepresentationItemSet", 1));
        public delegate A3DStatus PFA3DRiRepresentationItemDeepCopy(IntPtr pRi, out IntPtr ppNewRi);
        public static PFA3DRiRepresentationItemDeepCopy A3DRiRepresentationItemDeepCopy = Marshal.GetDelegateForFunctionPointer<PFA3DRiRepresentationItemDeepCopy>(Library.A3DGetProcAddress("A3DRiRepresentationItemDeepCopy", 1));
        public delegate A3DStatus PFA3DRiRepresentationItemComputeTessellation(IntPtr pRi, ref A3DRWParamsTessellationData pTessellationParametersData);
        public static PFA3DRiRepresentationItemComputeTessellation A3DRiRepresentationItemComputeTessellation = Marshal.GetDelegateForFunctionPointer<PFA3DRiRepresentationItemComputeTessellation>(Library.A3DGetProcAddress("A3DRiRepresentationItemComputeTessellation", 1));
        public delegate A3DStatus PFA3DRiReleaseTessellation(IntPtr pRepresentationItem);
        public static PFA3DRiReleaseTessellation A3DRiReleaseTessellation = Marshal.GetDelegateForFunctionPointer<PFA3DRiReleaseTessellation>(Library.A3DGetProcAddress("A3DRiReleaseTessellation", 1));
        public delegate A3DStatus PFA3DRiRepresentationItemEditCoordinateSystem(IntPtr pNewCoordinateSystem, IntPtr pRepresentationItem);
        public static PFA3DRiRepresentationItemEditCoordinateSystem A3DRiRepresentationItemEditCoordinateSystem = Marshal.GetDelegateForFunctionPointer<PFA3DRiRepresentationItemEditCoordinateSystem>(Library.A3DGetProcAddress("A3DRiRepresentationItemEditCoordinateSystem", 1));
        public delegate A3DStatus PFA3DRiSetGet(IntPtr pSet, ref A3DRiSetData pData);
        public static PFA3DRiSetGet A3DRiSetGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiSetGet>(Library.A3DGetProcAddress("A3DRiSetGet", 1));
        public delegate A3DStatus PFA3DRiSetCreate(ref A3DRiSetData pData, out IntPtr ppSet);
        public static PFA3DRiSetCreate A3DRiSetCreate = Marshal.GetDelegateForFunctionPointer<PFA3DRiSetCreate>(Library.A3DGetProcAddress("A3DRiSetCreate", 1));
        public delegate A3DStatus PFA3DRiSetEdit(ref A3DRiSetData pData, IntPtr pSet);
        public static PFA3DRiSetEdit A3DRiSetEdit = Marshal.GetDelegateForFunctionPointer<PFA3DRiSetEdit>(Library.A3DGetProcAddress("A3DRiSetEdit", 1));
        public delegate A3DStatus PFA3DRiPointSetGet(IntPtr pPointSet, ref A3DRiPointSetData pData);
        public static PFA3DRiPointSetGet A3DRiPointSetGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiPointSetGet>(Library.A3DGetProcAddress("A3DRiPointSetGet", 1));
        public delegate A3DStatus PFA3DRiPointSetCreate(ref A3DRiPointSetData pData, out IntPtr ppPointSet);
        public static PFA3DRiPointSetCreate A3DRiPointSetCreate = Marshal.GetDelegateForFunctionPointer<PFA3DRiPointSetCreate>(Library.A3DGetProcAddress("A3DRiPointSetCreate", 1));
        public delegate A3DStatus PFA3DRiPointSetEdit(ref A3DRiPointSetData pData, IntPtr pPointSet);
        public static PFA3DRiPointSetEdit A3DRiPointSetEdit = Marshal.GetDelegateForFunctionPointer<PFA3DRiPointSetEdit>(Library.A3DGetProcAddress("A3DRiPointSetEdit", 1));
        public delegate A3DStatus PFA3DRiDirectionGet(IntPtr pDirection, ref A3DRiDirectionData pData);
        public static PFA3DRiDirectionGet A3DRiDirectionGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiDirectionGet>(Library.A3DGetProcAddress("A3DRiDirectionGet", 1));
        public delegate A3DStatus PFA3DRiDirectionCreate(ref A3DRiDirectionData pData, out IntPtr ppDirection);
        public static PFA3DRiDirectionCreate A3DRiDirectionCreate = Marshal.GetDelegateForFunctionPointer<PFA3DRiDirectionCreate>(Library.A3DGetProcAddress("A3DRiDirectionCreate", 1));
        public delegate A3DStatus PFA3DRiDirectionEdit(ref A3DRiDirectionData pData, IntPtr pDirection);
        public static PFA3DRiDirectionEdit A3DRiDirectionEdit = Marshal.GetDelegateForFunctionPointer<PFA3DRiDirectionEdit>(Library.A3DGetProcAddress("A3DRiDirectionEdit", 1));
        public delegate A3DStatus PFA3DRiCoordinateSystemGet(IntPtr pCoordinateSystem, ref A3DRiCoordinateSystemData pData);
        public static PFA3DRiCoordinateSystemGet A3DRiCoordinateSystemGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiCoordinateSystemGet>(Library.A3DGetProcAddress("A3DRiCoordinateSystemGet", 1));
        public delegate A3DStatus PFA3DRiCoordinateSystemCreate(ref A3DRiCoordinateSystemData pData, out IntPtr ppCoordinateSystem);
        public static PFA3DRiCoordinateSystemCreate A3DRiCoordinateSystemCreate = Marshal.GetDelegateForFunctionPointer<PFA3DRiCoordinateSystemCreate>(Library.A3DGetProcAddress("A3DRiCoordinateSystemCreate", 1));
        public delegate A3DStatus PFA3DRiCoordinateSystemEdit(ref A3DRiCoordinateSystemData pData, IntPtr pCoordinateSystem);
        public static PFA3DRiCoordinateSystemEdit A3DRiCoordinateSystemEdit = Marshal.GetDelegateForFunctionPointer<PFA3DRiCoordinateSystemEdit>(Library.A3DGetProcAddress("A3DRiCoordinateSystemEdit", 1));
        public delegate A3DStatus PFA3DRiCurveGet(IntPtr pRICrv, ref A3DRiCurveData pData);
        public static PFA3DRiCurveGet A3DRiCurveGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiCurveGet>(Library.A3DGetProcAddress("A3DRiCurveGet", 1));
        public delegate A3DStatus PFA3DRiCurveCreate(ref A3DRiCurveData pData, out IntPtr ppRICrv);
        public static PFA3DRiCurveCreate A3DRiCurveCreate = Marshal.GetDelegateForFunctionPointer<PFA3DRiCurveCreate>(Library.A3DGetProcAddress("A3DRiCurveCreate", 1));
        public delegate A3DStatus PFA3DRiCurveEdit(ref A3DRiCurveData pData, IntPtr pRICrv);
        public static PFA3DRiCurveEdit A3DRiCurveEdit = Marshal.GetDelegateForFunctionPointer<PFA3DRiCurveEdit>(Library.A3DGetProcAddress("A3DRiCurveEdit", 1));
        public delegate A3DStatus PFA3DRiCurveSupportGet(IntPtr pRiCurve, out IntPtr ppLinkedItem);
        public static PFA3DRiCurveSupportGet A3DRiCurveSupportGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiCurveSupportGet>(Library.A3DGetProcAddress("A3DRiCurveSupportGet", 1));
        public delegate A3DStatus PFA3DRiPlaneGet(IntPtr pRiPlane, ref A3DRiPlaneData pData);
        public static PFA3DRiPlaneGet A3DRiPlaneGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiPlaneGet>(Library.A3DGetProcAddress("A3DRiPlaneGet", 1));
        public delegate A3DStatus PFA3DRiPlaneCreate(ref A3DRiPlaneData pData, out IntPtr ppRIPlane);
        public static PFA3DRiPlaneCreate A3DRiPlaneCreate = Marshal.GetDelegateForFunctionPointer<PFA3DRiPlaneCreate>(Library.A3DGetProcAddress("A3DRiPlaneCreate", 1));
        public delegate A3DStatus PFA3DRiPlaneEdit(ref A3DRiPlaneData pData, IntPtr pRIPlane);
        public static PFA3DRiPlaneEdit A3DRiPlaneEdit = Marshal.GetDelegateForFunctionPointer<PFA3DRiPlaneEdit>(Library.A3DGetProcAddress("A3DRiPlaneEdit", 1));
        public delegate A3DStatus PFA3DRiPlaneSupportGet(IntPtr pRiPlane, out IntPtr ppLinkedItem);
        public static PFA3DRiPlaneSupportGet A3DRiPlaneSupportGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiPlaneSupportGet>(Library.A3DGetProcAddress("A3DRiPlaneSupportGet", 1));
        public delegate A3DStatus PFA3DRiBrepModelGet(IntPtr pRIBrepModel, ref A3DRiBrepModelData pData);
        public static PFA3DRiBrepModelGet A3DRiBrepModelGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiBrepModelGet>(Library.A3DGetProcAddress("A3DRiBrepModelGet", 1));
        public delegate A3DStatus PFA3DRiBrepModelCreate(ref A3DRiBrepModelData pData, out IntPtr ppRIBrepModel);
        public static PFA3DRiBrepModelCreate A3DRiBrepModelCreate = Marshal.GetDelegateForFunctionPointer<PFA3DRiBrepModelCreate>(Library.A3DGetProcAddress("A3DRiBrepModelCreate", 1));
        public delegate A3DStatus PFA3DRiBrepModelEdit(ref A3DRiBrepModelData pData, IntPtr pRIBrepModel);
        public static PFA3DRiBrepModelEdit A3DRiBrepModelEdit = Marshal.GetDelegateForFunctionPointer<PFA3DRiBrepModelEdit>(Library.A3DGetProcAddress("A3DRiBrepModelEdit", 1));
        public delegate A3DStatus PFA3DRiPolyBrepModelGet(IntPtr pRIPolyBrepModel, ref A3DRiPolyBrepModelData pData);
        public static PFA3DRiPolyBrepModelGet A3DRiPolyBrepModelGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiPolyBrepModelGet>(Library.A3DGetProcAddress("A3DRiPolyBrepModelGet", 1));
        public delegate A3DStatus PFA3DRiPolyBrepModelCreate(ref A3DRiPolyBrepModelData pData, out IntPtr ppRIPolyBrepModel);
        public static PFA3DRiPolyBrepModelCreate A3DRiPolyBrepModelCreate = Marshal.GetDelegateForFunctionPointer<PFA3DRiPolyBrepModelCreate>(Library.A3DGetProcAddress("A3DRiPolyBrepModelCreate", 1));
        public delegate A3DStatus PFA3DRiPolyBrepModelEdit(ref A3DRiPolyBrepModelData pData, IntPtr pRIPolyBrepModel);
        public static PFA3DRiPolyBrepModelEdit A3DRiPolyBrepModelEdit = Marshal.GetDelegateForFunctionPointer<PFA3DRiPolyBrepModelEdit>(Library.A3DGetProcAddress("A3DRiPolyBrepModelEdit", 1));
        public delegate A3DStatus PFA3DRiPolyWireGet(IntPtr pRIPolyWire, ref A3DRiPolyWireData pData);
        public static PFA3DRiPolyWireGet A3DRiPolyWireGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiPolyWireGet>(Library.A3DGetProcAddress("A3DRiPolyWireGet", 1));
        public delegate A3DStatus PFA3DRiPolyWireCreate(ref A3DRiPolyWireData pData, out IntPtr ppRIPolyWire);
        public static PFA3DRiPolyWireCreate A3DRiPolyWireCreate = Marshal.GetDelegateForFunctionPointer<PFA3DRiPolyWireCreate>(Library.A3DGetProcAddress("A3DRiPolyWireCreate", 1));
        public delegate A3DStatus PFA3DFRMFeatureTreeGet(IntPtr pTree, ref A3DFRMFeatureTreeData pData);
        public static PFA3DFRMFeatureTreeGet A3DFRMFeatureTreeGet = Marshal.GetDelegateForFunctionPointer<PFA3DFRMFeatureTreeGet>(Library.A3DGetProcAddress("A3DFRMFeatureTreeGet", 1));
        public delegate A3DStatus PFA3DFRMParameterGet(IntPtr pParameter, ref A3DFRMParameterData pData);
        public static PFA3DFRMParameterGet A3DFRMParameterGet = Marshal.GetDelegateForFunctionPointer<PFA3DFRMParameterGet>(Library.A3DGetProcAddress("A3DFRMParameterGet", 1));
        public delegate A3DStatus PFA3DFRMStringDataGet(IntPtr pFeature, ref A3DFRMStringData pData);
        public static PFA3DFRMStringDataGet A3DFRMStringDataGet = Marshal.GetDelegateForFunctionPointer<PFA3DFRMStringDataGet>(Library.A3DGetProcAddress("A3DFRMStringDataGet", 1));
        public delegate A3DStatus PFA3DFRMDoubleDataGet(IntPtr pFeature, ref A3DFRMDoubleData pData);
        public static PFA3DFRMDoubleDataGet A3DFRMDoubleDataGet = Marshal.GetDelegateForFunctionPointer<PFA3DFRMDoubleDataGet>(Library.A3DGetProcAddress("A3DFRMDoubleDataGet", 1));
        public delegate A3DStatus PFA3DFRMIntegerDataGet(IntPtr pFeature, ref A3DFRMIntegerData pData);
        public static PFA3DFRMIntegerDataGet A3DFRMIntegerDataGet = Marshal.GetDelegateForFunctionPointer<PFA3DFRMIntegerDataGet>(Library.A3DGetProcAddress("A3DFRMIntegerDataGet", 1));
        public delegate A3DStatus PFA3DFRMEnumDataGet(IntPtr pFeature, out int m_piEnumValue, IntPtr ppcValueAsString);
        public static PFA3DFRMEnumDataGet A3DFRMEnumDataGet = Marshal.GetDelegateForFunctionPointer<PFA3DFRMEnumDataGet>(Library.A3DGetProcAddress("A3DFRMEnumDataGet", 1));
        public delegate A3DStatus PFA3DFRMFeatureLinkedItemGet(IntPtr p, ref A3DFRMFeatureLinkedItemData pData);
        public static PFA3DFRMFeatureLinkedItemGet A3DFRMFeatureLinkedItemGet = Marshal.GetDelegateForFunctionPointer<PFA3DFRMFeatureLinkedItemGet>(Library.A3DGetProcAddress("A3DFRMFeatureLinkedItemGet", 1));
        public delegate A3DStatus PFA3DFRMFeatureGet(IntPtr pFeature, ref A3DFRMFeatureData pData);
        public static PFA3DFRMFeatureGet A3DFRMFeatureGet = Marshal.GetDelegateForFunctionPointer<PFA3DFRMFeatureGet>(Library.A3DGetProcAddress("A3DFRMFeatureGet", 1));
        public delegate A3DStatus PFA3DFRMFeatureGetTypeAsString(IntPtr pFeature, IntPtr ppcFeatureType);
        public static PFA3DFRMFeatureGetTypeAsString A3DFRMFeatureGetTypeAsString = Marshal.GetDelegateForFunctionPointer<PFA3DFRMFeatureGetTypeAsString>(Library.A3DGetProcAddress("A3DFRMFeatureGetTypeAsString", 1));
        public delegate A3DStatus PFA3DFRMGetSpecificNodes(IntPtr pTree, EA3DFRMEnumValue_CadType eCADType, out uint piSize, IntPtr pppFeatureNodes);
        public static PFA3DFRMGetSpecificNodes A3DFRMGetSpecificNodes = Marshal.GetDelegateForFunctionPointer<PFA3DFRMGetSpecificNodes>(Library.A3DGetProcAddress("A3DFRMGetSpecificNodes", 1));
        public delegate A3DStatus PFA3DAsmPartDefinitionFeatureTreesGet(IntPtr pPartDefinition, out uint puiSize, IntPtr pppFeatureTrees);
        public static PFA3DAsmPartDefinitionFeatureTreesGet A3DAsmPartDefinitionFeatureTreesGet = Marshal.GetDelegateForFunctionPointer<PFA3DAsmPartDefinitionFeatureTreesGet>(Library.A3DGetProcAddress("A3DAsmPartDefinitionFeatureTreesGet", 1));
        public delegate A3DStatus PFA3DFRMFeatureGeomEntitiesExtract(IntPtr pFeature, ref A3DFRMFeatureGeomEntitiesData pFeatureGeomEntities);
        public static PFA3DFRMFeatureGeomEntitiesExtract A3DFRMFeatureGeomEntitiesExtract = Marshal.GetDelegateForFunctionPointer<PFA3DFRMFeatureGeomEntitiesExtract>(Library.A3DGetProcAddress("A3DFRMFeatureGeomEntitiesExtract", 1));
        public delegate A3DStatus PFA3DCrvNurbsGet(IntPtr pCrv, ref A3DCrvNurbsData pData);
        public static PFA3DCrvNurbsGet A3DCrvNurbsGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvNurbsGet>(Library.A3DGetProcAddress("A3DCrvNurbsGet", 1));
        public delegate A3DStatus PFA3DCrvNurbsCreate(ref A3DCrvNurbsData pData, out IntPtr ppCrv);
        public static PFA3DCrvNurbsCreate A3DCrvNurbsCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvNurbsCreate>(Library.A3DGetProcAddress("A3DCrvNurbsCreate", 1));
        public delegate A3DStatus PFA3DCrvBaseGetAsNurbs(IntPtr pCrv, double dTolerance, bool bUseSameParameterization, ref A3DCrvNurbsData pData);
        public static PFA3DCrvBaseGetAsNurbs A3DCrvBaseGetAsNurbs = Marshal.GetDelegateForFunctionPointer<PFA3DCrvBaseGetAsNurbs>(Library.A3DGetProcAddress("A3DCrvBaseGetAsNurbs", 1));
        public delegate A3DStatus PFA3DCrvLineGet(IntPtr pCrv, ref A3DCrvLineData pData);
        public static PFA3DCrvLineGet A3DCrvLineGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvLineGet>(Library.A3DGetProcAddress("A3DCrvLineGet", 1));
        public delegate A3DStatus PFA3DCrvLineCreate(ref A3DCrvLineData pData, out IntPtr ppCrv);
        public static PFA3DCrvLineCreate A3DCrvLineCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvLineCreate>(Library.A3DGetProcAddress("A3DCrvLineCreate", 1));
        public delegate A3DStatus PFA3DCrvCircleGet(IntPtr pCrv, ref A3DCrvCircleData pData);
        public static PFA3DCrvCircleGet A3DCrvCircleGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvCircleGet>(Library.A3DGetProcAddress("A3DCrvCircleGet", 1));
        public delegate A3DStatus PFA3DCrvCircleCreate(ref A3DCrvCircleData pData, out IntPtr ppCrv);
        public static PFA3DCrvCircleCreate A3DCrvCircleCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvCircleCreate>(Library.A3DGetProcAddress("A3DCrvCircleCreate", 1));
        public delegate A3DStatus PFA3DCrvEllipseGet(IntPtr pCrv, ref A3DCrvEllipseData pData);
        public static PFA3DCrvEllipseGet A3DCrvEllipseGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvEllipseGet>(Library.A3DGetProcAddress("A3DCrvEllipseGet", 1));
        public delegate A3DStatus PFA3DCrvEllipseCreate(ref A3DCrvEllipseData pData, out IntPtr ppCrv);
        public static PFA3DCrvEllipseCreate A3DCrvEllipseCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvEllipseCreate>(Library.A3DGetProcAddress("A3DCrvEllipseCreate", 1));
        public delegate A3DStatus PFA3DCrvParabolaGet(IntPtr pCrv, ref A3DCrvParabolaData pData);
        public static PFA3DCrvParabolaGet A3DCrvParabolaGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvParabolaGet>(Library.A3DGetProcAddress("A3DCrvParabolaGet", 1));
        public delegate A3DStatus PFA3DCrvParabolaCreate(ref A3DCrvParabolaData pData, out IntPtr ppCrv);
        public static PFA3DCrvParabolaCreate A3DCrvParabolaCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvParabolaCreate>(Library.A3DGetProcAddress("A3DCrvParabolaCreate", 1));
        public delegate A3DStatus PFA3DCrvHyperbolaGet(IntPtr pCrv, ref A3DCrvHyperbolaData pData);
        public static PFA3DCrvHyperbolaGet A3DCrvHyperbolaGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvHyperbolaGet>(Library.A3DGetProcAddress("A3DCrvHyperbolaGet", 1));
        public delegate A3DStatus PFA3DCrvHyperbolaCreate(ref A3DCrvHyperbolaData pData, out IntPtr ppCrv);
        public static PFA3DCrvHyperbolaCreate A3DCrvHyperbolaCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvHyperbolaCreate>(Library.A3DGetProcAddress("A3DCrvHyperbolaCreate", 1));
        public delegate A3DStatus PFA3DCrvPolyLineGet(IntPtr pCrv, ref A3DCrvPolyLineData pData);
        public static PFA3DCrvPolyLineGet A3DCrvPolyLineGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvPolyLineGet>(Library.A3DGetProcAddress("A3DCrvPolyLineGet", 1));
        public delegate A3DStatus PFA3DCrvPolyLineCreate(ref A3DCrvPolyLineData pData, out IntPtr ppCrv);
        public static PFA3DCrvPolyLineCreate A3DCrvPolyLineCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvPolyLineCreate>(Library.A3DGetProcAddress("A3DCrvPolyLineCreate", 1));
        public delegate A3DStatus PFA3DCrvCompositeGet(IntPtr pCrv, ref A3DCrvCompositeData pData);
        public static PFA3DCrvCompositeGet A3DCrvCompositeGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvCompositeGet>(Library.A3DGetProcAddress("A3DCrvCompositeGet", 1));
        public delegate A3DStatus PFA3DCrvCompositeCreate(ref A3DCrvCompositeData pData, out IntPtr ppCrv);
        public static PFA3DCrvCompositeCreate A3DCrvCompositeCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvCompositeCreate>(Library.A3DGetProcAddress("A3DCrvCompositeCreate", 1));
        public delegate A3DStatus PFA3DCrvEquationGet(IntPtr pCrv, ref A3DCrvEquationData pData);
        public static PFA3DCrvEquationGet A3DCrvEquationGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvEquationGet>(Library.A3DGetProcAddress("A3DCrvEquationGet", 1));
        public delegate A3DStatus PFA3DCrvEquationCreate(ref A3DCrvEquationData pData, out IntPtr ppCrv);
        public static PFA3DCrvEquationCreate A3DCrvEquationCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvEquationCreate>(Library.A3DGetProcAddress("A3DCrvEquationCreate", 1));
        public delegate A3DStatus PFA3DCrvTransformGet(IntPtr pCrv, ref A3DCrvTransformData pData);
        public static PFA3DCrvTransformGet A3DCrvTransformGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvTransformGet>(Library.A3DGetProcAddress("A3DCrvTransformGet", 1));
        public delegate A3DStatus PFA3DCrvTransformCreate(ref A3DCrvTransformData pData, out IntPtr ppCrv);
        public static PFA3DCrvTransformCreate A3DCrvTransformCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvTransformCreate>(Library.A3DGetProcAddress("A3DCrvTransformCreate", 1));
        public delegate A3DStatus PFA3DCrvOnSurfGet(IntPtr pCrv, ref A3DCrvOnSurfData pData);
        public static PFA3DCrvOnSurfGet A3DCrvOnSurfGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvOnSurfGet>(Library.A3DGetProcAddress("A3DCrvOnSurfGet", 1));
        public delegate A3DStatus PFA3DCrvOnSurfCreate(ref A3DCrvOnSurfData pData, out IntPtr ppCrv);
        public static PFA3DCrvOnSurfCreate A3DCrvOnSurfCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvOnSurfCreate>(Library.A3DGetProcAddress("A3DCrvOnSurfCreate", 1));
        public delegate A3DStatus PFA3DCrvOffsetGet(IntPtr pCrv, ref A3DCrvOffsetData pData);
        public static PFA3DCrvOffsetGet A3DCrvOffsetGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvOffsetGet>(Library.A3DGetProcAddress("A3DCrvOffsetGet", 1));
        public delegate A3DStatus PFA3DCrvOffsetCreate(ref A3DCrvOffsetData pData, out IntPtr ppCrv);
        public static PFA3DCrvOffsetCreate A3DCrvOffsetCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvOffsetCreate>(Library.A3DGetProcAddress("A3DCrvOffsetCreate", 1));
        public delegate A3DStatus PFA3DCrvHelixGet(IntPtr pCrv, ref A3DCrvHelixData pData);
        public static PFA3DCrvHelixGet A3DCrvHelixGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvHelixGet>(Library.A3DGetProcAddress("A3DCrvHelixGet", 1));
        public delegate A3DStatus PFA3DCrvHelixCreate(ref A3DCrvHelixData pData, out IntPtr ppCrv);
        public static PFA3DCrvHelixCreate A3DCrvHelixCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvHelixCreate>(Library.A3DGetProcAddress("A3DCrvHelixCreate", 1));
        public delegate A3DStatus PFA3DCrvIntersectionGet(IntPtr pCrv, ref A3DCrvIntersectionData pData);
        public static PFA3DCrvIntersectionGet A3DCrvIntersectionGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvIntersectionGet>(Library.A3DGetProcAddress("A3DCrvIntersectionGet", 1));
        public delegate A3DStatus PFA3DCrvIntersectionCreate(ref A3DCrvIntersectionData pData, out IntPtr ppCrv);
        public static PFA3DCrvIntersectionCreate A3DCrvIntersectionCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvIntersectionCreate>(Library.A3DGetProcAddress("A3DCrvIntersectionCreate", 1));
        public delegate A3DStatus PFA3DCrvBlend02BoundaryGet(IntPtr pCrv, ref A3DCrvBlend02BoundaryData pData);
        public static PFA3DCrvBlend02BoundaryGet A3DCrvBlend02BoundaryGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvBlend02BoundaryGet>(Library.A3DGetProcAddress("A3DCrvBlend02BoundaryGet", 1));
        public delegate A3DStatus PFA3DCrvBlend02BoundaryCreate(ref A3DCrvBlend02BoundaryData pData, out IntPtr ppCrv);
        public static PFA3DCrvBlend02BoundaryCreate A3DCrvBlend02BoundaryCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvBlend02BoundaryCreate>(Library.A3DGetProcAddress("A3DCrvBlend02BoundaryCreate", 1));
        public delegate A3DStatus PFA3DSurfNurbsGet(IntPtr pSrf, ref A3DSurfNurbsData pData);
        public static PFA3DSurfNurbsGet A3DSurfNurbsGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfNurbsGet>(Library.A3DGetProcAddress("A3DSurfNurbsGet", 1));
        public delegate A3DStatus PFA3DSurfNurbsCreate(ref A3DSurfNurbsData pData, out IntPtr ppSrf);
        public static PFA3DSurfNurbsCreate A3DSurfNurbsCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfNurbsCreate>(Library.A3DGetProcAddress("A3DSurfNurbsCreate", 1));
        public delegate A3DStatus PFA3DSurfBaseGetAsNurbs(IntPtr pSrf, double dTolerance, bool bUseSameParameterization, ref A3DSurfNurbsData pData);
        public static PFA3DSurfBaseGetAsNurbs A3DSurfBaseGetAsNurbs = Marshal.GetDelegateForFunctionPointer<PFA3DSurfBaseGetAsNurbs>(Library.A3DGetProcAddress("A3DSurfBaseGetAsNurbs", 1));
        public delegate A3DStatus PFA3DSurfSphereGet(IntPtr pSrf, ref A3DSurfSphereData pData);
        public static PFA3DSurfSphereGet A3DSurfSphereGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfSphereGet>(Library.A3DGetProcAddress("A3DSurfSphereGet", 1));
        public delegate A3DStatus PFA3DSurfSphereCreate(ref A3DSurfSphereData pData, out IntPtr ppSrf);
        public static PFA3DSurfSphereCreate A3DSurfSphereCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfSphereCreate>(Library.A3DGetProcAddress("A3DSurfSphereCreate", 1));
        public delegate A3DStatus PFA3DSurfCylinderGet(IntPtr pSrf, ref A3DSurfCylinderData pData);
        public static PFA3DSurfCylinderGet A3DSurfCylinderGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfCylinderGet>(Library.A3DGetProcAddress("A3DSurfCylinderGet", 1));
        public delegate A3DStatus PFA3DSurfCylinderCreate(ref A3DSurfCylinderData pData, out IntPtr ppSrf);
        public static PFA3DSurfCylinderCreate A3DSurfCylinderCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfCylinderCreate>(Library.A3DGetProcAddress("A3DSurfCylinderCreate", 1));
        public delegate A3DStatus PFA3DSurfTorusGet(IntPtr pSrf, ref A3DSurfTorusData pData);
        public static PFA3DSurfTorusGet A3DSurfTorusGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfTorusGet>(Library.A3DGetProcAddress("A3DSurfTorusGet", 1));
        public delegate A3DStatus PFA3DSurfTorusCreate(ref A3DSurfTorusData pData, out IntPtr ppSrf);
        public static PFA3DSurfTorusCreate A3DSurfTorusCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfTorusCreate>(Library.A3DGetProcAddress("A3DSurfTorusCreate", 1));
        public delegate A3DStatus PFA3DSurfRevolutionGet(IntPtr pSrf, ref A3DSurfRevolutionData pData);
        public static PFA3DSurfRevolutionGet A3DSurfRevolutionGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfRevolutionGet>(Library.A3DGetProcAddress("A3DSurfRevolutionGet", 1));
        public delegate A3DStatus PFA3DSurfRevolutionCreate(ref A3DSurfRevolutionData pData, out IntPtr ppSrf);
        public static PFA3DSurfRevolutionCreate A3DSurfRevolutionCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfRevolutionCreate>(Library.A3DGetProcAddress("A3DSurfRevolutionCreate", 1));
        public delegate A3DStatus PFA3DSurfExtrusionGet(IntPtr pSrf, ref A3DSurfExtrusionData pData);
        public static PFA3DSurfExtrusionGet A3DSurfExtrusionGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfExtrusionGet>(Library.A3DGetProcAddress("A3DSurfExtrusionGet", 1));
        public delegate A3DStatus PFA3DSurfExtrusionCreate(ref A3DSurfExtrusionData pData, out IntPtr ppSrf);
        public static PFA3DSurfExtrusionCreate A3DSurfExtrusionCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfExtrusionCreate>(Library.A3DGetProcAddress("A3DSurfExtrusionCreate", 1));
        public delegate A3DStatus PFA3DSurfOffsetGet(IntPtr pSrf, ref A3DSurfOffsetData pData);
        public static PFA3DSurfOffsetGet A3DSurfOffsetGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfOffsetGet>(Library.A3DGetProcAddress("A3DSurfOffsetGet", 1));
        public delegate A3DStatus PFA3DSurfOffsetCreate(ref A3DSurfOffsetData pData, out IntPtr ppSrf);
        public static PFA3DSurfOffsetCreate A3DSurfOffsetCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfOffsetCreate>(Library.A3DGetProcAddress("A3DSurfOffsetCreate", 1));
        public delegate A3DStatus PFA3DSurfPlaneGet(IntPtr pSrf, ref A3DSurfPlaneData pData);
        public static PFA3DSurfPlaneGet A3DSurfPlaneGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfPlaneGet>(Library.A3DGetProcAddress("A3DSurfPlaneGet", 1));
        public delegate A3DStatus PFA3DSurfPlaneCreate(ref A3DSurfPlaneData pData, out IntPtr ppSrf);
        public static PFA3DSurfPlaneCreate A3DSurfPlaneCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfPlaneCreate>(Library.A3DGetProcAddress("A3DSurfPlaneCreate", 1));
        public delegate A3DStatus PFA3DSurfBlend01Get(IntPtr pSrf, ref A3DSurfBlend01Data pData);
        public static PFA3DSurfBlend01Get A3DSurfBlend01Get = Marshal.GetDelegateForFunctionPointer<PFA3DSurfBlend01Get>(Library.A3DGetProcAddress("A3DSurfBlend01Get", 1));
        public delegate A3DStatus PFA3DSurfBlend01Create(ref A3DSurfBlend01Data pData, out IntPtr ppSrf);
        public static PFA3DSurfBlend01Create A3DSurfBlend01Create = Marshal.GetDelegateForFunctionPointer<PFA3DSurfBlend01Create>(Library.A3DGetProcAddress("A3DSurfBlend01Create", 1));
        public delegate A3DStatus PFA3DSurfBlend02Get(IntPtr pSrf, ref A3DSurfBlend02Data pData);
        public static PFA3DSurfBlend02Get A3DSurfBlend02Get = Marshal.GetDelegateForFunctionPointer<PFA3DSurfBlend02Get>(Library.A3DGetProcAddress("A3DSurfBlend02Get", 1));
        public delegate A3DStatus PFA3DSurfBlend02Create(ref A3DSurfBlend02Data pData, out IntPtr ppSrf);
        public static PFA3DSurfBlend02Create A3DSurfBlend02Create = Marshal.GetDelegateForFunctionPointer<PFA3DSurfBlend02Create>(Library.A3DGetProcAddress("A3DSurfBlend02Create", 1));
        public delegate A3DStatus PFA3DSurfBlend03Get(IntPtr pSrf, ref A3DSurfBlend03Data pData);
        public static PFA3DSurfBlend03Get A3DSurfBlend03Get = Marshal.GetDelegateForFunctionPointer<PFA3DSurfBlend03Get>(Library.A3DGetProcAddress("A3DSurfBlend03Get", 1));
        public delegate A3DStatus PFA3DSurfBlend03Create(ref A3DSurfBlend03Data pData, out IntPtr ppSrf);
        public static PFA3DSurfBlend03Create A3DSurfBlend03Create = Marshal.GetDelegateForFunctionPointer<PFA3DSurfBlend03Create>(Library.A3DGetProcAddress("A3DSurfBlend03Create", 1));
        public delegate A3DStatus PFA3DSurfConeGet(IntPtr pSrf, ref A3DSurfConeData pData);
        public static PFA3DSurfConeGet A3DSurfConeGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfConeGet>(Library.A3DGetProcAddress("A3DSurfConeGet", 1));
        public delegate A3DStatus PFA3DSurfConeCreate(ref A3DSurfConeData pData, out IntPtr ppSrf);
        public static PFA3DSurfConeCreate A3DSurfConeCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfConeCreate>(Library.A3DGetProcAddress("A3DSurfConeCreate", 1));
        public delegate A3DStatus PFA3DSurfCylindricalGet(IntPtr pSrf, ref A3DSurfCylindricalData pData);
        public static PFA3DSurfCylindricalGet A3DSurfCylindricalGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfCylindricalGet>(Library.A3DGetProcAddress("A3DSurfCylindricalGet", 1));
        public delegate A3DStatus PFA3DSurfCylindricalCreate(ref A3DSurfCylindricalData pData, out IntPtr ppSrf);
        public static PFA3DSurfCylindricalCreate A3DSurfCylindricalCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfCylindricalCreate>(Library.A3DGetProcAddress("A3DSurfCylindricalCreate", 1));
        public delegate A3DStatus PFA3DSurfRuledGet(IntPtr pSrf, ref A3DSurfRuledData pData);
        public static PFA3DSurfRuledGet A3DSurfRuledGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfRuledGet>(Library.A3DGetProcAddress("A3DSurfRuledGet", 1));
        public delegate A3DStatus PFA3DSurfRuledCreate(ref A3DSurfRuledData pData, out IntPtr ppSrf);
        public static PFA3DSurfRuledCreate A3DSurfRuledCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfRuledCreate>(Library.A3DGetProcAddress("A3DSurfRuledCreate", 1));
        public delegate A3DStatus PFA3DSurfPipeGet(IntPtr pSrf, ref A3DSurfPipeData pData);
        public static PFA3DSurfPipeGet A3DSurfPipeGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfPipeGet>(Library.A3DGetProcAddress("A3DSurfPipeGet", 1));
        public delegate A3DStatus PFA3DSurfPipeCreate(ref A3DSurfPipeData pData, out IntPtr ppSrf);
        public static PFA3DSurfPipeCreate A3DSurfPipeCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfPipeCreate>(Library.A3DGetProcAddress("A3DSurfPipeCreate", 1));
        public delegate A3DStatus PFA3DSurfTransformGet(IntPtr pSrf, ref A3DSurfTransformData pData);
        public static PFA3DSurfTransformGet A3DSurfTransformGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfTransformGet>(Library.A3DGetProcAddress("A3DSurfTransformGet", 1));
        public delegate A3DStatus PFA3DSurfTransformCreate(ref A3DSurfTransformData pData, out IntPtr ppSrf);
        public static PFA3DSurfTransformCreate A3DSurfTransformCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfTransformCreate>(Library.A3DGetProcAddress("A3DSurfTransformCreate", 1));
        public delegate A3DStatus PFA3DSurfFromCurvesGet(IntPtr pSrf, ref A3DSurfFromCurvesData pData);
        public static PFA3DSurfFromCurvesGet A3DSurfFromCurvesGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfFromCurvesGet>(Library.A3DGetProcAddress("A3DSurfFromCurvesGet", 1));
        public delegate A3DStatus PFA3DSurfFromCurvesCreate(ref A3DSurfFromCurvesData pData, out IntPtr ppSrf);
        public static PFA3DSurfFromCurvesCreate A3DSurfFromCurvesCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfFromCurvesCreate>(Library.A3DGetProcAddress("A3DSurfFromCurvesCreate", 1));
        public delegate A3DStatus PFA3DGlobalGetPointer(out IntPtr ppGlobal);
        public static PFA3DGlobalGetPointer A3DGlobalGetPointer = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetPointer>(Library.A3DGetProcAddress("A3DGlobalGetPointer", 1));
        public delegate A3DStatus PFA3DGlobalGet(IntPtr pGlobal, ref A3DGlobalData pData);
        public static PFA3DGlobalGet A3DGlobalGet = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGet>(Library.A3DGetProcAddress("A3DGlobalGet", 1));
        public delegate A3DStatus PFA3DGlobalIsMaterialTexture(uint uiIndexMaterial, out bool pbIsTexture);
        public static PFA3DGlobalIsMaterialTexture A3DGlobalIsMaterialTexture = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalIsMaterialTexture>(Library.A3DGetProcAddress("A3DGlobalIsMaterialTexture", 1));
        public delegate A3DStatus PFA3DGlobalGetFillPatternType(uint uiIndexPattern, ref A3DEEntityType pePatternType);
        public static PFA3DGlobalGetFillPatternType A3DGlobalGetFillPatternType = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetFillPatternType>(Library.A3DGetProcAddress("A3DGlobalGetFillPatternType", 1));
        public delegate A3DStatus PFA3DLicPutUnifiedLicense([MarshalAs(UnmanagedType.LPStr)] string pcUnifiedKey);
        public static PFA3DLicPutUnifiedLicense A3DLicPutUnifiedLicense = Marshal.GetDelegateForFunctionPointer<PFA3DLicPutUnifiedLicense>(Library.A3DGetProcAddress("A3DLicPutUnifiedLicense", 1));
        public delegate A3DStatus PFA3DMDPosition3DGet(IntPtr pPosition3D, ref A3DMDPosition3DData pData);
        public static PFA3DMDPosition3DGet A3DMDPosition3DGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDPosition3DGet>(Library.A3DGetProcAddress("A3DMDPosition3DGet", 1));
        public delegate A3DStatus PFA3DMDPosition2DGet(IntPtr pPosition2D, ref A3DMDPosition2DData pData);
        public static PFA3DMDPosition2DGet A3DMDPosition2DGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDPosition2DGet>(Library.A3DGetProcAddress("A3DMDPosition2DGet", 1));
        public delegate A3DStatus PFA3DMDPositionReferenceGet(IntPtr pPositionReference, ref A3DMDPositionReferenceData pData);
        public static PFA3DMDPositionReferenceGet A3DMDPositionReferenceGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDPositionReferenceGet>(Library.A3DGetProcAddress("A3DMDPositionReferenceGet", 1));
        public delegate A3DStatus PFA3DMDLeaderSymbolGet(IntPtr pLeaderSymbol, ref A3DMDLeaderSymbolData pData);
        public static PFA3DMDLeaderSymbolGet A3DMDLeaderSymbolGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDLeaderSymbolGet>(Library.A3DGetProcAddress("A3DMDLeaderSymbolGet", 1));
        public delegate A3DStatus PFA3DMDMarkupLeaderStubGet(IntPtr pLeaderStub, ref A3DMDMarkupLeaderStubData pData);
        public static PFA3DMDMarkupLeaderStubGet A3DMDMarkupLeaderStubGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDMarkupLeaderStubGet>(Library.A3DGetProcAddress("A3DMDMarkupLeaderStubGet", 1));
        public delegate A3DStatus PFA3DMDLeaderDefinitionGet(IntPtr pLeader, ref A3DMDLeaderDefinitionData pData);
        public static PFA3DMDLeaderDefinitionGet A3DMDLeaderDefinitionGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDLeaderDefinitionGet>(Library.A3DGetProcAddress("A3DMDLeaderDefinitionGet", 1));
        public delegate A3DStatus PFA3DMDTextPropertiesGet(IntPtr pTextProperties, ref A3DMDTextPropertiesData pData);
        public static PFA3DMDTextPropertiesGet A3DMDTextPropertiesGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDTextPropertiesGet>(Library.A3DGetProcAddress("A3DMDTextPropertiesGet", 1));
        public delegate A3DStatus PFA3DMarkupDefinitionGet(IntPtr pMarkupDefinition, ref A3DMarkupDefinitionData pData);
        public static PFA3DMarkupDefinitionGet A3DMarkupDefinitionGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupDefinitionGet>(Library.A3DGetProcAddress("A3DMarkupDefinitionGet", 1));
        public delegate A3DStatus PFA3DMarkupPositionIsScreenLocation(IntPtr pMarkupDefinition, out bool pIsScreenLocation, ref A3DMDPosition2DData pPosition, ref A3DVector2dData pOffsetAnchorPoint);
        public static PFA3DMarkupPositionIsScreenLocation A3DMarkupPositionIsScreenLocation = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupPositionIsScreenLocation>(Library.A3DGetProcAddress("A3DMarkupPositionIsScreenLocation", 1));
        public delegate A3DStatus PFA3DMDDimensionValueFormatGet(IntPtr pDimensionValueFormat, ref A3DMDDimensionValueFormatData pData);
        public static PFA3DMDDimensionValueFormatGet A3DMDDimensionValueFormatGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionValueFormatGet>(Library.A3DGetProcAddress("A3DMDDimensionValueFormatGet", 1));
        public delegate A3DStatus PFA3DMDDimensionSimpleToleranceFormatGet(IntPtr pDimensionToleranceFormat, ref A3DMDDimensionSimpleToleranceFormatData pData);
        public static PFA3DMDDimensionSimpleToleranceFormatGet A3DMDDimensionSimpleToleranceFormatGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionSimpleToleranceFormatGet>(Library.A3DGetProcAddress("A3DMDDimensionSimpleToleranceFormatGet", 1));
        public delegate A3DStatus PFA3DMDDimensionCombinedToleranceFormatGet(IntPtr pDimensionCombinedToleranceFormat, ref A3DMDDimensionCombinedToleranceFormatData pData);
        public static PFA3DMDDimensionCombinedToleranceFormatGet A3DMDDimensionCombinedToleranceFormatGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionCombinedToleranceFormatGet>(Library.A3DGetProcAddress("A3DMDDimensionCombinedToleranceFormatGet", 1));
        public delegate A3DStatus PFA3DMDDimensionValueGet(IntPtr pDimensionValue, ref A3DMDDimensionValueData pData);
        public static PFA3DMDDimensionValueGet A3DMDDimensionValueGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionValueGet>(Library.A3DGetProcAddress("A3DMDDimensionValueGet", 1));
        public delegate A3DStatus PFA3DMDDimensionSecondPartGet(IntPtr pDimensionSecondPart, ref A3DMDDimensionSecondPartData pData);
        public static PFA3DMDDimensionSecondPartGet A3DMDDimensionSecondPartGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionSecondPartGet>(Library.A3DGetProcAddress("A3DMDDimensionSecondPartGet", 1));
        public delegate A3DStatus PFA3DMDDimensionForeshortenedGet(IntPtr pDimensionForeshortened, ref A3DMDDimensionForeshortenedData pData);
        public static PFA3DMDDimensionForeshortenedGet A3DMDDimensionForeshortenedGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionForeshortenedGet>(Library.A3DGetProcAddress("A3DMDDimensionForeshortenedGet", 1));
        public delegate A3DStatus PFA3DMDDimensionLineSymbolGet(IntPtr pDimensionLineSymbol, ref A3DMDDimensionLineSymbolData pData);
        public static PFA3DMDDimensionLineSymbolGet A3DMDDimensionLineSymbolGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionLineSymbolGet>(Library.A3DGetProcAddress("A3DMDDimensionLineSymbolGet", 1));
        public delegate A3DStatus PFA3DMDDimensionLineGet(IntPtr pDimensionLine, ref A3DMDDimensionLineData pData);
        public static PFA3DMDDimensionLineGet A3DMDDimensionLineGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionLineGet>(Library.A3DGetProcAddress("A3DMDDimensionLineGet", 1));
        public delegate A3DStatus PFA3DMDDimensionFunnelGet(IntPtr pDimensionFunnel, ref A3DMDDimensionFunnelData pData);
        public static PFA3DMDDimensionFunnelGet A3DMDDimensionFunnelGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionFunnelGet>(Library.A3DGetProcAddress("A3DMDDimensionFunnelGet", 1));
        public delegate A3DStatus PFA3DMDDimensionExtremityGet(IntPtr pDimensionExtremity, ref A3DMDDimensionExtremityData pData);
        public static PFA3DMDDimensionExtremityGet A3DMDDimensionExtremityGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionExtremityGet>(Library.A3DGetProcAddress("A3DMDDimensionExtremityGet", 1));
        public delegate A3DStatus PFA3DMDDimensionExtentionLineGet(IntPtr pDimensionExtentionLine, ref A3DMDDimensionExtentionLineData pData);
        public static PFA3DMDDimensionExtentionLineGet A3DMDDimensionExtentionLineGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionExtentionLineGet>(Library.A3DGetProcAddress("A3DMDDimensionExtentionLineGet", 1));
        public delegate A3DStatus PFA3DMarkupDimensionGet(IntPtr pDimension, ref A3DMarkupDimensionData pData);
        public static PFA3DMarkupDimensionGet A3DMarkupDimensionGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupDimensionGet>(Library.A3DGetProcAddress("A3DMarkupDimensionGet", 1));
        public delegate A3DStatus PFA3DMarkupRoughnessGet(IntPtr pMarkupRoughness, ref A3DMarkupRoughnessData pData);
        public static PFA3DMarkupRoughnessGet A3DMarkupRoughnessGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupRoughnessGet>(Library.A3DGetProcAddress("A3DMarkupRoughnessGet", 1));
        public delegate A3DStatus PFA3DMarkupBalloonGet(IntPtr pBalloon, ref A3DMarkupBalloonData pData);
        public static PFA3DMarkupBalloonGet A3DMarkupBalloonGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupBalloonGet>(Library.A3DGetProcAddress("A3DMarkupBalloonGet", 1));
        public delegate A3DStatus PFA3DMarkupFastenerGet(IntPtr pFastener, ref A3DMarkupFastenerData pData);
        public static PFA3DMarkupFastenerGet A3DMarkupFastenerGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupFastenerGet>(Library.A3DGetProcAddress("A3DMarkupFastenerGet", 1));
        public delegate A3DStatus PFA3DMarkupLocatorGet(IntPtr pLocator, ref A3DMarkupLocatorData pData);
        public static PFA3DMarkupLocatorGet A3DMarkupLocatorGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupLocatorGet>(Library.A3DGetProcAddress("A3DMarkupLocatorGet", 1));
        public delegate A3DStatus PFA3DMarkupMeasurementPointGet(IntPtr pMeasurementPoint, ref A3DMarkupMeasurementPointData pData);
        public static PFA3DMarkupMeasurementPointGet A3DMarkupMeasurementPointGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupMeasurementPointGet>(Library.A3DGetProcAddress("A3DMarkupMeasurementPointGet", 1));
        public delegate A3DStatus PFA3DMDTextPositionGet(IntPtr pTextPosition, ref A3DMDTextPositionData pData);
        public static PFA3DMDTextPositionGet A3DMDTextPositionGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDTextPositionGet>(Library.A3DGetProcAddress("A3DMDTextPositionGet", 1));
        public delegate A3DStatus PFA3DMarkupTextGet(IntPtr pMarkupText, ref A3DMarkupTextData pData);
        public static PFA3DMarkupTextGet A3DMarkupTextGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupTextGet>(Library.A3DGetProcAddress("A3DMarkupTextGet", 1));
        public delegate A3DStatus PFA3DMarkupCoordinateGet(IntPtr pMarkupCoordinate, ref A3DMarkupCoordinateData pData);
        public static PFA3DMarkupCoordinateGet A3DMarkupCoordinateGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupCoordinateGet>(Library.A3DGetProcAddress("A3DMarkupCoordinateGet", 1));
        public delegate A3DStatus PFA3DMarkupRichTextGet(IntPtr pMarkupRichText, ref A3DMarkupRichTextData pData);
        public static PFA3DMarkupRichTextGet A3DMarkupRichTextGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupRichTextGet>(Library.A3DGetProcAddress("A3DMarkupRichTextGet", 1));
        public delegate A3DStatus PFA3DMarkupDatumGet(IntPtr pMarkupDatum, ref A3DMarkupDatumData pData);
        public static PFA3DMarkupDatumGet A3DMarkupDatumGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupDatumGet>(Library.A3DGetProcAddress("A3DMarkupDatumGet", 1));
        public delegate A3DStatus PFA3DMDFCFDraftingRowGet(IntPtr pDraftingRow, ref A3DMDFCFDraftingRowData pData);
        public static PFA3DMDFCFDraftingRowGet A3DMDFCFDraftingRowGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDFCFDraftingRowGet>(Library.A3DGetProcAddress("A3DMDFCFDraftingRowGet", 1));
        public delegate A3DStatus PFA3DMDFCValueGet(IntPtr pValue, ref A3DMDFCValueData pData);
        public static PFA3DMDFCValueGet A3DMDFCValueGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDFCValueGet>(Library.A3DGetProcAddress("A3DMDFCValueGet", 1));
        public delegate A3DStatus PFA3DMDFCTolerancePerUnitGet(IntPtr pTolerancePerUnit, ref A3DMDFCTolerancePerUnitData pData);
        public static PFA3DMDFCTolerancePerUnitGet A3DMDFCTolerancePerUnitGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDFCTolerancePerUnitGet>(Library.A3DGetProcAddress("A3DMDFCTolerancePerUnitGet", 1));
        public delegate A3DStatus PFA3DMDFCProjectedZoneGet(IntPtr pProjectedZone, ref A3DMDFCProjectedZoneData pData);
        public static PFA3DMDFCProjectedZoneGet A3DMDFCProjectedZoneGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDFCProjectedZoneGet>(Library.A3DGetProcAddress("A3DMDFCProjectedZoneGet", 1));
        public delegate A3DStatus PFA3DMDFCFToleranceValueGet(IntPtr pToleranceValue, ref A3DMDFCFToleranceValueData pData);
        public static PFA3DMDFCFToleranceValueGet A3DMDFCFToleranceValueGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDFCFToleranceValueGet>(Library.A3DGetProcAddress("A3DMDFCFToleranceValueGet", 1));
        public delegate A3DStatus PFA3DMDFCFRowDatumGet(IntPtr pRowDatum, ref A3DMDFCFRowDatumData pData);
        public static PFA3DMDFCFRowDatumGet A3DMDFCFRowDatumGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDFCFRowDatumGet>(Library.A3DGetProcAddress("A3DMDFCFRowDatumGet", 1));
        public delegate A3DStatus PFA3DMDFCFDrawingRowGet(IntPtr pDrawingRow, ref A3DMDFCFDrawingRowData pData);
        public static PFA3DMDFCFDrawingRowGet A3DMDFCFDrawingRowGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDFCFDrawingRowGet>(Library.A3DGetProcAddress("A3DMDFCFDrawingRowGet", 1));
        public delegate A3DStatus PFA3DMDFCFSemanticRowGet(IntPtr pRow, ref A3DMDFCFDrawingRowData pData);
        public static PFA3DMDFCFSemanticRowGet A3DMDFCFSemanticRowGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDFCFSemanticRowGet>(Library.A3DGetProcAddress("A3DMDFCFSemanticRowGet", 1));
        public delegate A3DStatus PFA3DMDFCFIndicatorGet(IntPtr pIndicator, ref A3DMDFCFIndicatorData pData);
        public static PFA3DMDFCFIndicatorGet A3DMDFCFIndicatorGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDFCFIndicatorGet>(Library.A3DGetProcAddress("A3DMDFCFIndicatorGet", 1));
        public delegate A3DStatus PFA3DMDFeatureControlFrameGet(IntPtr pFCF, ref A3DMDFeatureControlFrameData pData);
        public static PFA3DMDFeatureControlFrameGet A3DMDFeatureControlFrameGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDFeatureControlFrameGet>(Library.A3DGetProcAddress("A3DMDFeatureControlFrameGet", 1));
        public delegate A3DStatus PFA3DMDSemanticFeatureControlFrameGet(IntPtr pFCF, ref A3DMDFeatureControlFrameData pData);
        public static PFA3DMDSemanticFeatureControlFrameGet A3DMDSemanticFeatureControlFrameGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDSemanticFeatureControlFrameGet>(Library.A3DGetProcAddress("A3DMDSemanticFeatureControlFrameGet", 1));
        public delegate A3DStatus PFA3DMDToleranceSizeGet(IntPtr pToleranceSize, ref A3DMDToleranceSizeData pData);
        public static PFA3DMDToleranceSizeGet A3DMDToleranceSizeGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDToleranceSizeGet>(Library.A3DGetProcAddress("A3DMDToleranceSizeGet", 1));
        public delegate A3DStatus PFA3DMDToleranceSizeValueGet(IntPtr pToleranceSizeValue, ref A3DMDToleranceSizeValueData pData);
        public static PFA3DMDToleranceSizeValueGet A3DMDToleranceSizeValueGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDToleranceSizeValueGet>(Library.A3DGetProcAddress("A3DMDToleranceSizeValueGet", 1));
        public delegate A3DStatus PFA3DMarkupGDTGet(IntPtr pMarkupGDT, ref A3DMarkupGDTData pData);
        public static PFA3DMarkupGDTGet A3DMarkupGDTGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupGDTGet>(Library.A3DGetProcAddress("A3DMarkupGDTGet", 1));
        public delegate A3DStatus PFA3DMarkupSpotWeldingGet(IntPtr pSpotWelding, ref A3DMarkupSpotWeldingData pData);
        public static PFA3DMarkupSpotWeldingGet A3DMarkupSpotWeldingGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupSpotWeldingGet>(Library.A3DGetProcAddress("A3DMarkupSpotWeldingGet", 1));
        public delegate A3DStatus PFA3DMarkupLineWeldingGet(IntPtr pLineWelding, ref A3DMarkupLineWeldingData pData);
        public static PFA3DMarkupLineWeldingGet A3DMarkupLineWeldingGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupLineWeldingGet>(Library.A3DGetProcAddress("A3DMarkupLineWeldingGet", 1));
        public delegate A3DStatus PFA3DMathFct1DPolynomGet(IntPtr pMathFn, ref A3DMathFct1DPolynomData pData);
        public static PFA3DMathFct1DPolynomGet A3DMathFct1DPolynomGet = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct1DPolynomGet>(Library.A3DGetProcAddress("A3DMathFct1DPolynomGet", 1));
        public delegate A3DStatus PFA3DMathFct1DPolynomCreate(ref A3DMathFct1DPolynomData pData, out IntPtr ppMathFn);
        public static PFA3DMathFct1DPolynomCreate A3DMathFct1DPolynomCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct1DPolynomCreate>(Library.A3DGetProcAddress("A3DMathFct1DPolynomCreate", 1));
        public delegate A3DStatus PFA3DMathFct1DTrigonometricGet(IntPtr pMathFn, ref A3DMathFct1DTrigonometricData pData);
        public static PFA3DMathFct1DTrigonometricGet A3DMathFct1DTrigonometricGet = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct1DTrigonometricGet>(Library.A3DGetProcAddress("A3DMathFct1DTrigonometricGet", 1));
        public delegate A3DStatus PFA3DMathFct1DTrigonometricCreate(ref A3DMathFct1DTrigonometricData pData, out IntPtr ppMathFn);
        public static PFA3DMathFct1DTrigonometricCreate A3DMathFct1DTrigonometricCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct1DTrigonometricCreate>(Library.A3DGetProcAddress("A3DMathFct1DTrigonometricCreate", 1));
        public delegate A3DStatus PFA3DMathFct1DFractionGet(IntPtr pMathFn, ref A3DMathFct1DFractionData pData);
        public static PFA3DMathFct1DFractionGet A3DMathFct1DFractionGet = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct1DFractionGet>(Library.A3DGetProcAddress("A3DMathFct1DFractionGet", 1));
        public delegate A3DStatus PFA3DMathFct1DFractionCreate(ref A3DMathFct1DFractionData pData, out IntPtr ppMathFn);
        public static PFA3DMathFct1DFractionCreate A3DMathFct1DFractionCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct1DFractionCreate>(Library.A3DGetProcAddress("A3DMathFct1DFractionCreate", 1));
        public delegate A3DStatus PFA3DMathFct1DArctanCosGet(IntPtr pMathFn, ref A3DMathFct1DArctanCosData pData);
        public static PFA3DMathFct1DArctanCosGet A3DMathFct1DArctanCosGet = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct1DArctanCosGet>(Library.A3DGetProcAddress("A3DMathFct1DArctanCosGet", 1));
        public delegate A3DStatus PFA3DMathFct1DArctanCosCreate(ref A3DMathFct1DArctanCosData pData, out IntPtr ppMathFn);
        public static PFA3DMathFct1DArctanCosCreate A3DMathFct1DArctanCosCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct1DArctanCosCreate>(Library.A3DGetProcAddress("A3DMathFct1DArctanCosCreate", 1));
        public delegate A3DStatus PFA3DMathFct1DCombinationGet(IntPtr pMathFn, ref A3DMathFct1DCombinationData pData);
        public static PFA3DMathFct1DCombinationGet A3DMathFct1DCombinationGet = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct1DCombinationGet>(Library.A3DGetProcAddress("A3DMathFct1DCombinationGet", 1));
        public delegate A3DStatus PFA3DMathFct1DCombinationCreate(ref A3DMathFct1DCombinationData pData, out IntPtr ppMathFn);
        public static PFA3DMathFct1DCombinationCreate A3DMathFct1DCombinationCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct1DCombinationCreate>(Library.A3DGetProcAddress("A3DMathFct1DCombinationCreate", 1));
        public delegate A3DStatus PFA3DMathFct3DLinearGet(IntPtr pMathFn, ref A3DMathFct3DLinearData pData);
        public static PFA3DMathFct3DLinearGet A3DMathFct3DLinearGet = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct3DLinearGet>(Library.A3DGetProcAddress("A3DMathFct3DLinearGet", 1));
        public delegate A3DStatus PFA3DMathFct3DLinearCreate(ref A3DMathFct3DLinearData pData, out IntPtr ppMathFn);
        public static PFA3DMathFct3DLinearCreate A3DMathFct3DLinearCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct3DLinearCreate>(Library.A3DGetProcAddress("A3DMathFct3DLinearCreate", 1));
        public delegate A3DStatus PFA3DMathFct3DNonLinearGet(IntPtr pMathFn, ref A3DMathFct3DNonLinearData pData);
        public static PFA3DMathFct3DNonLinearGet A3DMathFct3DNonLinearGet = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct3DNonLinearGet>(Library.A3DGetProcAddress("A3DMathFct3DNonLinearGet", 1));
        public delegate A3DStatus PFA3DMathFct3DNonLinearCreate(ref A3DMathFct3DNonLinearData pData, out IntPtr ppMathFn);
        public static PFA3DMathFct3DNonLinearCreate A3DMathFct3DNonLinearCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct3DNonLinearCreate>(Library.A3DGetProcAddress("A3DMathFct3DNonLinearCreate", 1));
        public delegate A3DStatus PFA3DEntityGetType(IntPtr pEntity, ref A3DEEntityType peEntityType);
        public static PFA3DEntityGetType A3DEntityGetType = Marshal.GetDelegateForFunctionPointer<PFA3DEntityGetType>(Library.A3DGetProcAddress("A3DEntityGetType", 1));
        public delegate bool PFA3DEntityIsBaseWithGraphicsType(IntPtr pEntity);
        public static PFA3DEntityIsBaseWithGraphicsType A3DEntityIsBaseWithGraphicsType = Marshal.GetDelegateForFunctionPointer<PFA3DEntityIsBaseWithGraphicsType>(Library.A3DGetProcAddress("A3DEntityIsBaseWithGraphicsType", 1));
        public delegate bool PFA3DEntityIsBaseType(IntPtr pEntity);
        public static PFA3DEntityIsBaseType A3DEntityIsBaseType = Marshal.GetDelegateForFunctionPointer<PFA3DEntityIsBaseType>(Library.A3DGetProcAddress("A3DEntityIsBaseType", 1));
        public delegate A3DStatus PFA3DRootBaseGet(IntPtr pRootBase, ref A3DRootBaseData pData);
        public static PFA3DRootBaseGet A3DRootBaseGet = Marshal.GetDelegateForFunctionPointer<PFA3DRootBaseGet>(Library.A3DGetProcAddress("A3DRootBaseGet", 1));
        public delegate A3DStatus PFA3DRootBaseSet(IntPtr pRootBase, ref A3DRootBaseData pData);
        public static PFA3DRootBaseSet A3DRootBaseSet = Marshal.GetDelegateForFunctionPointer<PFA3DRootBaseSet>(Library.A3DGetProcAddress("A3DRootBaseSet", 1));
        public delegate A3DStatus PFA3DRootBaseAttributeRemoveAll(IntPtr pEntity);
        public static PFA3DRootBaseAttributeRemoveAll A3DRootBaseAttributeRemoveAll = Marshal.GetDelegateForFunctionPointer<PFA3DRootBaseAttributeRemoveAll>(Library.A3DGetProcAddress("A3DRootBaseAttributeRemoveAll", 1));
        public delegate A3DStatus PFA3DRootBaseAttributeRemove(IntPtr pEntity, [MarshalAs(UnmanagedType.LPStr)] string pcTitle);
        public static PFA3DRootBaseAttributeRemove A3DRootBaseAttributeRemove = Marshal.GetDelegateForFunctionPointer<PFA3DRootBaseAttributeRemove>(Library.A3DGetProcAddress("A3DRootBaseAttributeRemove", 1));
        public delegate A3DStatus PFA3DRootBaseAttributeRemoveAt(IntPtr pEntity, uint uIndex);
        public static PFA3DRootBaseAttributeRemoveAt A3DRootBaseAttributeRemoveAt = Marshal.GetDelegateForFunctionPointer<PFA3DRootBaseAttributeRemoveAt>(Library.A3DGetProcAddress("A3DRootBaseAttributeRemoveAt", 1));
        public delegate A3DStatus PFA3DRootBaseAttributeAppend(IntPtr pEntity, uint uiSize, out IntPtr m_ppAttributes);
        public static PFA3DRootBaseAttributeAppend A3DRootBaseAttributeAppend = Marshal.GetDelegateForFunctionPointer<PFA3DRootBaseAttributeAppend>(Library.A3DGetProcAddress("A3DRootBaseAttributeAppend", 1));
        public delegate A3DStatus PFA3DRootBaseAttributeAdd(IntPtr pEntity, [MarshalAs(UnmanagedType.LPStr)] string pcTitle, [MarshalAs(UnmanagedType.LPStr)] string pcValue);
        public static PFA3DRootBaseAttributeAdd A3DRootBaseAttributeAdd = Marshal.GetDelegateForFunctionPointer<PFA3DRootBaseAttributeAdd>(Library.A3DGetProcAddress("A3DRootBaseAttributeAdd", 1));
        public delegate A3DStatus PFA3DRootBaseWithGraphicsGet(IntPtr pRoot, ref A3DRootBaseWithGraphicsData pData);
        public static PFA3DRootBaseWithGraphicsGet A3DRootBaseWithGraphicsGet = Marshal.GetDelegateForFunctionPointer<PFA3DRootBaseWithGraphicsGet>(Library.A3DGetProcAddress("A3DRootBaseWithGraphicsGet", 1));
        public delegate A3DStatus PFA3DRootBaseWithGraphicsSet(IntPtr pRoot, ref A3DRootBaseWithGraphicsData pData);
        public static PFA3DRootBaseWithGraphicsSet A3DRootBaseWithGraphicsSet = Marshal.GetDelegateForFunctionPointer<PFA3DRootBaseWithGraphicsSet>(Library.A3DGetProcAddress("A3DRootBaseWithGraphicsSet", 1));
        public delegate A3DStatus PFA3DMiscAttributeGet(IntPtr pAttribute, ref A3DMiscAttributeData pData);
        public static PFA3DMiscAttributeGet A3DMiscAttributeGet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscAttributeGet>(Library.A3DGetProcAddress("A3DMiscAttributeGet", 1));
        public delegate A3DStatus PFA3DMiscAttributeCreate(ref A3DMiscAttributeData pData, out IntPtr ppAttribute);
        public static PFA3DMiscAttributeCreate A3DMiscAttributeCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMiscAttributeCreate>(Library.A3DGetProcAddress("A3DMiscAttributeCreate", 1));
        public delegate A3DStatus PFA3DGlobalGetUnit(uint uiIndexUnit, out IntPtr ppUnit);
        public static PFA3DGlobalGetUnit A3DGlobalGetUnit = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetUnit>(Library.A3DGetProcAddress("A3DGlobalGetUnit", 1));
        public delegate A3DStatus PFA3DGlobalGetUnitData(IntPtr pUnit, ref A3DMiscAttributeUnitData pData);
        public static PFA3DGlobalGetUnitData A3DGlobalGetUnitData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetUnitData>(Library.A3DGetProcAddress("A3DGlobalGetUnitData", 1));
        public delegate A3DStatus PFA3DCopyAndAdaptBrepModel(IntPtr p, ref A3DCopyAndAdaptBrepModelData psSetting, out IntPtr pp);
        public static PFA3DCopyAndAdaptBrepModel A3DCopyAndAdaptBrepModel = Marshal.GetDelegateForFunctionPointer<PFA3DCopyAndAdaptBrepModel>(Library.A3DGetProcAddress("A3DCopyAndAdaptBrepModel", 1));
        public delegate A3DStatus PFA3DCopyAndAdaptBrepModelAdvanced(IntPtr p, ref A3DCopyAndAdaptBrepModelData psSetting, out IntPtr pp, out uint puiNbErrors, IntPtr paiErrors);
        public static PFA3DCopyAndAdaptBrepModelAdvanced A3DCopyAndAdaptBrepModelAdvanced = Marshal.GetDelegateForFunctionPointer<PFA3DCopyAndAdaptBrepModelAdvanced>(Library.A3DGetProcAddress("A3DCopyAndAdaptBrepModelAdvanced", 1));
        public delegate A3DStatus PFA3DAdaptAndReplaceAllBrepInModelFile(IntPtr pModelFile, ref A3DCopyAndAdaptBrepModelData psSetting);
        public static PFA3DAdaptAndReplaceAllBrepInModelFile A3DAdaptAndReplaceAllBrepInModelFile = Marshal.GetDelegateForFunctionPointer<PFA3DAdaptAndReplaceAllBrepInModelFile>(Library.A3DGetProcAddress("A3DAdaptAndReplaceAllBrepInModelFile", 1));
        public delegate A3DStatus PFA3DAdaptAndReplaceAllBrepInModelFileAdvanced(IntPtr p, ref A3DCopyAndAdaptBrepModelData psSetting, out uint puiNbErrors, IntPtr pErrors);
        public static PFA3DAdaptAndReplaceAllBrepInModelFileAdvanced A3DAdaptAndReplaceAllBrepInModelFileAdvanced = Marshal.GetDelegateForFunctionPointer<PFA3DAdaptAndReplaceAllBrepInModelFileAdvanced>(Library.A3DGetProcAddress("A3DAdaptAndReplaceAllBrepInModelFileAdvanced", 1));
        public delegate A3DStatus PFA3DEntityDelete(IntPtr pEntity);
        public static PFA3DEntityDelete A3DEntityDelete = Marshal.GetDelegateForFunctionPointer<PFA3DEntityDelete>(Library.A3DGetProcAddress("A3DEntityDelete", 1));
        public delegate A3DStatus PFA3DEntityGetPDFNodeIdFromWrite(IntPtr pEntity, IntPtr pEntityFather, IntPtr pA3DRWParamsPrcWriteHelper, IntPtr pcUTF8Name);
        public static PFA3DEntityGetPDFNodeIdFromWrite A3DEntityGetPDFNodeIdFromWrite = Marshal.GetDelegateForFunctionPointer<PFA3DEntityGetPDFNodeIdFromWrite>(Library.A3DGetProcAddress("A3DEntityGetPDFNodeIdFromWrite", 1));
        public delegate A3DStatus PFA3DEntityGetPDFNodeIdFromRead(IntPtr pEntity, IntPtr pEntityFather, IntPtr pA3DRWParamsPrcReadHelper, IntPtr pcUTF8Name);
        public static PFA3DEntityGetPDFNodeIdFromRead A3DEntityGetPDFNodeIdFromRead = Marshal.GetDelegateForFunctionPointer<PFA3DEntityGetPDFNodeIdFromRead>(Library.A3DGetProcAddress("A3DEntityGetPDFNodeIdFromRead", 1));
        public delegate A3DStatus PFA3DTopoItemOwnersManagerGet(IntPtr pBrepOwner, out IntPtr ppTopoItemOwnersManager);
        public static PFA3DTopoItemOwnersManagerGet A3DTopoItemOwnersManagerGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoItemOwnersManagerGet>(Library.A3DGetProcAddress("A3DTopoItemOwnersManagerGet", 1));
        public delegate A3DStatus PFA3DTopoItemOwnersGet(IntPtr pTopoItemOwnersManager, IntPtr pTopoItem, IntPtr ppTopoItemOwner);
        public static PFA3DTopoItemOwnersGet A3DTopoItemOwnersGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoItemOwnersGet>(Library.A3DGetProcAddress("A3DTopoItemOwnersGet", 1));
        public delegate A3DStatus PFA3DComputePhysicalProperties(IntPtr p, ref A3DVector3dData psScale, ref A3DPhysicalPropertiesData psPhysicalPropertiesData);
        public static PFA3DComputePhysicalProperties A3DComputePhysicalProperties = Marshal.GetDelegateForFunctionPointer<PFA3DComputePhysicalProperties>(Library.A3DGetProcAddress("A3DComputePhysicalProperties", 1));
        public delegate A3DStatus PFA3DComputeFaceArea(IntPtr pFace, IntPtr pBrepDataTopoContext, out double pArea);
        public static PFA3DComputeFaceArea A3DComputeFaceArea = Marshal.GetDelegateForFunctionPointer<PFA3DComputeFaceArea>(Library.A3DGetProcAddress("A3DComputeFaceArea", 1));
        public delegate A3DStatus PFA3DComputePolyBrepPhysicalProperties(IntPtr p, ref A3DVector3dData psScale, ref A3DPhysicalPropertiesData psPhysicalPropertiesData);
        public static PFA3DComputePolyBrepPhysicalProperties A3DComputePolyBrepPhysicalProperties = Marshal.GetDelegateForFunctionPointer<PFA3DComputePolyBrepPhysicalProperties>(Library.A3DGetProcAddress("A3DComputePolyBrepPhysicalProperties", 1));
        public delegate A3DStatus PFA3DComputeModelFilePhysicalProperties(IntPtr p, ref A3DPhysicalPropertiesData psPhysicalProperties);
        public static PFA3DComputeModelFilePhysicalProperties A3DComputeModelFilePhysicalProperties = Marshal.GetDelegateForFunctionPointer<PFA3DComputeModelFilePhysicalProperties>(Library.A3DGetProcAddress("A3DComputeModelFilePhysicalProperties", 1));
        public delegate A3DStatus PFA3DSimplifyModelFileCurveAndSurfaceAsAnalytic(IntPtr p, double dTol);
        public static PFA3DSimplifyModelFileCurveAndSurfaceAsAnalytic A3DSimplifyModelFileCurveAndSurfaceAsAnalytic = Marshal.GetDelegateForFunctionPointer<PFA3DSimplifyModelFileCurveAndSurfaceAsAnalytic>(Library.A3DGetProcAddress("A3DSimplifyModelFileCurveAndSurfaceAsAnalytic", 1));
        public delegate A3DStatus PFA3DSimplifyModelFileWithAnalytics(IntPtr p, double dTol, uint uNbRecognizedType, IntPtr pOptRecognizedType);
        public static PFA3DSimplifyModelFileWithAnalytics A3DSimplifyModelFileWithAnalytics = Marshal.GetDelegateForFunctionPointer<PFA3DSimplifyModelFileWithAnalytics>(Library.A3DGetProcAddress("A3DSimplifyModelFileWithAnalytics", 1));
        public delegate A3DStatus PFA3DTopoBodyGet(IntPtr pBody, ref A3DTopoBodyData pData);
        public static PFA3DTopoBodyGet A3DTopoBodyGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoBodyGet>(Library.A3DGetProcAddress("A3DTopoBodyGet", 1));
        public delegate A3DStatus PFA3DTopoBodySet(IntPtr pBody, ref A3DTopoBodyData pData);
        public static PFA3DTopoBodySet A3DTopoBodySet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoBodySet>(Library.A3DGetProcAddress("A3DTopoBodySet", 1));
        public delegate A3DStatus PFA3DTopoContextGet(IntPtr pContext, ref A3DTopoContextData pData);
        public static PFA3DTopoContextGet A3DTopoContextGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoContextGet>(Library.A3DGetProcAddress("A3DTopoContextGet", 1));
        public delegate A3DStatus PFA3DTopoContextCreate(ref A3DTopoContextData pData, out IntPtr ppContext);
        public static PFA3DTopoContextCreate A3DTopoContextCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoContextCreate>(Library.A3DGetProcAddress("A3DTopoContextCreate", 1));
        public delegate A3DStatus PFA3DTopoSingleWireBodyGet(IntPtr pSingleWireBody, ref A3DTopoSingleWireBodyData pData);
        public static PFA3DTopoSingleWireBodyGet A3DTopoSingleWireBodyGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoSingleWireBodyGet>(Library.A3DGetProcAddress("A3DTopoSingleWireBodyGet", 1));
        public delegate A3DStatus PFA3DTopoSingleWireBodyCreate(ref A3DTopoSingleWireBodyData pData, out IntPtr ppSingleWireBody);
        public static PFA3DTopoSingleWireBodyCreate A3DTopoSingleWireBodyCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoSingleWireBodyCreate>(Library.A3DGetProcAddress("A3DTopoSingleWireBodyCreate", 1));
        public delegate A3DStatus PFA3DTopoBrepDataGet(IntPtr pBrep, ref A3DTopoBrepDataData pData);
        public static PFA3DTopoBrepDataGet A3DTopoBrepDataGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoBrepDataGet>(Library.A3DGetProcAddress("A3DTopoBrepDataGet", 1));
        public delegate A3DStatus PFA3DTopoBrepDataCreate(ref A3DTopoBrepDataData pData, out IntPtr ppBrep);
        public static PFA3DTopoBrepDataCreate A3DTopoBrepDataCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoBrepDataCreate>(Library.A3DGetProcAddress("A3DTopoBrepDataCreate", 1));
        public delegate A3DStatus PFA3DTopoBrepDataGetFaces(IntPtr psBrepData, out uint psNbFaces, IntPtr papsFaces);
        public static PFA3DTopoBrepDataGetFaces A3DTopoBrepDataGetFaces = Marshal.GetDelegateForFunctionPointer<PFA3DTopoBrepDataGetFaces>(Library.A3DGetProcAddress("A3DTopoBrepDataGetFaces", 1));
        public delegate A3DStatus PFA3DTopoBrepDataGetEdges(IntPtr psBrepData, out uint piNbEdges, IntPtr papsEdges);
        public static PFA3DTopoBrepDataGetEdges A3DTopoBrepDataGetEdges = Marshal.GetDelegateForFunctionPointer<PFA3DTopoBrepDataGetEdges>(Library.A3DGetProcAddress("A3DTopoBrepDataGetEdges", 1));
        public delegate A3DStatus PFA3DTopoConnexGet(IntPtr pConnex, ref A3DTopoConnexData pData);
        public static PFA3DTopoConnexGet A3DTopoConnexGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoConnexGet>(Library.A3DGetProcAddress("A3DTopoConnexGet", 1));
        public delegate A3DStatus PFA3DTopoConnexCreate(ref A3DTopoConnexData pData, out IntPtr ppConnex);
        public static PFA3DTopoConnexCreate A3DTopoConnexCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoConnexCreate>(Library.A3DGetProcAddress("A3DTopoConnexCreate", 1));
        public delegate A3DStatus PFA3DTopoShellGet(IntPtr pShell, ref A3DTopoShellData pData);
        public static PFA3DTopoShellGet A3DTopoShellGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoShellGet>(Library.A3DGetProcAddress("A3DTopoShellGet", 1));
        public delegate A3DStatus PFA3DTopoShellCreate(ref A3DTopoShellData pData, out IntPtr ppShell);
        public static PFA3DTopoShellCreate A3DTopoShellCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoShellCreate>(Library.A3DGetProcAddress("A3DTopoShellCreate", 1));
        public delegate A3DStatus PFA3DTopoFaceGet(IntPtr pFace, ref A3DTopoFaceData pData);
        public static PFA3DTopoFaceGet A3DTopoFaceGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoFaceGet>(Library.A3DGetProcAddress("A3DTopoFaceGet", 1));
        public delegate A3DStatus PFA3DTopoFaceCreate(ref A3DTopoFaceData pData, out IntPtr ppFace);
        public static PFA3DTopoFaceCreate A3DTopoFaceCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoFaceCreate>(Library.A3DGetProcAddress("A3DTopoFaceCreate", 1));
        public delegate A3DStatus PFA3DTopoFaceGetShellAndOrientation(IntPtr psBrepData, IntPtr psFace, out IntPtr ppsShell, out byte pusOrientation);
        public static PFA3DTopoFaceGetShellAndOrientation A3DTopoFaceGetShellAndOrientation = Marshal.GetDelegateForFunctionPointer<PFA3DTopoFaceGetShellAndOrientation>(Library.A3DGetProcAddress("A3DTopoFaceGetShellAndOrientation", 1));
        public delegate A3DStatus PFA3DTopoFaceGetShell(IntPtr psBrepData, IntPtr psFace, out IntPtr ppsShell);
        public static PFA3DTopoFaceGetShell A3DTopoFaceGetShell = Marshal.GetDelegateForFunctionPointer<PFA3DTopoFaceGetShell>(Library.A3DGetProcAddress("A3DTopoFaceGetShell", 1));
        public delegate A3DStatus PFA3DTopoLoopGet(IntPtr pLoop, ref A3DTopoLoopData pData);
        public static PFA3DTopoLoopGet A3DTopoLoopGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoLoopGet>(Library.A3DGetProcAddress("A3DTopoLoopGet", 1));
        public delegate A3DStatus PFA3DTopoLoopCreate(ref A3DTopoLoopData pData, out IntPtr ppLoop);
        public static PFA3DTopoLoopCreate A3DTopoLoopCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoLoopCreate>(Library.A3DGetProcAddress("A3DTopoLoopCreate", 1));
        public delegate A3DStatus PFA3DTopoLoopGetFace(IntPtr psBrepData, IntPtr psLoop, out IntPtr ppsFace);
        public static PFA3DTopoLoopGetFace A3DTopoLoopGetFace = Marshal.GetDelegateForFunctionPointer<PFA3DTopoLoopGetFace>(Library.A3DGetProcAddress("A3DTopoLoopGetFace", 1));
        public delegate A3DStatus PFA3DTopoCoEdgeGet(IntPtr pCoEdge, ref A3DTopoCoEdgeData pData);
        public static PFA3DTopoCoEdgeGet A3DTopoCoEdgeGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoCoEdgeGet>(Library.A3DGetProcAddress("A3DTopoCoEdgeGet", 1));
        public delegate A3DStatus PFA3DTopoCoEdgeCreate(ref A3DTopoCoEdgeData pData, out IntPtr ppCoEdge);
        public static PFA3DTopoCoEdgeCreate A3DTopoCoEdgeCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoCoEdgeCreate>(Library.A3DGetProcAddress("A3DTopoCoEdgeCreate", 1));
        public delegate A3DStatus PFA3DTopoCoEdgeSetNeighbour(IntPtr pCoEdge, IntPtr pNeighbour);
        public static PFA3DTopoCoEdgeSetNeighbour A3DTopoCoEdgeSetNeighbour = Marshal.GetDelegateForFunctionPointer<PFA3DTopoCoEdgeSetNeighbour>(Library.A3DGetProcAddress("A3DTopoCoEdgeSetNeighbour", 1));
        public delegate A3DStatus PFA3DTopoCoedgeGetLoop(IntPtr psCoEdge, out IntPtr ppsLoop);
        public static PFA3DTopoCoedgeGetLoop A3DTopoCoedgeGetLoop = Marshal.GetDelegateForFunctionPointer<PFA3DTopoCoedgeGetLoop>(Library.A3DGetProcAddress("A3DTopoCoedgeGetLoop", 1));
        public delegate A3DStatus PFA3DTopoEdgeGet(IntPtr pEdge, ref A3DTopoEdgeData pData);
        public static PFA3DTopoEdgeGet A3DTopoEdgeGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoEdgeGet>(Library.A3DGetProcAddress("A3DTopoEdgeGet", 1));
        public delegate A3DStatus PFA3DTopoEdgeCreate(ref A3DTopoEdgeData pData, out IntPtr ppEdge);
        public static PFA3DTopoEdgeCreate A3DTopoEdgeCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoEdgeCreate>(Library.A3DGetProcAddress("A3DTopoEdgeCreate", 1));
        public delegate A3DStatus PFA3DTopoEdgeGetCoEdges(IntPtr psBrepData, IntPtr psEdge, out uint piNbCoedges, IntPtr papsCoEdges);
        public static PFA3DTopoEdgeGetCoEdges A3DTopoEdgeGetCoEdges = Marshal.GetDelegateForFunctionPointer<PFA3DTopoEdgeGetCoEdges>(Library.A3DGetProcAddress("A3DTopoEdgeGetCoEdges", 1));
        public delegate A3DStatus PFA3DTopoEdgeGetSurfaces(IntPtr psBrepData, IntPtr psEdge, out uint piNbSurfaces, IntPtr papsSurfaces);
        public static PFA3DTopoEdgeGetSurfaces A3DTopoEdgeGetSurfaces = Marshal.GetDelegateForFunctionPointer<PFA3DTopoEdgeGetSurfaces>(Library.A3DGetProcAddress("A3DTopoEdgeGetSurfaces", 1));
        public delegate A3DStatus PFA3DTopoEdgeGetOrCompute3DCurve(IntPtr psBrepData, IntPtr psEdge, out IntPtr pps3DCurve);
        public static PFA3DTopoEdgeGetOrCompute3DCurve A3DTopoEdgeGetOrCompute3DCurve = Marshal.GetDelegateForFunctionPointer<PFA3DTopoEdgeGetOrCompute3DCurve>(Library.A3DGetProcAddress("A3DTopoEdgeGetOrCompute3DCurve", 1));
        public delegate A3DStatus PFA3DTopoWireEdgeGet(IntPtr pWireEdge, ref A3DTopoWireEdgeData pData);
        public static PFA3DTopoWireEdgeGet A3DTopoWireEdgeGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoWireEdgeGet>(Library.A3DGetProcAddress("A3DTopoWireEdgeGet", 1));
        public delegate A3DStatus PFA3DTopoWireEdgeCreate(ref A3DTopoWireEdgeData pData, out IntPtr ppWireEdge);
        public static PFA3DTopoWireEdgeCreate A3DTopoWireEdgeCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoWireEdgeCreate>(Library.A3DGetProcAddress("A3DTopoWireEdgeCreate", 1));
        public delegate A3DStatus PFA3DTopoUniqueVertexGet(IntPtr pUniqueVertex, ref A3DTopoUniqueVertexData pData);
        public static PFA3DTopoUniqueVertexGet A3DTopoUniqueVertexGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoUniqueVertexGet>(Library.A3DGetProcAddress("A3DTopoUniqueVertexGet", 1));
        public delegate A3DStatus PFA3DTopoUniqueVertexCreate(ref A3DTopoUniqueVertexData pData, out IntPtr ppUniqueVertex);
        public static PFA3DTopoUniqueVertexCreate A3DTopoUniqueVertexCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoUniqueVertexCreate>(Library.A3DGetProcAddress("A3DTopoUniqueVertexCreate", 1));
        public delegate A3DStatus PFA3DTopoMultipleVertexGet(IntPtr pMultipleVertex, ref A3DTopoMultipleVertexData pData);
        public static PFA3DTopoMultipleVertexGet A3DTopoMultipleVertexGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoMultipleVertexGet>(Library.A3DGetProcAddress("A3DTopoMultipleVertexGet", 1));
        public delegate A3DStatus PFA3DTopoMultipleVertexCreate(ref A3DTopoMultipleVertexData pData, out IntPtr ppMultipleVertex);
        public static PFA3DTopoMultipleVertexCreate A3DTopoMultipleVertexCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoMultipleVertexCreate>(Library.A3DGetProcAddress("A3DTopoMultipleVertexCreate", 1));
    }
}
