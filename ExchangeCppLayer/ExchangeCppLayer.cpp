#include <stdexcept>
#include <sstream>
#define INITIALIZE_A3D_API
#define A3DAPI_GETPROCADDRESS
#include "A3DSDKIncludes.h"
#include "/opt/local/ts3d/CSharp/ExchangeTest/ExchangeCppLayer/ExchangeCppLayer.h"

static std::string exchange_folder;

void SetExchangeLibraryFolder( char const *folder ) {
    exchange_folder = folder;
}

void *GetAPILookupFunction( void ) {
    static auto load_status = A3DSDKLoadLibrary( exchange_folder.c_str() );
    if( nullptr == A3DGetProcAddress && A3D_SUCCESS != load_status ) {
        std::stringstream ss;
        ss << "Unable to load the Exchange libraries, status = " << load_status;
        throw std::runtime_error( ss.str() );
    }
    return reinterpret_cast<void*>(A3DGetProcAddress);
}

void GetVersionNumbers( int *major_version, int *minor_version ) {
    if(major_version) {
        *major_version = A3D_DLL_MAJORVERSION;
    }
    if(minor_version) {
        *minor_version = A3D_DLL_MINORVERSION;
    }
}

bool InitializeA3DVector2dData( A3DVector2dData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DVector2dData ) ) {
        A3D_INITIALIZE_DATA( A3DVector2dData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DVector3dData( A3DVector3dData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DVector3dData ) ) {
        A3D_INITIALIZE_DATA( A3DVector3dData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DIntervalData( A3DIntervalData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DIntervalData ) ) {
        A3D_INITIALIZE_DATA( A3DIntervalData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DDomainData( A3DDomainData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DDomainData ) ) {
        A3D_INITIALIZE_DATA( A3DDomainData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DBoundingBoxData( A3DBoundingBoxData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DBoundingBoxData ) ) {
        A3D_INITIALIZE_DATA( A3DBoundingBoxData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DParameterizationData( A3DParameterizationData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DParameterizationData ) ) {
        A3D_INITIALIZE_DATA( A3DParameterizationData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DUVParameterizationData( A3DUVParameterizationData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DUVParameterizationData ) ) {
        A3D_INITIALIZE_DATA( A3DUVParameterizationData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DTessBaseData( A3DTessBaseData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DTessBaseData ) ) {
        A3D_INITIALIZE_DATA( A3DTessBaseData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DTessFaceData( A3DTessFaceData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DTessFaceData ) ) {
        A3D_INITIALIZE_DATA( A3DTessFaceData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DTess3DData( A3DTess3DData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DTess3DData ) ) {
        A3D_INITIALIZE_DATA( A3DTess3DData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DTess3DWireData( A3DTess3DWireData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DTess3DWireData ) ) {
        A3D_INITIALIZE_DATA( A3DTess3DWireData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DTessMarkupData( A3DTessMarkupData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DTessMarkupData ) ) {
        A3D_INITIALIZE_DATA( A3DTessMarkupData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DGraphicsData( A3DGraphicsData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DGraphicsData ) ) {
        A3D_INITIALIZE_DATA( A3DGraphicsData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DGraphStyleData( A3DGraphStyleData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DGraphStyleData ) ) {
        A3D_INITIALIZE_DATA( A3DGraphStyleData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DGraphRgbColorData( A3DGraphRgbColorData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DGraphRgbColorData ) ) {
        A3D_INITIALIZE_DATA( A3DGraphRgbColorData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DGraphLinePatternData( A3DGraphLinePatternData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DGraphLinePatternData ) ) {
        A3D_INITIALIZE_DATA( A3DGraphLinePatternData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DGraphMaterialData( A3DGraphMaterialData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DGraphMaterialData ) ) {
        A3D_INITIALIZE_DATA( A3DGraphMaterialData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DGraphPictureData( A3DGraphPictureData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DGraphPictureData ) ) {
        A3D_INITIALIZE_DATA( A3DGraphPictureData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DGraphDottingPatternData( A3DGraphDottingPatternData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DGraphDottingPatternData ) ) {
        A3D_INITIALIZE_DATA( A3DGraphDottingPatternData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DGraphHatchingPatternLineData( A3DGraphHatchingPatternLineData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DGraphHatchingPatternLineData ) ) {
        A3D_INITIALIZE_DATA( A3DGraphHatchingPatternLineData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DGraphHatchingPatternData( A3DGraphHatchingPatternData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DGraphHatchingPatternData ) ) {
        A3D_INITIALIZE_DATA( A3DGraphHatchingPatternData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DGraphSolidPatternData( A3DGraphSolidPatternData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DGraphSolidPatternData ) ) {
        A3D_INITIALIZE_DATA( A3DGraphSolidPatternData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DGraphVPicturePatternData( A3DGraphVPicturePatternData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DGraphVPicturePatternData ) ) {
        A3D_INITIALIZE_DATA( A3DGraphVPicturePatternData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DGraphCameraData( A3DGraphCameraData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DGraphCameraData ) ) {
        A3D_INITIALIZE_DATA( A3DGraphCameraData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DGraphAmbientLightData( A3DGraphAmbientLightData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DGraphAmbientLightData ) ) {
        A3D_INITIALIZE_DATA( A3DGraphAmbientLightData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DGraphPointLightData( A3DGraphPointLightData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DGraphPointLightData ) ) {
        A3D_INITIALIZE_DATA( A3DGraphPointLightData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DGraphSpotLightData( A3DGraphSpotLightData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DGraphSpotLightData ) ) {
        A3D_INITIALIZE_DATA( A3DGraphSpotLightData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DGraphDirectionalLightData( A3DGraphDirectionalLightData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DGraphDirectionalLightData ) ) {
        A3D_INITIALIZE_DATA( A3DGraphDirectionalLightData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DGraphSceneDisplayParametersData( A3DGraphSceneDisplayParametersData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DGraphSceneDisplayParametersData ) ) {
        A3D_INITIALIZE_DATA( A3DGraphSceneDisplayParametersData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMiscCascadedAttributesData( A3DMiscCascadedAttributesData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMiscCascadedAttributesData ) ) {
        A3D_INITIALIZE_DATA( A3DMiscCascadedAttributesData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMiscGeneralTransformationData( A3DMiscGeneralTransformationData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMiscGeneralTransformationData ) ) {
        A3D_INITIALIZE_DATA( A3DMiscGeneralTransformationData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMiscCartesianTransformationData( A3DMiscCartesianTransformationData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMiscCartesianTransformationData ) ) {
        A3D_INITIALIZE_DATA( A3DMiscCartesianTransformationData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMiscEntityReferenceData( A3DMiscEntityReferenceData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMiscEntityReferenceData ) ) {
        A3D_INITIALIZE_DATA( A3DMiscEntityReferenceData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMiscReferenceOnTopologyData( A3DMiscReferenceOnTopologyData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMiscReferenceOnTopologyData ) ) {
        A3D_INITIALIZE_DATA( A3DMiscReferenceOnTopologyData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMiscReferenceOnTessData( A3DMiscReferenceOnTessData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMiscReferenceOnTessData ) ) {
        A3D_INITIALIZE_DATA( A3DMiscReferenceOnTessData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMiscReferenceOnCsysItemData( A3DMiscReferenceOnCsysItemData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMiscReferenceOnCsysItemData ) ) {
        A3D_INITIALIZE_DATA( A3DMiscReferenceOnCsysItemData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMiscPhysicMaterialData( A3DMiscPhysicMaterialData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMiscPhysicMaterialData ) ) {
        A3D_INITIALIZE_DATA( A3DMiscPhysicMaterialData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMiscMaterialFiberData( A3DMiscMaterialFiberData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMiscMaterialFiberData ) ) {
        A3D_INITIALIZE_DATA( A3DMiscMaterialFiberData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMiscMaterialHoneyCombData( A3DMiscMaterialHoneyCombData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMiscMaterialHoneyCombData ) ) {
        A3D_INITIALIZE_DATA( A3DMiscMaterialHoneyCombData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMiscMaterialIsotropicData( A3DMiscMaterialIsotropicData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMiscMaterialIsotropicData ) ) {
        A3D_INITIALIZE_DATA( A3DMiscMaterialIsotropicData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMiscMaterialOrthotropic2DData( A3DMiscMaterialOrthotropic2DData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMiscMaterialOrthotropic2DData ) ) {
        A3D_INITIALIZE_DATA( A3DMiscMaterialOrthotropic2DData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMiscMaterialOrthotropic3DData( A3DMiscMaterialOrthotropic3DData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMiscMaterialOrthotropic3DData ) ) {
        A3D_INITIALIZE_DATA( A3DMiscMaterialOrthotropic3DData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMiscMaterialAnisotropicData( A3DMiscMaterialAnisotropicData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMiscMaterialAnisotropicData ) ) {
        A3D_INITIALIZE_DATA( A3DMiscMaterialAnisotropicData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMiscMaterialPropertiesData( A3DMiscMaterialPropertiesData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMiscMaterialPropertiesData ) ) {
        A3D_INITIALIZE_DATA( A3DMiscMaterialPropertiesData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DAsmModelFileData( A3DAsmModelFileData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DAsmModelFileData ) ) {
        A3D_INITIALIZE_DATA( A3DAsmModelFileData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DAsmProductOccurrenceData( A3DAsmProductOccurrenceData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DAsmProductOccurrenceData ) ) {
        A3D_INITIALIZE_DATA( A3DAsmProductOccurrenceData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DAsmProductOccurrenceDataSLW( A3DAsmProductOccurrenceDataSLW *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DAsmProductOccurrenceDataSLW ) ) {
        A3D_INITIALIZE_DATA( A3DAsmProductOccurrenceDataSLW, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DAsmProductOccurrenceDataCat( A3DAsmProductOccurrenceDataCat *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DAsmProductOccurrenceDataCat ) ) {
        A3D_INITIALIZE_DATA( A3DAsmProductOccurrenceDataCat, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DAsmProductOccurrenceDataCV5( A3DAsmProductOccurrenceDataCV5 *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DAsmProductOccurrenceDataCV5 ) ) {
        A3D_INITIALIZE_DATA( A3DAsmProductOccurrenceDataCV5, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DAsmProductOccurrenceDataUg( A3DAsmProductOccurrenceDataUg *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DAsmProductOccurrenceDataUg ) ) {
        A3D_INITIALIZE_DATA( A3DAsmProductOccurrenceDataUg, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DAsmProductOccurrenceDataProe( A3DAsmProductOccurrenceDataProe *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DAsmProductOccurrenceDataProe ) ) {
        A3D_INITIALIZE_DATA( A3DAsmProductOccurrenceDataProe, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DAsmProductOccurrenceDataInv( A3DAsmProductOccurrenceDataInv *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DAsmProductOccurrenceDataInv ) ) {
        A3D_INITIALIZE_DATA( A3DAsmProductOccurrenceDataInv, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DAsmProductOccurrenceDataJT( A3DAsmProductOccurrenceDataJT *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DAsmProductOccurrenceDataJT ) ) {
        A3D_INITIALIZE_DATA( A3DAsmProductOccurrenceDataJT, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DAsmPartDefinitionData( A3DAsmPartDefinitionData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DAsmPartDefinitionData ) ) {
        A3D_INITIALIZE_DATA( A3DAsmPartDefinitionData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DAsmLayerFilterItemData( A3DAsmLayerFilterItemData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DAsmLayerFilterItemData ) ) {
        A3D_INITIALIZE_DATA( A3DAsmLayerFilterItemData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DAsmEntityFilterItemData( A3DAsmEntityFilterItemData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DAsmEntityFilterItemData ) ) {
        A3D_INITIALIZE_DATA( A3DAsmEntityFilterItemData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DAsmFilterData( A3DAsmFilterData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DAsmFilterData ) ) {
        A3D_INITIALIZE_DATA( A3DAsmFilterData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsGeneralData( A3DRWParamsGeneralData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsGeneralData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsGeneralData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsPmiData( A3DRWParamsPmiData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsPmiData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsPmiData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsTessellationData( A3DRWParamsTessellationData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsTessellationData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsTessellationData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsSearchDirData( A3DRWParamsSearchDirData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsSearchDirData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsSearchDirData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsAssemblyData( A3DRWParamsAssemblyData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsAssemblyData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsAssemblyData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsMultiEntriesData( A3DRWParamsMultiEntriesData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsMultiEntriesData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsMultiEntriesData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsCatiaV4Data( A3DRWParamsCatiaV4Data *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsCatiaV4Data ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsCatiaV4Data, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsCatiaV5Data( A3DRWParamsCatiaV5Data *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsCatiaV5Data ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsCatiaV5Data, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsUnigraphicsData( A3DRWParamsUnigraphicsData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsUnigraphicsData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsUnigraphicsData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsProEData( A3DRWParamsProEData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsProEData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsProEData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWValidationPropertiesThresholdData( A3DRWValidationPropertiesThresholdData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWValidationPropertiesThresholdData ) ) {
        A3D_INITIALIZE_DATA( A3DRWValidationPropertiesThresholdData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsStepData( A3DRWParamsStepData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsStepData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsStepData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsIGESData( A3DRWParamsIGESData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsIGESData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsIGESData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsIFCData( A3DRWParamsIFCData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsIFCData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsIFCData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsJTData( A3DRWParamsJTData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsJTData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsJTData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsParasolidData( A3DRWParamsParasolidData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsParasolidData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsParasolidData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsSolidworksData( A3DRWParamsSolidworksData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsSolidworksData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsSolidworksData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsInventorData( A3DRWParamsInventorData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsInventorData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsInventorData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsRhinoData( A3DRWParamsRhinoData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsRhinoData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsRhinoData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsRevitData( A3DRWParamsRevitData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsRevitData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsRevitData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsSpecificLoadData( A3DRWParamsSpecificLoadData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsSpecificLoadData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsSpecificLoadData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsIncrementalLoadData( A3DRWParamsIncrementalLoadData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsIncrementalLoadData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsIncrementalLoadData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsLoadData( A3DRWParamsLoadData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsLoadData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsLoadData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DStream3DPDFData( A3DStream3DPDFData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DStream3DPDFData ) ) {
        A3D_INITIALIZE_DATA( A3DStream3DPDFData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsExportPrcData( A3DRWParamsExportPrcData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsExportPrcData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsExportPrcData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsExportU3DData( A3DRWParamsExportU3DData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsExportU3DData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsExportU3DData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsExportStepData( A3DRWParamsExportStepData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsExportStepData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsExportStepData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsExportJTData( A3DRWParamsExportJTData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsExportJTData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsExportJTData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsExportIgesData( A3DRWParamsExportIgesData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsExportIgesData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsExportIgesData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsExportStlData( A3DRWParamsExportStlData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsExportStlData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsExportStlData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsExport3mfData( A3DRWParamsExport3mfData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsExport3mfData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsExport3mfData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsExportXMLData( A3DRWParamsExportXMLData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsExportXMLData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsExportXMLData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsExportObjData( A3DRWParamsExportObjData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsExportObjData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsExportObjData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsExportFbxData( A3DRWParamsExportFbxData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsExportFbxData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsExportFbxData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DSewOptionsData( A3DSewOptionsData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DSewOptionsData ) ) {
        A3D_INITIALIZE_DATA( A3DSewOptionsData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DFaceUVPointInsideManagerData( A3DFaceUVPointInsideManagerData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DFaceUVPointInsideManagerData ) ) {
        A3D_INITIALIZE_DATA( A3DFaceUVPointInsideManagerData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DProjectedPointCloudData( A3DProjectedPointCloudData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DProjectedPointCloudData ) ) {
        A3D_INITIALIZE_DATA( A3DProjectedPointCloudData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DProjectPointCloudManagerDataFromRI( A3DProjectPointCloudManagerDataFromRI *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DProjectPointCloudManagerDataFromRI ) ) {
        A3D_INITIALIZE_DATA( A3DProjectPointCloudManagerDataFromRI, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DPlanarSectionData( A3DPlanarSectionData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DPlanarSectionData ) ) {
        A3D_INITIALIZE_DATA( A3DPlanarSectionData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCompareInputData( A3DCompareInputData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCompareInputData ) ) {
        A3D_INITIALIZE_DATA( A3DCompareInputData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCompareOutputData( A3DCompareOutputData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCompareOutputData ) ) {
        A3D_INITIALIZE_DATA( A3DCompareOutputData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMultiPlanarSectionData( A3DMultiPlanarSectionData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMultiPlanarSectionData ) ) {
        A3D_INITIALIZE_DATA( A3DMultiPlanarSectionData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DHLRViewPlaneData( A3DHLRViewPlaneData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DHLRViewPlaneData ) ) {
        A3D_INITIALIZE_DATA( A3DHLRViewPlaneData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DHLRCurveData( A3DHLRCurveData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DHLRCurveData ) ) {
        A3D_INITIALIZE_DATA( A3DHLRCurveData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DHLRSectionFaceData( A3DHLRSectionFaceData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DHLRSectionFaceData ) ) {
        A3D_INITIALIZE_DATA( A3DHLRSectionFaceData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DHLRRepresentationItemData( A3DHLRRepresentationItemData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DHLRRepresentationItemData ) ) {
        A3D_INITIALIZE_DATA( A3DHLRRepresentationItemData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DHLROptionsData( A3DHLROptionsData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DHLROptionsData ) ) {
        A3D_INITIALIZE_DATA( A3DHLROptionsData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DTransfoRepresentationItemData( A3DTransfoRepresentationItemData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DTransfoRepresentationItemData ) ) {
        A3D_INITIALIZE_DATA( A3DTransfoRepresentationItemData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCollisionGroupData( A3DCollisionGroupData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCollisionGroupData ) ) {
        A3D_INITIALIZE_DATA( A3DCollisionGroupData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCollisionParameterData( A3DCollisionParameterData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCollisionParameterData ) ) {
        A3D_INITIALIZE_DATA( A3DCollisionParameterData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCollisionResultData( A3DCollisionResultData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCollisionResultData ) ) {
        A3D_INITIALIZE_DATA( A3DCollisionResultData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMkpLeaderData( A3DMkpLeaderData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMkpLeaderData ) ) {
        A3D_INITIALIZE_DATA( A3DMkpLeaderData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMkpAnnotationItemData( A3DMkpAnnotationItemData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMkpAnnotationItemData ) ) {
        A3D_INITIALIZE_DATA( A3DMkpAnnotationItemData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMkpAnnotationSetData( A3DMkpAnnotationSetData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMkpAnnotationSetData ) ) {
        A3D_INITIALIZE_DATA( A3DMkpAnnotationSetData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMkpAnnotationReferenceData( A3DMkpAnnotationReferenceData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMkpAnnotationReferenceData ) ) {
        A3D_INITIALIZE_DATA( A3DMkpAnnotationReferenceData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMkpViewData( A3DMkpViewData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMkpViewData ) ) {
        A3D_INITIALIZE_DATA( A3DMkpViewData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMkpViewFlagsData( A3DMkpViewFlagsData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMkpViewFlagsData ) ) {
        A3D_INITIALIZE_DATA( A3DMkpViewFlagsData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMiscMarkupLinkedItemData( A3DMiscMarkupLinkedItemData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMiscMarkupLinkedItemData ) ) {
        A3D_INITIALIZE_DATA( A3DMiscMarkupLinkedItemData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMkpMarkupData( A3DMkpMarkupData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMkpMarkupData ) ) {
        A3D_INITIALIZE_DATA( A3DMkpMarkupData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMkpRTFFieldData( A3DMkpRTFFieldData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMkpRTFFieldData ) ) {
        A3D_INITIALIZE_DATA( A3DMkpRTFFieldData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DFontKeyData( A3DFontKeyData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DFontKeyData ) ) {
        A3D_INITIALIZE_DATA( A3DFontKeyData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DFontData( A3DFontData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DFontData ) ) {
        A3D_INITIALIZE_DATA( A3DFontData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DGraphTextureTransformationData( A3DGraphTextureTransformationData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DGraphTextureTransformationData ) ) {
        A3D_INITIALIZE_DATA( A3DGraphTextureTransformationData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DGraphTextureDefinitionData( A3DGraphTextureDefinitionData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DGraphTextureDefinitionData ) ) {
        A3D_INITIALIZE_DATA( A3DGraphTextureDefinitionData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DGraphTextureApplicationData( A3DGraphTextureApplicationData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DGraphTextureApplicationData ) ) {
        A3D_INITIALIZE_DATA( A3DGraphTextureApplicationData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DDrawCallbacksData( A3DDrawCallbacksData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DDrawCallbacksData ) ) {
        A3D_INITIALIZE_DATA( A3DDrawCallbacksData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DDrawingModelData( A3DDrawingModelData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DDrawingModelData ) ) {
        A3D_INITIALIZE_DATA( A3DDrawingModelData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DDrawingSheetFormatData( A3DDrawingSheetFormatData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DDrawingSheetFormatData ) ) {
        A3D_INITIALIZE_DATA( A3DDrawingSheetFormatData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DDrawingSheetData( A3DDrawingSheetData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DDrawingSheetData ) ) {
        A3D_INITIALIZE_DATA( A3DDrawingSheetData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DDrawingClipFrameData( A3DDrawingClipFrameData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DDrawingClipFrameData ) ) {
        A3D_INITIALIZE_DATA( A3DDrawingClipFrameData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DDrawingViewData( A3DDrawingViewData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DDrawingViewData ) ) {
        A3D_INITIALIZE_DATA( A3DDrawingViewData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DDrawingBlockBasicData( A3DDrawingBlockBasicData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DDrawingBlockBasicData ) ) {
        A3D_INITIALIZE_DATA( A3DDrawingBlockBasicData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DDrawingBlockOperatorData( A3DDrawingBlockOperatorData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DDrawingBlockOperatorData ) ) {
        A3D_INITIALIZE_DATA( A3DDrawingBlockOperatorData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DDrawingCurveData( A3DDrawingCurveData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DDrawingCurveData ) ) {
        A3D_INITIALIZE_DATA( A3DDrawingCurveData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DDrawingFilledAreaData( A3DDrawingFilledAreaData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DDrawingFilledAreaData ) ) {
        A3D_INITIALIZE_DATA( A3DDrawingFilledAreaData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DDrawingPictureData( A3DDrawingPictureData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DDrawingPictureData ) ) {
        A3D_INITIALIZE_DATA( A3DDrawingPictureData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DDrawingVerticesData( A3DDrawingVerticesData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DDrawingVerticesData ) ) {
        A3D_INITIALIZE_DATA( A3DDrawingVerticesData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DThumbnailData( A3DThumbnailData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DThumbnailData ) ) {
        A3D_INITIALIZE_DATA( A3DThumbnailData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DFileInformationData( A3DFileInformationData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DFileInformationData ) ) {
        A3D_INITIALIZE_DATA( A3DFileInformationData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DFileContextData( A3DFileContextData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DFileContextData ) ) {
        A3D_INITIALIZE_DATA( A3DFileContextData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsExportParasolidData( A3DRWParamsExportParasolidData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsExportParasolidData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsExportParasolidData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsTranslateToPkPartsData( A3DRWParamsTranslateToPkPartsData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsTranslateToPkPartsData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsTranslateToPkPartsData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRWParamsExportAcisData( A3DRWParamsExportAcisData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRWParamsExportAcisData ) ) {
        A3D_INITIALIZE_DATA( A3DRWParamsExportAcisData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRiRepresentationItemData( A3DRiRepresentationItemData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRiRepresentationItemData ) ) {
        A3D_INITIALIZE_DATA( A3DRiRepresentationItemData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRiSetData( A3DRiSetData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRiSetData ) ) {
        A3D_INITIALIZE_DATA( A3DRiSetData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRiPointSetData( A3DRiPointSetData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRiPointSetData ) ) {
        A3D_INITIALIZE_DATA( A3DRiPointSetData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRiDirectionData( A3DRiDirectionData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRiDirectionData ) ) {
        A3D_INITIALIZE_DATA( A3DRiDirectionData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRiCoordinateSystemData( A3DRiCoordinateSystemData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRiCoordinateSystemData ) ) {
        A3D_INITIALIZE_DATA( A3DRiCoordinateSystemData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRiCurveData( A3DRiCurveData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRiCurveData ) ) {
        A3D_INITIALIZE_DATA( A3DRiCurveData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRiPlaneData( A3DRiPlaneData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRiPlaneData ) ) {
        A3D_INITIALIZE_DATA( A3DRiPlaneData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRiBrepModelData( A3DRiBrepModelData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRiBrepModelData ) ) {
        A3D_INITIALIZE_DATA( A3DRiBrepModelData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRiPolyBrepModelData( A3DRiPolyBrepModelData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRiPolyBrepModelData ) ) {
        A3D_INITIALIZE_DATA( A3DRiPolyBrepModelData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRiPolyWireData( A3DRiPolyWireData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRiPolyWireData ) ) {
        A3D_INITIALIZE_DATA( A3DRiPolyWireData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DFRMFeatureTreeData( A3DFRMFeatureTreeData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DFRMFeatureTreeData ) ) {
        A3D_INITIALIZE_DATA( A3DFRMFeatureTreeData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DFRMParameterData( A3DFRMParameterData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DFRMParameterData ) ) {
        A3D_INITIALIZE_DATA( A3DFRMParameterData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DFRMFeatureTypeData( A3DFRMFeatureTypeData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DFRMFeatureTypeData ) ) {
        A3D_INITIALIZE_DATA( A3DFRMFeatureTypeData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DFRMStringData( A3DFRMStringData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DFRMStringData ) ) {
        A3D_INITIALIZE_DATA( A3DFRMStringData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DFRMDoubleData( A3DFRMDoubleData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DFRMDoubleData ) ) {
        A3D_INITIALIZE_DATA( A3DFRMDoubleData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DFRMIntegerData( A3DFRMIntegerData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DFRMIntegerData ) ) {
        A3D_INITIALIZE_DATA( A3DFRMIntegerData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DFRMFeatureLinkedItemData( A3DFRMFeatureLinkedItemData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DFRMFeatureLinkedItemData ) ) {
        A3D_INITIALIZE_DATA( A3DFRMFeatureLinkedItemData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DFRMFeatureData( A3DFRMFeatureData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DFRMFeatureData ) ) {
        A3D_INITIALIZE_DATA( A3DFRMFeatureData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DFRMFeatureGeomEntitiesData( A3DFRMFeatureGeomEntitiesData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DFRMFeatureGeomEntitiesData ) ) {
        A3D_INITIALIZE_DATA( A3DFRMFeatureGeomEntitiesData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCrvNurbsData( A3DCrvNurbsData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCrvNurbsData ) ) {
        A3D_INITIALIZE_DATA( A3DCrvNurbsData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCrvLineData( A3DCrvLineData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCrvLineData ) ) {
        A3D_INITIALIZE_DATA( A3DCrvLineData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCrvCircleData( A3DCrvCircleData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCrvCircleData ) ) {
        A3D_INITIALIZE_DATA( A3DCrvCircleData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCrvEllipseData( A3DCrvEllipseData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCrvEllipseData ) ) {
        A3D_INITIALIZE_DATA( A3DCrvEllipseData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCrvParabolaData( A3DCrvParabolaData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCrvParabolaData ) ) {
        A3D_INITIALIZE_DATA( A3DCrvParabolaData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCrvHyperbolaData( A3DCrvHyperbolaData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCrvHyperbolaData ) ) {
        A3D_INITIALIZE_DATA( A3DCrvHyperbolaData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCrvPolyLineData( A3DCrvPolyLineData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCrvPolyLineData ) ) {
        A3D_INITIALIZE_DATA( A3DCrvPolyLineData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCrvCompositeData( A3DCrvCompositeData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCrvCompositeData ) ) {
        A3D_INITIALIZE_DATA( A3DCrvCompositeData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCrvEquationData( A3DCrvEquationData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCrvEquationData ) ) {
        A3D_INITIALIZE_DATA( A3DCrvEquationData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCrvTransformData( A3DCrvTransformData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCrvTransformData ) ) {
        A3D_INITIALIZE_DATA( A3DCrvTransformData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCrvOnSurfData( A3DCrvOnSurfData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCrvOnSurfData ) ) {
        A3D_INITIALIZE_DATA( A3DCrvOnSurfData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCrvOffsetData( A3DCrvOffsetData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCrvOffsetData ) ) {
        A3D_INITIALIZE_DATA( A3DCrvOffsetData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCrvHelixPitchCstData( A3DCrvHelixPitchCstData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCrvHelixPitchCstData ) ) {
        A3D_INITIALIZE_DATA( A3DCrvHelixPitchCstData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCrvHelixPitchVarData( A3DCrvHelixPitchVarData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCrvHelixPitchVarData ) ) {
        A3D_INITIALIZE_DATA( A3DCrvHelixPitchVarData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCrvHelixData( A3DCrvHelixData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCrvHelixData ) ) {
        A3D_INITIALIZE_DATA( A3DCrvHelixData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCrossingPointsCrvIntersectionData( A3DCrossingPointsCrvIntersectionData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCrossingPointsCrvIntersectionData ) ) {
        A3D_INITIALIZE_DATA( A3DCrossingPointsCrvIntersectionData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCrvIntersectionData( A3DCrvIntersectionData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCrvIntersectionData ) ) {
        A3D_INITIALIZE_DATA( A3DCrvIntersectionData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCrvBlend02BoundaryData( A3DCrvBlend02BoundaryData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCrvBlend02BoundaryData ) ) {
        A3D_INITIALIZE_DATA( A3DCrvBlend02BoundaryData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DSurfNurbsData( A3DSurfNurbsData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DSurfNurbsData ) ) {
        A3D_INITIALIZE_DATA( A3DSurfNurbsData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DSurfSphereData( A3DSurfSphereData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DSurfSphereData ) ) {
        A3D_INITIALIZE_DATA( A3DSurfSphereData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DSurfCylinderData( A3DSurfCylinderData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DSurfCylinderData ) ) {
        A3D_INITIALIZE_DATA( A3DSurfCylinderData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DSurfTorusData( A3DSurfTorusData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DSurfTorusData ) ) {
        A3D_INITIALIZE_DATA( A3DSurfTorusData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DSurfRevolutionData( A3DSurfRevolutionData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DSurfRevolutionData ) ) {
        A3D_INITIALIZE_DATA( A3DSurfRevolutionData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DSurfExtrusionData( A3DSurfExtrusionData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DSurfExtrusionData ) ) {
        A3D_INITIALIZE_DATA( A3DSurfExtrusionData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DSurfOffsetData( A3DSurfOffsetData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DSurfOffsetData ) ) {
        A3D_INITIALIZE_DATA( A3DSurfOffsetData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DSurfPlaneData( A3DSurfPlaneData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DSurfPlaneData ) ) {
        A3D_INITIALIZE_DATA( A3DSurfPlaneData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DSurfBlend01Data( A3DSurfBlend01Data *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DSurfBlend01Data ) ) {
        A3D_INITIALIZE_DATA( A3DSurfBlend01Data, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DSurfBlend02Data( A3DSurfBlend02Data *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DSurfBlend02Data ) ) {
        A3D_INITIALIZE_DATA( A3DSurfBlend02Data, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DSurfBlend03Data( A3DSurfBlend03Data *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DSurfBlend03Data ) ) {
        A3D_INITIALIZE_DATA( A3DSurfBlend03Data, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DSurfConeData( A3DSurfConeData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DSurfConeData ) ) {
        A3D_INITIALIZE_DATA( A3DSurfConeData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DSurfCylindricalData( A3DSurfCylindricalData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DSurfCylindricalData ) ) {
        A3D_INITIALIZE_DATA( A3DSurfCylindricalData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DSurfRuledData( A3DSurfRuledData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DSurfRuledData ) ) {
        A3D_INITIALIZE_DATA( A3DSurfRuledData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DSurfPipeData( A3DSurfPipeData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DSurfPipeData ) ) {
        A3D_INITIALIZE_DATA( A3DSurfPipeData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DSurfTransformData( A3DSurfTransformData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DSurfTransformData ) ) {
        A3D_INITIALIZE_DATA( A3DSurfTransformData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DSurfFromCurvesData( A3DSurfFromCurvesData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DSurfFromCurvesData ) ) {
        A3D_INITIALIZE_DATA( A3DSurfFromCurvesData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DGlobalData( A3DGlobalData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DGlobalData ) ) {
        A3D_INITIALIZE_DATA( A3DGlobalData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDPosition3DData( A3DMDPosition3DData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDPosition3DData ) ) {
        A3D_INITIALIZE_DATA( A3DMDPosition3DData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDPosition2DData( A3DMDPosition2DData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDPosition2DData ) ) {
        A3D_INITIALIZE_DATA( A3DMDPosition2DData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDPositionReferenceData( A3DMDPositionReferenceData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDPositionReferenceData ) ) {
        A3D_INITIALIZE_DATA( A3DMDPositionReferenceData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDLeaderSymbolData( A3DMDLeaderSymbolData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDLeaderSymbolData ) ) {
        A3D_INITIALIZE_DATA( A3DMDLeaderSymbolData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDMarkupLeaderStubData( A3DMDMarkupLeaderStubData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDMarkupLeaderStubData ) ) {
        A3D_INITIALIZE_DATA( A3DMDMarkupLeaderStubData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDLeaderDefinitionData( A3DMDLeaderDefinitionData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDLeaderDefinitionData ) ) {
        A3D_INITIALIZE_DATA( A3DMDLeaderDefinitionData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDTextPropertiesData( A3DMDTextPropertiesData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDTextPropertiesData ) ) {
        A3D_INITIALIZE_DATA( A3DMDTextPropertiesData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMarkupDefinitionData( A3DMarkupDefinitionData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMarkupDefinitionData ) ) {
        A3D_INITIALIZE_DATA( A3DMarkupDefinitionData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDDimensionValueFormatData( A3DMDDimensionValueFormatData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDDimensionValueFormatData ) ) {
        A3D_INITIALIZE_DATA( A3DMDDimensionValueFormatData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDDimensionSimpleToleranceFormatData( A3DMDDimensionSimpleToleranceFormatData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDDimensionSimpleToleranceFormatData ) ) {
        A3D_INITIALIZE_DATA( A3DMDDimensionSimpleToleranceFormatData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDDimensionCombinedToleranceFormatData( A3DMDDimensionCombinedToleranceFormatData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDDimensionCombinedToleranceFormatData ) ) {
        A3D_INITIALIZE_DATA( A3DMDDimensionCombinedToleranceFormatData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDDimensionValueData( A3DMDDimensionValueData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDDimensionValueData ) ) {
        A3D_INITIALIZE_DATA( A3DMDDimensionValueData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDDimensionSecondPartData( A3DMDDimensionSecondPartData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDDimensionSecondPartData ) ) {
        A3D_INITIALIZE_DATA( A3DMDDimensionSecondPartData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDDimensionForeshortenedData( A3DMDDimensionForeshortenedData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDDimensionForeshortenedData ) ) {
        A3D_INITIALIZE_DATA( A3DMDDimensionForeshortenedData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDDimensionLineSymbolData( A3DMDDimensionLineSymbolData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDDimensionLineSymbolData ) ) {
        A3D_INITIALIZE_DATA( A3DMDDimensionLineSymbolData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDDimensionLineData( A3DMDDimensionLineData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDDimensionLineData ) ) {
        A3D_INITIALIZE_DATA( A3DMDDimensionLineData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDDimensionFunnelData( A3DMDDimensionFunnelData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDDimensionFunnelData ) ) {
        A3D_INITIALIZE_DATA( A3DMDDimensionFunnelData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDDimensionExtremityData( A3DMDDimensionExtremityData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDDimensionExtremityData ) ) {
        A3D_INITIALIZE_DATA( A3DMDDimensionExtremityData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDDimensionExtentionLineData( A3DMDDimensionExtentionLineData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDDimensionExtentionLineData ) ) {
        A3D_INITIALIZE_DATA( A3DMDDimensionExtentionLineData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMarkupDimensionData( A3DMarkupDimensionData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMarkupDimensionData ) ) {
        A3D_INITIALIZE_DATA( A3DMarkupDimensionData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMarkupRoughnessData( A3DMarkupRoughnessData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMarkupRoughnessData ) ) {
        A3D_INITIALIZE_DATA( A3DMarkupRoughnessData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMarkupBalloonData( A3DMarkupBalloonData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMarkupBalloonData ) ) {
        A3D_INITIALIZE_DATA( A3DMarkupBalloonData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMarkupFastenerData( A3DMarkupFastenerData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMarkupFastenerData ) ) {
        A3D_INITIALIZE_DATA( A3DMarkupFastenerData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMarkupLocatorData( A3DMarkupLocatorData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMarkupLocatorData ) ) {
        A3D_INITIALIZE_DATA( A3DMarkupLocatorData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMarkupMeasurementPointData( A3DMarkupMeasurementPointData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMarkupMeasurementPointData ) ) {
        A3D_INITIALIZE_DATA( A3DMarkupMeasurementPointData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDTextPositionData( A3DMDTextPositionData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDTextPositionData ) ) {
        A3D_INITIALIZE_DATA( A3DMDTextPositionData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMarkupTextData( A3DMarkupTextData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMarkupTextData ) ) {
        A3D_INITIALIZE_DATA( A3DMarkupTextData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMarkupCoordinateData( A3DMarkupCoordinateData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMarkupCoordinateData ) ) {
        A3D_INITIALIZE_DATA( A3DMarkupCoordinateData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMarkupRichTextData( A3DMarkupRichTextData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMarkupRichTextData ) ) {
        A3D_INITIALIZE_DATA( A3DMarkupRichTextData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMarkupDatumData( A3DMarkupDatumData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMarkupDatumData ) ) {
        A3D_INITIALIZE_DATA( A3DMarkupDatumData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDFCFDraftingRowData( A3DMDFCFDraftingRowData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDFCFDraftingRowData ) ) {
        A3D_INITIALIZE_DATA( A3DMDFCFDraftingRowData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDFCValueData( A3DMDFCValueData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDFCValueData ) ) {
        A3D_INITIALIZE_DATA( A3DMDFCValueData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDFCTolerancePerUnitData( A3DMDFCTolerancePerUnitData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDFCTolerancePerUnitData ) ) {
        A3D_INITIALIZE_DATA( A3DMDFCTolerancePerUnitData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDFCProjectedZoneData( A3DMDFCProjectedZoneData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDFCProjectedZoneData ) ) {
        A3D_INITIALIZE_DATA( A3DMDFCProjectedZoneData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDFCFToleranceValueData( A3DMDFCFToleranceValueData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDFCFToleranceValueData ) ) {
        A3D_INITIALIZE_DATA( A3DMDFCFToleranceValueData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDFCFRowDatumData( A3DMDFCFRowDatumData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDFCFRowDatumData ) ) {
        A3D_INITIALIZE_DATA( A3DMDFCFRowDatumData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDFCFDrawingRowData( A3DMDFCFDrawingRowData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDFCFDrawingRowData ) ) {
        A3D_INITIALIZE_DATA( A3DMDFCFDrawingRowData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDFCFIndicatorData( A3DMDFCFIndicatorData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDFCFIndicatorData ) ) {
        A3D_INITIALIZE_DATA( A3DMDFCFIndicatorData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDFeatureControlFrameData( A3DMDFeatureControlFrameData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDFeatureControlFrameData ) ) {
        A3D_INITIALIZE_DATA( A3DMDFeatureControlFrameData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDToleranceSizeValueData( A3DMDToleranceSizeValueData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDToleranceSizeValueData ) ) {
        A3D_INITIALIZE_DATA( A3DMDToleranceSizeValueData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMDToleranceSizeData( A3DMDToleranceSizeData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMDToleranceSizeData ) ) {
        A3D_INITIALIZE_DATA( A3DMDToleranceSizeData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMarkupGDTData( A3DMarkupGDTData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMarkupGDTData ) ) {
        A3D_INITIALIZE_DATA( A3DMarkupGDTData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMarkupSpotWeldingData( A3DMarkupSpotWeldingData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMarkupSpotWeldingData ) ) {
        A3D_INITIALIZE_DATA( A3DMarkupSpotWeldingData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMarkupLineWeldingData( A3DMarkupLineWeldingData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMarkupLineWeldingData ) ) {
        A3D_INITIALIZE_DATA( A3DMarkupLineWeldingData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMathFct1DPolynomData( A3DMathFct1DPolynomData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMathFct1DPolynomData ) ) {
        A3D_INITIALIZE_DATA( A3DMathFct1DPolynomData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMathFct1DTrigonometricData( A3DMathFct1DTrigonometricData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMathFct1DTrigonometricData ) ) {
        A3D_INITIALIZE_DATA( A3DMathFct1DTrigonometricData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMathFct1DFractionData( A3DMathFct1DFractionData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMathFct1DFractionData ) ) {
        A3D_INITIALIZE_DATA( A3DMathFct1DFractionData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMathFct1DArctanCosData( A3DMathFct1DArctanCosData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMathFct1DArctanCosData ) ) {
        A3D_INITIALIZE_DATA( A3DMathFct1DArctanCosData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMathFct1DCombinationData( A3DMathFct1DCombinationData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMathFct1DCombinationData ) ) {
        A3D_INITIALIZE_DATA( A3DMathFct1DCombinationData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMathFct3DLinearData( A3DMathFct3DLinearData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMathFct3DLinearData ) ) {
        A3D_INITIALIZE_DATA( A3DMathFct3DLinearData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMathFct3DNonLinearData( A3DMathFct3DNonLinearData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMathFct3DNonLinearData ) ) {
        A3D_INITIALIZE_DATA( A3DMathFct3DNonLinearData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRootBaseData( A3DRootBaseData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRootBaseData ) ) {
        A3D_INITIALIZE_DATA( A3DRootBaseData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DRootBaseWithGraphicsData( A3DRootBaseWithGraphicsData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DRootBaseWithGraphicsData ) ) {
        A3D_INITIALIZE_DATA( A3DRootBaseWithGraphicsData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMiscSingleAttributeData( A3DMiscSingleAttributeData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMiscSingleAttributeData ) ) {
        A3D_INITIALIZE_DATA( A3DMiscSingleAttributeData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMiscAttributeData( A3DMiscAttributeData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMiscAttributeData ) ) {
        A3D_INITIALIZE_DATA( A3DMiscAttributeData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMiscAttributeBasicUnitData( A3DMiscAttributeBasicUnitData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMiscAttributeBasicUnitData ) ) {
        A3D_INITIALIZE_DATA( A3DMiscAttributeBasicUnitData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DMiscAttributeUnitData( A3DMiscAttributeUnitData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DMiscAttributeUnitData ) ) {
        A3D_INITIALIZE_DATA( A3DMiscAttributeUnitData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DCopyAndAdaptBrepModelData( A3DCopyAndAdaptBrepModelData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DCopyAndAdaptBrepModelData ) ) {
        A3D_INITIALIZE_DATA( A3DCopyAndAdaptBrepModelData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DPhysicalPropertiesData( A3DPhysicalPropertiesData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DPhysicalPropertiesData ) ) {
        A3D_INITIALIZE_DATA( A3DPhysicalPropertiesData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DTopoBodyData( A3DTopoBodyData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DTopoBodyData ) ) {
        A3D_INITIALIZE_DATA( A3DTopoBodyData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DTopoContextData( A3DTopoContextData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DTopoContextData ) ) {
        A3D_INITIALIZE_DATA( A3DTopoContextData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DTopoSingleWireBodyData( A3DTopoSingleWireBodyData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DTopoSingleWireBodyData ) ) {
        A3D_INITIALIZE_DATA( A3DTopoSingleWireBodyData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DTopoBrepDataData( A3DTopoBrepDataData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DTopoBrepDataData ) ) {
        A3D_INITIALIZE_DATA( A3DTopoBrepDataData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DTopoConnexData( A3DTopoConnexData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DTopoConnexData ) ) {
        A3D_INITIALIZE_DATA( A3DTopoConnexData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DTopoShellData( A3DTopoShellData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DTopoShellData ) ) {
        A3D_INITIALIZE_DATA( A3DTopoShellData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DTopoFaceData( A3DTopoFaceData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DTopoFaceData ) ) {
        A3D_INITIALIZE_DATA( A3DTopoFaceData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DTopoLoopData( A3DTopoLoopData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DTopoLoopData ) ) {
        A3D_INITIALIZE_DATA( A3DTopoLoopData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DTopoCoEdgeData( A3DTopoCoEdgeData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DTopoCoEdgeData ) ) {
        A3D_INITIALIZE_DATA( A3DTopoCoEdgeData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DTopoEdgeData( A3DTopoEdgeData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DTopoEdgeData ) ) {
        A3D_INITIALIZE_DATA( A3DTopoEdgeData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DTopoWireEdgeData( A3DTopoWireEdgeData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DTopoWireEdgeData ) ) {
        A3D_INITIALIZE_DATA( A3DTopoWireEdgeData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DTopoUniqueVertexData( A3DTopoUniqueVertexData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DTopoUniqueVertexData ) ) {
        A3D_INITIALIZE_DATA( A3DTopoUniqueVertexData, (*ptr) );
        return true;
    }
    return false;
}

bool InitializeA3DTopoMultipleVertexData( A3DTopoMultipleVertexData *ptr ) {
    if( ptr && ptr->m_usStructSize == sizeof( A3DTopoMultipleVertexData ) ) {
        A3D_INITIALIZE_DATA( A3DTopoMultipleVertexData, (*ptr) );
        return true;
    }
    return false;
}

