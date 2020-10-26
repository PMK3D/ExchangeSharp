using System;

namespace TS3D.Exchange.Direct
{
    public class Test
    {
        public static bool PerformStructSizeTests()
        {
            try {
                {
                    A3DVector2dData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DVector2dData" );
                    }
                }
                {
                    A3DVector3dData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DVector3dData" );
                    }
                }
                {
                    A3DIntervalData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DIntervalData" );
                    }
                }
                {
                    A3DDomainData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DDomainData" );
                    }
                }
                {
                    A3DBoundingBoxData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DBoundingBoxData" );
                    }
                }
                {
                    A3DParameterizationData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DParameterizationData" );
                    }
                }
                {
                    A3DUVParameterizationData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DUVParameterizationData" );
                    }
                }
                {
                    A3DTessBaseData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DTessBaseData" );
                    }
                }
                {
                    A3DTessFaceData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DTessFaceData" );
                    }
                }
                {
                    A3DTess3DData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DTess3DData" );
                    }
                }
                {
                    A3DTess3DWireData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DTess3DWireData" );
                    }
                }
                {
                    A3DTessMarkupData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DTessMarkupData" );
                    }
                }
                {
                    A3DGraphicsData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DGraphicsData" );
                    }
                }
                {
                    A3DGraphStyleData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DGraphStyleData" );
                    }
                }
                {
                    A3DGraphRgbColorData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DGraphRgbColorData" );
                    }
                }
                {
                    A3DGraphLinePatternData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DGraphLinePatternData" );
                    }
                }
                {
                    A3DGraphMaterialData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DGraphMaterialData" );
                    }
                }
                {
                    A3DGraphPictureData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DGraphPictureData" );
                    }
                }
                {
                    A3DGraphDottingPatternData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DGraphDottingPatternData" );
                    }
                }
                {
                    A3DGraphHatchingPatternLineData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DGraphHatchingPatternLineData" );
                    }
                }
                {
                    A3DGraphHatchingPatternData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DGraphHatchingPatternData" );
                    }
                }
                {
                    A3DGraphSolidPatternData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DGraphSolidPatternData" );
                    }
                }
                {
                    A3DGraphVPicturePatternData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DGraphVPicturePatternData" );
                    }
                }
                {
                    A3DGraphCameraData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DGraphCameraData" );
                    }
                }
                {
                    A3DGraphAmbientLightData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DGraphAmbientLightData" );
                    }
                }
                {
                    A3DGraphPointLightData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DGraphPointLightData" );
                    }
                }
                {
                    A3DGraphSpotLightData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DGraphSpotLightData" );
                    }
                }
                {
                    A3DGraphDirectionalLightData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DGraphDirectionalLightData" );
                    }
                }
                {
                    A3DGraphSceneDisplayParametersData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DGraphSceneDisplayParametersData" );
                    }
                }
                {
                    A3DMiscCascadedAttributesData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMiscCascadedAttributesData" );
                    }
                }
                {
                    A3DMiscGeneralTransformationData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMiscGeneralTransformationData" );
                    }
                }
                {
                    A3DMiscCartesianTransformationData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMiscCartesianTransformationData" );
                    }
                }
                {
                    A3DMiscEntityReferenceData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMiscEntityReferenceData" );
                    }
                }
                {
                    A3DMiscReferenceOnTopologyData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMiscReferenceOnTopologyData" );
                    }
                }
                {
                    A3DMiscReferenceOnTessData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMiscReferenceOnTessData" );
                    }
                }
                {
                    A3DMiscReferenceOnCsysItemData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMiscReferenceOnCsysItemData" );
                    }
                }
                {
                    A3DMiscPhysicMaterialData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMiscPhysicMaterialData" );
                    }
                }
                {
                    A3DMiscMaterialFiberData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMiscMaterialFiberData" );
                    }
                }
                {
                    A3DMiscMaterialHoneyCombData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMiscMaterialHoneyCombData" );
                    }
                }
                {
                    A3DMiscMaterialIsotropicData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMiscMaterialIsotropicData" );
                    }
                }
                {
                    A3DMiscMaterialOrthotropic2DData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMiscMaterialOrthotropic2DData" );
                    }
                }
                {
                    A3DMiscMaterialOrthotropic3DData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMiscMaterialOrthotropic3DData" );
                    }
                }
                {
                    A3DMiscMaterialAnisotropicData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMiscMaterialAnisotropicData" );
                    }
                }
                {
                    A3DMiscMaterialPropertiesData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMiscMaterialPropertiesData" );
                    }
                }
                {
                    A3DAsmModelFileData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DAsmModelFileData" );
                    }
                }
                {
                    A3DAsmProductOccurrenceData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DAsmProductOccurrenceData" );
                    }
                }
                {
                    A3DAsmProductOccurrenceDataSLW d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DAsmProductOccurrenceDataSLW" );
                    }
                }
                {
                    A3DAsmProductOccurrenceDataCat d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DAsmProductOccurrenceDataCat" );
                    }
                }
                {
                    A3DAsmProductOccurrenceDataCV5 d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DAsmProductOccurrenceDataCV5" );
                    }
                }
                {
                    A3DAsmProductOccurrenceDataUg d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DAsmProductOccurrenceDataUg" );
                    }
                }
                {
                    A3DAsmProductOccurrenceDataProe d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DAsmProductOccurrenceDataProe" );
                    }
                }
                {
                    A3DAsmProductOccurrenceDataInv d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DAsmProductOccurrenceDataInv" );
                    }
                }
                {
                    A3DAsmProductOccurrenceDataJT d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DAsmProductOccurrenceDataJT" );
                    }
                }
                {
                    A3DAsmPartDefinitionData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DAsmPartDefinitionData" );
                    }
                }
                {
                    A3DAsmLayerFilterItemData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DAsmLayerFilterItemData" );
                    }
                }
                {
                    A3DAsmEntityFilterItemData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DAsmEntityFilterItemData" );
                    }
                }
                {
                    A3DAsmFilterData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DAsmFilterData" );
                    }
                }
                {
                    A3DRWParamsGeneralData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsGeneralData" );
                    }
                }
                {
                    A3DRWParamsPmiData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsPmiData" );
                    }
                }
                {
                    A3DRWParamsTessellationData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsTessellationData" );
                    }
                }
                {
                    A3DRWParamsSearchDirData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsSearchDirData" );
                    }
                }
                {
                    A3DRWParamsAssemblyData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsAssemblyData" );
                    }
                }
                {
                    A3DRWParamsMultiEntriesData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsMultiEntriesData" );
                    }
                }
                {
                    A3DRWParamsCatiaV4Data d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsCatiaV4Data" );
                    }
                }
                {
                    A3DRWParamsCatiaV5Data d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsCatiaV5Data" );
                    }
                }
                {
                    A3DRWParamsUnigraphicsData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsUnigraphicsData" );
                    }
                }
                {
                    A3DRWParamsProEData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsProEData" );
                    }
                }
                {
                    A3DRWValidationPropertiesThresholdData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWValidationPropertiesThresholdData" );
                    }
                }
                {
                    A3DRWParamsStepData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsStepData" );
                    }
                }
                {
                    A3DRWParamsIGESData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsIGESData" );
                    }
                }
                {
                    A3DRWParamsIFCData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsIFCData" );
                    }
                }
                {
                    A3DRWParamsJTData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsJTData" );
                    }
                }
                {
                    A3DRWParamsParasolidData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsParasolidData" );
                    }
                }
                {
                    A3DRWParamsSolidworksData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsSolidworksData" );
                    }
                }
                {
                    A3DRWParamsInventorData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsInventorData" );
                    }
                }
                {
                    A3DRWParamsRhinoData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsRhinoData" );
                    }
                }
                {
                    A3DRWParamsRevitData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsRevitData" );
                    }
                }
                {
                    A3DRWParamsSpecificLoadData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsSpecificLoadData" );
                    }
                }
                {
                    A3DRWParamsIncrementalLoadData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsIncrementalLoadData" );
                    }
                }
                {
                    A3DRWParamsLoadData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsLoadData" );
                    }
                }
                {
                    A3DStream3DPDFData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DStream3DPDFData" );
                    }
                }
                {
                    A3DRWParamsExportPrcData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsExportPrcData" );
                    }
                }
                {
                    A3DRWParamsExportU3DData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsExportU3DData" );
                    }
                }
                {
                    A3DRWParamsExportStepData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsExportStepData" );
                    }
                }
                {
                    A3DRWParamsExportJTData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsExportJTData" );
                    }
                }
                {
                    A3DRWParamsExportIgesData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsExportIgesData" );
                    }
                }
                {
                    A3DRWParamsExportStlData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsExportStlData" );
                    }
                }
                {
                    A3DRWParamsExport3mfData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsExport3mfData" );
                    }
                }
                {
                    A3DRWParamsExportXMLData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsExportXMLData" );
                    }
                }
                {
                    A3DRWParamsExportObjData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsExportObjData" );
                    }
                }
                {
                    A3DRWParamsExportFbxData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsExportFbxData" );
                    }
                }
                {
                    A3DSewOptionsData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DSewOptionsData" );
                    }
                }
                {
                    A3DFaceUVPointInsideManagerData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DFaceUVPointInsideManagerData" );
                    }
                }
                {
                    A3DProjectedPointCloudData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DProjectedPointCloudData" );
                    }
                }
                {
                    A3DProjectPointCloudManagerDataFromRI d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DProjectPointCloudManagerDataFromRI" );
                    }
                }
                {
                    A3DPlanarSectionData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DPlanarSectionData" );
                    }
                }
                {
                    A3DCompareInputData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCompareInputData" );
                    }
                }
                {
                    A3DCompareOutputData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCompareOutputData" );
                    }
                }
                {
                    A3DMultiPlanarSectionData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMultiPlanarSectionData" );
                    }
                }
                {
                    A3DHLRViewPlaneData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DHLRViewPlaneData" );
                    }
                }
                {
                    A3DHLRCurveData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DHLRCurveData" );
                    }
                }
                {
                    A3DHLRSectionFaceData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DHLRSectionFaceData" );
                    }
                }
                {
                    A3DHLRRepresentationItemData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DHLRRepresentationItemData" );
                    }
                }
                {
                    A3DHLROptionsData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DHLROptionsData" );
                    }
                }
                {
                    A3DTransfoRepresentationItemData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DTransfoRepresentationItemData" );
                    }
                }
                {
                    A3DCollisionGroupData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCollisionGroupData" );
                    }
                }
                {
                    A3DCollisionParameterData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCollisionParameterData" );
                    }
                }
                {
                    A3DCollisionResultData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCollisionResultData" );
                    }
                }
                {
                    A3DMkpLeaderData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMkpLeaderData" );
                    }
                }
                {
                    A3DMkpAnnotationItemData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMkpAnnotationItemData" );
                    }
                }
                {
                    A3DMkpAnnotationSetData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMkpAnnotationSetData" );
                    }
                }
                {
                    A3DMkpAnnotationReferenceData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMkpAnnotationReferenceData" );
                    }
                }
                {
                    A3DMkpViewData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMkpViewData" );
                    }
                }
                {
                    A3DMkpViewFlagsData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMkpViewFlagsData" );
                    }
                }
                {
                    A3DMiscMarkupLinkedItemData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMiscMarkupLinkedItemData" );
                    }
                }
                {
                    A3DMkpMarkupData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMkpMarkupData" );
                    }
                }
                {
                    A3DMkpRTFFieldData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMkpRTFFieldData" );
                    }
                }
                {
                    A3DFontKeyData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DFontKeyData" );
                    }
                }
                {
                    A3DFontData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DFontData" );
                    }
                }
                {
                    A3DGraphTextureTransformationData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DGraphTextureTransformationData" );
                    }
                }
                {
                    A3DGraphTextureDefinitionData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DGraphTextureDefinitionData" );
                    }
                }
                {
                    A3DGraphTextureApplicationData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DGraphTextureApplicationData" );
                    }
                }
                {
                    A3DDrawCallbacksData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DDrawCallbacksData" );
                    }
                }
                {
                    A3DDrawingModelData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DDrawingModelData" );
                    }
                }
                {
                    A3DDrawingSheetFormatData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DDrawingSheetFormatData" );
                    }
                }
                {
                    A3DDrawingSheetData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DDrawingSheetData" );
                    }
                }
                {
                    A3DDrawingClipFrameData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DDrawingClipFrameData" );
                    }
                }
                {
                    A3DDrawingViewData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DDrawingViewData" );
                    }
                }
                {
                    A3DDrawingBlockBasicData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DDrawingBlockBasicData" );
                    }
                }
                {
                    A3DDrawingBlockOperatorData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DDrawingBlockOperatorData" );
                    }
                }
                {
                    A3DDrawingCurveData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DDrawingCurveData" );
                    }
                }
                {
                    A3DDrawingFilledAreaData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DDrawingFilledAreaData" );
                    }
                }
                {
                    A3DDrawingPictureData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DDrawingPictureData" );
                    }
                }
                {
                    A3DDrawingVerticesData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DDrawingVerticesData" );
                    }
                }
                {
                    A3DThumbnailData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DThumbnailData" );
                    }
                }
                {
                    A3DFileInformationData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DFileInformationData" );
                    }
                }
                {
                    A3DFileContextData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DFileContextData" );
                    }
                }
                {
                    A3DRWParamsExportParasolidData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsExportParasolidData" );
                    }
                }
                {
                    A3DRWParamsTranslateToPkPartsData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsTranslateToPkPartsData" );
                    }
                }
                {
                    A3DRWParamsExportAcisData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRWParamsExportAcisData" );
                    }
                }
                {
                    A3DRiRepresentationItemData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRiRepresentationItemData" );
                    }
                }
                {
                    A3DRiSetData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRiSetData" );
                    }
                }
                {
                    A3DRiPointSetData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRiPointSetData" );
                    }
                }
                {
                    A3DRiDirectionData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRiDirectionData" );
                    }
                }
                {
                    A3DRiCoordinateSystemData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRiCoordinateSystemData" );
                    }
                }
                {
                    A3DRiCurveData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRiCurveData" );
                    }
                }
                {
                    A3DRiPlaneData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRiPlaneData" );
                    }
                }
                {
                    A3DRiBrepModelData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRiBrepModelData" );
                    }
                }
                {
                    A3DRiPolyBrepModelData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRiPolyBrepModelData" );
                    }
                }
                {
                    A3DRiPolyWireData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRiPolyWireData" );
                    }
                }
                {
                    A3DFRMFeatureTreeData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DFRMFeatureTreeData" );
                    }
                }
                {
                    A3DFRMParameterData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DFRMParameterData" );
                    }
                }
                {
                    A3DFRMFeatureTypeData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DFRMFeatureTypeData" );
                    }
                }
                {
                    A3DFRMStringData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DFRMStringData" );
                    }
                }
                {
                    A3DFRMDoubleData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DFRMDoubleData" );
                    }
                }
                {
                    A3DFRMIntegerData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DFRMIntegerData" );
                    }
                }
                {
                    A3DFRMFeatureLinkedItemData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DFRMFeatureLinkedItemData" );
                    }
                }
                {
                    A3DFRMFeatureData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DFRMFeatureData" );
                    }
                }
                {
                    A3DFRMFeatureGeomEntitiesData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DFRMFeatureGeomEntitiesData" );
                    }
                }
                {
                    A3DCrvNurbsData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCrvNurbsData" );
                    }
                }
                {
                    A3DCrvLineData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCrvLineData" );
                    }
                }
                {
                    A3DCrvCircleData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCrvCircleData" );
                    }
                }
                {
                    A3DCrvEllipseData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCrvEllipseData" );
                    }
                }
                {
                    A3DCrvParabolaData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCrvParabolaData" );
                    }
                }
                {
                    A3DCrvHyperbolaData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCrvHyperbolaData" );
                    }
                }
                {
                    A3DCrvPolyLineData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCrvPolyLineData" );
                    }
                }
                {
                    A3DCrvCompositeData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCrvCompositeData" );
                    }
                }
                {
                    A3DCrvEquationData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCrvEquationData" );
                    }
                }
                {
                    A3DCrvTransformData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCrvTransformData" );
                    }
                }
                {
                    A3DCrvOnSurfData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCrvOnSurfData" );
                    }
                }
                {
                    A3DCrvOffsetData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCrvOffsetData" );
                    }
                }
                {
                    A3DCrvHelixPitchCstData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCrvHelixPitchCstData" );
                    }
                }
                {
                    A3DCrvHelixPitchVarData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCrvHelixPitchVarData" );
                    }
                }
                {
                    A3DCrvHelixData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCrvHelixData" );
                    }
                }
                {
                    A3DCrossingPointsCrvIntersectionData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCrossingPointsCrvIntersectionData" );
                    }
                }
                {
                    A3DCrvIntersectionData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCrvIntersectionData" );
                    }
                }
                {
                    A3DCrvBlend02BoundaryData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCrvBlend02BoundaryData" );
                    }
                }
                {
                    A3DSurfNurbsData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DSurfNurbsData" );
                    }
                }
                {
                    A3DSurfSphereData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DSurfSphereData" );
                    }
                }
                {
                    A3DSurfCylinderData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DSurfCylinderData" );
                    }
                }
                {
                    A3DSurfTorusData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DSurfTorusData" );
                    }
                }
                {
                    A3DSurfRevolutionData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DSurfRevolutionData" );
                    }
                }
                {
                    A3DSurfExtrusionData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DSurfExtrusionData" );
                    }
                }
                {
                    A3DSurfOffsetData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DSurfOffsetData" );
                    }
                }
                {
                    A3DSurfPlaneData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DSurfPlaneData" );
                    }
                }
                {
                    A3DSurfBlend01Data d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DSurfBlend01Data" );
                    }
                }
                {
                    A3DSurfBlend02Data d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DSurfBlend02Data" );
                    }
                }
                {
                    A3DSurfBlend03Data d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DSurfBlend03Data" );
                    }
                }
                {
                    A3DSurfConeData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DSurfConeData" );
                    }
                }
                {
                    A3DSurfCylindricalData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DSurfCylindricalData" );
                    }
                }
                {
                    A3DSurfRuledData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DSurfRuledData" );
                    }
                }
                {
                    A3DSurfPipeData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DSurfPipeData" );
                    }
                }
                {
                    A3DSurfTransformData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DSurfTransformData" );
                    }
                }
                {
                    A3DSurfFromCurvesData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DSurfFromCurvesData" );
                    }
                }
                {
                    A3DGlobalData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DGlobalData" );
                    }
                }
                {
                    A3DMDPosition3DData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDPosition3DData" );
                    }
                }
                {
                    A3DMDPosition2DData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDPosition2DData" );
                    }
                }
                {
                    A3DMDPositionReferenceData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDPositionReferenceData" );
                    }
                }
                {
                    A3DMDLeaderSymbolData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDLeaderSymbolData" );
                    }
                }
                {
                    A3DMDMarkupLeaderStubData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDMarkupLeaderStubData" );
                    }
                }
                {
                    A3DMDLeaderDefinitionData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDLeaderDefinitionData" );
                    }
                }
                {
                    A3DMDTextPropertiesData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDTextPropertiesData" );
                    }
                }
                {
                    A3DMarkupDefinitionData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMarkupDefinitionData" );
                    }
                }
                {
                    A3DMDDimensionValueFormatData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDDimensionValueFormatData" );
                    }
                }
                {
                    A3DMDDimensionSimpleToleranceFormatData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDDimensionSimpleToleranceFormatData" );
                    }
                }
                {
                    A3DMDDimensionCombinedToleranceFormatData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDDimensionCombinedToleranceFormatData" );
                    }
                }
                {
                    A3DMDDimensionValueData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDDimensionValueData" );
                    }
                }
                {
                    A3DMDDimensionSecondPartData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDDimensionSecondPartData" );
                    }
                }
                {
                    A3DMDDimensionForeshortenedData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDDimensionForeshortenedData" );
                    }
                }
                {
                    A3DMDDimensionLineSymbolData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDDimensionLineSymbolData" );
                    }
                }
                {
                    A3DMDDimensionLineData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDDimensionLineData" );
                    }
                }
                {
                    A3DMDDimensionFunnelData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDDimensionFunnelData" );
                    }
                }
                {
                    A3DMDDimensionExtremityData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDDimensionExtremityData" );
                    }
                }
                {
                    A3DMDDimensionExtentionLineData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDDimensionExtentionLineData" );
                    }
                }
                {
                    A3DMarkupDimensionData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMarkupDimensionData" );
                    }
                }
                {
                    A3DMarkupRoughnessData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMarkupRoughnessData" );
                    }
                }
                {
                    A3DMarkupBalloonData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMarkupBalloonData" );
                    }
                }
                {
                    A3DMarkupFastenerData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMarkupFastenerData" );
                    }
                }
                {
                    A3DMarkupLocatorData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMarkupLocatorData" );
                    }
                }
                {
                    A3DMarkupMeasurementPointData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMarkupMeasurementPointData" );
                    }
                }
                {
                    A3DMDTextPositionData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDTextPositionData" );
                    }
                }
                {
                    A3DMarkupTextData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMarkupTextData" );
                    }
                }
                {
                    A3DMarkupCoordinateData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMarkupCoordinateData" );
                    }
                }
                {
                    A3DMarkupRichTextData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMarkupRichTextData" );
                    }
                }
                {
                    A3DMarkupDatumData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMarkupDatumData" );
                    }
                }
                {
                    A3DMDFCFDraftingRowData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDFCFDraftingRowData" );
                    }
                }
                {
                    A3DMDFCValueData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDFCValueData" );
                    }
                }
                {
                    A3DMDFCTolerancePerUnitData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDFCTolerancePerUnitData" );
                    }
                }
                {
                    A3DMDFCProjectedZoneData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDFCProjectedZoneData" );
                    }
                }
                {
                    A3DMDFCFToleranceValueData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDFCFToleranceValueData" );
                    }
                }
                {
                    A3DMDFCFRowDatumData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDFCFRowDatumData" );
                    }
                }
                {
                    A3DMDFCFDrawingRowData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDFCFDrawingRowData" );
                    }
                }
                {
                    A3DMDFCFIndicatorData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDFCFIndicatorData" );
                    }
                }
                {
                    A3DMDFeatureControlFrameData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDFeatureControlFrameData" );
                    }
                }
                {
                    A3DMDToleranceSizeValueData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDToleranceSizeValueData" );
                    }
                }
                {
                    A3DMDToleranceSizeData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMDToleranceSizeData" );
                    }
                }
                {
                    A3DMarkupGDTData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMarkupGDTData" );
                    }
                }
                {
                    A3DMarkupSpotWeldingData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMarkupSpotWeldingData" );
                    }
                }
                {
                    A3DMarkupLineWeldingData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMarkupLineWeldingData" );
                    }
                }
                {
                    A3DMathFct1DPolynomData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMathFct1DPolynomData" );
                    }
                }
                {
                    A3DMathFct1DTrigonometricData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMathFct1DTrigonometricData" );
                    }
                }
                {
                    A3DMathFct1DFractionData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMathFct1DFractionData" );
                    }
                }
                {
                    A3DMathFct1DArctanCosData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMathFct1DArctanCosData" );
                    }
                }
                {
                    A3DMathFct1DCombinationData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMathFct1DCombinationData" );
                    }
                }
                {
                    A3DMathFct3DLinearData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMathFct3DLinearData" );
                    }
                }
                {
                    A3DMathFct3DNonLinearData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMathFct3DNonLinearData" );
                    }
                }
                {
                    A3DRootBaseData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRootBaseData" );
                    }
                }
                {
                    A3DRootBaseWithGraphicsData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DRootBaseWithGraphicsData" );
                    }
                }
                {
                    A3DMiscSingleAttributeData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMiscSingleAttributeData" );
                    }
                }
                {
                    A3DMiscAttributeData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMiscAttributeData" );
                    }
                }
                {
                    A3DMiscAttributeBasicUnitData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMiscAttributeBasicUnitData" );
                    }
                }
                {
                    A3DMiscAttributeUnitData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DMiscAttributeUnitData" );
                    }
                }
                {
                    A3DCopyAndAdaptBrepModelData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DCopyAndAdaptBrepModelData" );
                    }
                }
                {
                    A3DPhysicalPropertiesData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DPhysicalPropertiesData" );
                    }
                }
                {
                    A3DTopoBodyData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DTopoBodyData" );
                    }
                }
                {
                    A3DTopoContextData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DTopoContextData" );
                    }
                }
                {
                    A3DTopoSingleWireBodyData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DTopoSingleWireBodyData" );
                    }
                }
                {
                    A3DTopoBrepDataData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DTopoBrepDataData" );
                    }
                }
                {
                    A3DTopoConnexData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DTopoConnexData" );
                    }
                }
                {
                    A3DTopoShellData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DTopoShellData" );
                    }
                }
                {
                    A3DTopoFaceData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DTopoFaceData" );
                    }
                }
                {
                    A3DTopoLoopData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DTopoLoopData" );
                    }
                }
                {
                    A3DTopoCoEdgeData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DTopoCoEdgeData" );
                    }
                }
                {
                    A3DTopoEdgeData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DTopoEdgeData" );
                    }
                }
                {
                    A3DTopoWireEdgeData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DTopoWireEdgeData" );
                    }
                }
                {
                    A3DTopoUniqueVertexData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DTopoUniqueVertexData" );
                    }
                }
                {
                    A3DTopoMultipleVertexData d;
                    if( !API.Initialize( out d ) ) {
                        throw new InvalidOperationException( "Struct sizes do not match for type A3DTopoMultipleVertexData" );
                    }
                }
            } catch( InvalidOperationException e ) {
                return false;
            }
            return true;
        }
    }
}
