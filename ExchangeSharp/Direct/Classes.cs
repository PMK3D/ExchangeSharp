using System;

namespace TS3D.Exchange.Direct
{
    public class A3DVector2dDataWrapper
    {
        public A3DVector2dDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DVector2dDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dX=>_d.m_dX;
        public double m_dY=>_d.m_dY;

        private A3DVector2dData _d;
    }
    public class A3DVector3dDataWrapper
    {
        public A3DVector3dDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DVector3dDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dX=>_d.m_dX;
        public double m_dY=>_d.m_dY;
        public double m_dZ=>_d.m_dZ;

        private A3DVector3dData _d;
    }
    public class A3DIntervalDataWrapper
    {
        public A3DIntervalDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DIntervalDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dMin=>_d.m_dMin;
        public double m_dMax=>_d.m_dMax;

        private A3DIntervalData _d;
    }
    public class A3DDomainDataWrapper
    {
        public A3DDomainDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DDomainDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DVector2dData m_sMin=>_d.m_sMin;
        public A3DVector2dData m_sMax=>_d.m_sMax;

        private A3DDomainData _d;
    }
    public class A3DBoundingBoxDataWrapper
    {
        public A3DBoundingBoxDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DBoundingBoxDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DVector3dData m_sMin=>_d.m_sMin;
        public A3DVector3dData m_sMax=>_d.m_sMax;

        private A3DBoundingBoxData _d;
    }
    public class A3DParameterizationDataWrapper
    {
        public A3DParameterizationDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DParameterizationDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DIntervalData m_sInterval=>_d.m_sInterval;
        public double m_dCoeffA=>_d.m_dCoeffA;
        public double m_dCoeffB=>_d.m_dCoeffB;

        private A3DParameterizationData _d;
    }
    public class A3DUVParameterizationDataWrapper
    {
        public A3DUVParameterizationDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DUVParameterizationDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DDomainData m_sUVDomain=>_d.m_sUVDomain;
        public bool m_bSwapUV => _d.m_bSwapUV;
        public double m_dUCoeffA=>_d.m_dUCoeffA;
        public double m_dVCoeffA=>_d.m_dVCoeffA;
        public double m_dUCoeffB=>_d.m_dUCoeffB;
        public double m_dVCoeffB=>_d.m_dVCoeffB;

        private A3DUVParameterizationData _d;
    }
    public class A3DTessBaseDataWrapper
    {
        public A3DTessBaseDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DTessBaseDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DTessBaseGet( p, ref _d );
            }
        }

        ~A3DTessBaseDataWrapper()
        {
            API.A3DTessBaseGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIsCalculated => _d.m_bIsCalculated;
        public uint m_uiCoordSize=>_d.m_uiCoordSize;
        public IntPtr m_pdCoords=>_d.m_pdCoords;

        private A3DTessBaseData _d;
    }
    public class A3DTessFaceDataWrapper
    {
        public A3DTessFaceDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DTessFaceDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiStyleIndexesSize=>_d.m_uiStyleIndexesSize;
        public IntPtr m_puiStyleIndexes=>_d.m_puiStyleIndexes;
        public uint m_uiStartWire=>_d.m_uiStartWire;
        public uint m_uiSizesWiresSize=>_d.m_uiSizesWiresSize;
        public IntPtr m_puiSizesWires=>_d.m_puiSizesWires;
        public ushort m_usUsedEntitiesFlags=>_d.m_usUsedEntitiesFlags;
        public uint m_uiStartTriangulated=>_d.m_uiStartTriangulated;
        public uint m_uiSizesTriangulatedSize=>_d.m_uiSizesTriangulatedSize;
        public IntPtr m_puiSizesTriangulated=>_d.m_puiSizesTriangulated;
        public bool m_bIsRGBA => _d.m_bIsRGBA;
        public uint m_uiRGBAVerticesSize=>_d.m_uiRGBAVerticesSize;
        public IntPtr m_pucRGBAVertices=>_d.m_pucRGBAVertices;
        public ushort m_usBehaviour=>_d.m_usBehaviour;
        public uint m_uiTextureCoordIndexesSize=>_d.m_uiTextureCoordIndexesSize;

        private A3DTessFaceData _d;
    }
    public class A3DTess3DDataWrapper
    {
        public A3DTess3DDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DTess3DDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DTess3DGet( p, ref _d );
            }
        }

        ~A3DTess3DDataWrapper()
        {
            API.A3DTess3DGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_bHasFaces=>_d.m_bHasFaces;
        public uint m_uiNormalSize=>_d.m_uiNormalSize;
        public IntPtr m_pdNormals=>_d.m_pdNormals;
        public uint m_uiWireIndexSize=>_d.m_uiWireIndexSize;
        public IntPtr m_puiWireIndexes=>_d.m_puiWireIndexes;
        public uint m_uiTriangulatedIndexSize=>_d.m_uiTriangulatedIndexSize;
        public IntPtr m_puiTriangulatedIndexes=>_d.m_puiTriangulatedIndexes;
        public uint m_uiFaceTessSize=>_d.m_uiFaceTessSize;
        public IntPtr m_psFaceTessData=>_d.m_psFaceTessData;
        public uint m_uiTextureCoordSize=>_d.m_uiTextureCoordSize;
        public IntPtr m_pdTextureCoords=>_d.m_pdTextureCoords;
        public bool m_bMustRecalculateNormals => _d.m_bMustRecalculateNormals;
        public byte m_ucNormalsRecalculationFlags=>_d.m_ucNormalsRecalculationFlags;
        public double m_dCreaseAngle=>_d.m_dCreaseAngle;

        private A3DTess3DData _d;
    }
    public class A3DTess3DWireDataWrapper
    {
        public A3DTess3DWireDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DTess3DWireDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DTess3DWireGet( p, ref _d );
            }
        }

        ~A3DTess3DWireDataWrapper()
        {
            API.A3DTess3DWireGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiSizesWiresSize=>_d.m_uiSizesWiresSize;
        public IntPtr m_puiSizesWires=>_d.m_puiSizesWires;
        public bool m_bIsRGBA => _d.m_bIsRGBA;
        public bool m_bIsSegmentColor => _d.m_bIsSegmentColor;
        public uint m_uiRGBAVerticesSize=>_d.m_uiRGBAVerticesSize;
        public IntPtr m_pucRGBAVertices=>_d.m_pucRGBAVertices;

        private A3DTess3DWireData _d;
    }
    public class A3DTessMarkupDataWrapper
    {
        public A3DTessMarkupDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DTessMarkupDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DTessMarkupGet( p, ref _d );
            }
        }

        ~A3DTessMarkupDataWrapper()
        {
            API.A3DTessMarkupGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiCodesSize=>_d.m_uiCodesSize;
        public IntPtr m_puiCodes=>_d.m_puiCodes;
        public uint m_uiTextsSize=>_d.m_uiTextsSize;
        public IntPtr m_ppcTexts=>_d.m_ppcTexts;
        public string m_pcLabel => _d.m_pcLabel;
        public byte m_cBehaviour=>_d.m_cBehaviour;

        private A3DTessMarkupData _d;
    }
    public class A3DGraphicsDataWrapper
    {
        public A3DGraphicsDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DGraphicsDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DGraphicsGet( p, ref _d );
            }
        }

        ~A3DGraphicsDataWrapper()
        {
            API.A3DGraphicsGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiLayerIndex=>_d.m_uiLayerIndex;
        public uint m_uiStyleIndex=>_d.m_uiStyleIndex;
        public ushort m_usBehaviour=>_d.m_usBehaviour;

        private A3DGraphicsData _d;
    }
    public class A3DGraphStyleDataWrapper
    {
        public A3DGraphStyleDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DGraphStyleDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dWidth=>_d.m_dWidth;
        public bool m_bVPicture => _d.m_bVPicture;
        public uint m_uiLinePatternIndex=>_d.m_uiLinePatternIndex;
        public bool m_bMaterial => _d.m_bMaterial;
        public uint m_uiRgbColorIndex=>_d.m_uiRgbColorIndex;
        public bool m_bIsTransparencyDefined => _d.m_bIsTransparencyDefined;
        public byte m_ucTransparency=>_d.m_ucTransparency;
        public bool m_bSpecialCulling => _d.m_bSpecialCulling;
        public bool m_bFrontCulling => _d.m_bFrontCulling;
        public bool m_bBackCulling => _d.m_bBackCulling;
        public bool m_bNoLight => _d.m_bNoLight;
        public A3DERenderingMode m_eRenderingMode=>_d.m_eRenderingMode;

        private A3DGraphStyleData _d;
    }
    public class A3DGraphRgbColorDataWrapper
    {
        public A3DGraphRgbColorDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DGraphRgbColorDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dRed=>_d.m_dRed;
        public double m_dGreen=>_d.m_dGreen;
        public double m_dBlue=>_d.m_dBlue;

        private A3DGraphRgbColorData _d;
    }
    public class A3DGraphLinePatternDataWrapper
    {
        public A3DGraphLinePatternDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DGraphLinePatternDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiNumberOfLengths=>_d.m_uiNumberOfLengths;
        public IntPtr m_pdLengths=>_d.m_pdLengths;
        public double m_dPhase=>_d.m_dPhase;
        public bool m_bRealLength => _d.m_bRealLength;

        private A3DGraphLinePatternData _d;
    }
    public class A3DGraphMaterialDataWrapper
    {
        public A3DGraphMaterialDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DGraphMaterialDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiAmbient=>_d.m_uiAmbient;
        public uint m_uiDiffuse=>_d.m_uiDiffuse;
        public uint m_uiEmissive=>_d.m_uiEmissive;
        public uint m_uiSpecular=>_d.m_uiSpecular;
        public double m_dAmbientAlpha=>_d.m_dAmbientAlpha;
        public double m_dDiffuseAlpha=>_d.m_dDiffuseAlpha;
        public double m_dEmissiveAlpha=>_d.m_dEmissiveAlpha;
        public double m_dSpecularAlpha=>_d.m_dSpecularAlpha;
        public double m_dShininess=>_d.m_dShininess;

        private A3DGraphMaterialData _d;
    }
    public class A3DGraphPictureDataWrapper
    {
        public A3DGraphPictureDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DGraphPictureDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DEPictureDataFormat m_eFormat=>_d.m_eFormat;
        public uint m_uiSize=>_d.m_uiSize;
        public IntPtr m_pucBinaryData=>_d.m_pucBinaryData;
        public uint m_uiPixelWidth=>_d.m_uiPixelWidth;
        public uint m_uiPixelHeight=>_d.m_uiPixelHeight;

        private A3DGraphPictureData _d;
    }
    public class A3DGraphDottingPatternDataWrapper
    {
        public A3DGraphDottingPatternDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DGraphDottingPatternDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dPitch=>_d.m_dPitch;
        public bool m_bZigZag => _d.m_bZigZag;
        public uint m_uiColorIndex=>_d.m_uiColorIndex;
        public uint m_uiNextPatternIndex=>_d.m_uiNextPatternIndex;

        private A3DGraphDottingPatternData _d;
    }
    public class A3DGraphHatchingPatternLineDataWrapper
    {
        public A3DGraphHatchingPatternLineDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DGraphHatchingPatternLineDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DVector2dData m_sStart=>_d.m_sStart;
        public A3DVector2dData m_sOffset=>_d.m_sOffset;
        public double m_dAngle=>_d.m_dAngle;
        public uint m_uiStyleIndex=>_d.m_uiStyleIndex;

        private A3DGraphHatchingPatternLineData _d;
    }
    public class A3DGraphHatchingPatternDataWrapper
    {
        public A3DGraphHatchingPatternDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DGraphHatchingPatternDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiSize=>_d.m_uiSize;
        public IntPtr m_psHatchLines=>_d.m_psHatchLines;
        public uint m_uiNextPatternIndex=>_d.m_uiNextPatternIndex;

        private A3DGraphHatchingPatternData _d;
    }
    public class A3DGraphSolidPatternDataWrapper
    {
        public A3DGraphSolidPatternDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DGraphSolidPatternDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bMaterial => _d.m_bMaterial;
        public uint m_uiRgbColorIndex=>_d.m_uiRgbColorIndex;
        public uint m_uiNextPatternIndex=>_d.m_uiNextPatternIndex;

        private A3DGraphSolidPatternData _d;
    }
    public class A3DGraphVPicturePatternDataWrapper
    {
        public A3DGraphVPicturePatternDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DGraphVPicturePatternDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiNextPatternIndex=>_d.m_uiNextPatternIndex;
        public IntPtr m_pMarkupTess=>_d.m_pMarkupTess;

        private A3DGraphVPicturePatternData _d;
    }
    public class A3DGraphCameraDataWrapper
    {
        public A3DGraphCameraDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DGraphCameraDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DGraphCameraGet( p, ref _d );
            }
        }

        ~A3DGraphCameraDataWrapper()
        {
            API.A3DGraphCameraGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bOrthographic => _d.m_bOrthographic;
        public A3DVector3dData m_sLocation=>_d.m_sLocation;
        public A3DVector3dData m_sLookAt=>_d.m_sLookAt;
        public A3DVector3dData m_sUp=>_d.m_sUp;
        public double m_dXFovy=>_d.m_dXFovy;
        public double m_dYFovy=>_d.m_dYFovy;
        public double m_dAspectRatio=>_d.m_dAspectRatio;
        public double m_dZNear=>_d.m_dZNear;
        public double m_dZFar=>_d.m_dZFar;
        public double m_dZoomFactor=>_d.m_dZoomFactor;

        private A3DGraphCameraData _d;
    }
    public class A3DGraphAmbientLightDataWrapper
    {
        public A3DGraphAmbientLightDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DGraphAmbientLightDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DGraphAmbientLightGet( p, ref _d );
            }
        }

        ~A3DGraphAmbientLightDataWrapper()
        {
            API.A3DGraphAmbientLightGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiAmbientColorIndex=>_d.m_uiAmbientColorIndex;
        public uint m_uiDiffuseColorIndex=>_d.m_uiDiffuseColorIndex;
        public uint m_uiSpecularColorIndex=>_d.m_uiSpecularColorIndex;

        private A3DGraphAmbientLightData _d;
    }
    public class A3DGraphPointLightDataWrapper
    {
        public A3DGraphPointLightDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DGraphPointLightDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DGraphPointLightGet( p, ref _d );
            }
        }

        ~A3DGraphPointLightDataWrapper()
        {
            API.A3DGraphPointLightGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiAmbientColorIndex=>_d.m_uiAmbientColorIndex;
        public uint m_uiDiffuseColorIndex=>_d.m_uiDiffuseColorIndex;
        public uint m_uiSpecularColorIndex=>_d.m_uiSpecularColorIndex;
        public A3DVector3dData m_sLocation=>_d.m_sLocation;
        public double m_dConstantAttenuation=>_d.m_dConstantAttenuation;
        public double m_dLinearAttenuation=>_d.m_dLinearAttenuation;
        public double m_dQuadraticAttenuation=>_d.m_dQuadraticAttenuation;

        private A3DGraphPointLightData _d;
    }
    public class A3DGraphSpotLightDataWrapper
    {
        public A3DGraphSpotLightDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DGraphSpotLightDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DGraphSpotLightGet( p, ref _d );
            }
        }

        ~A3DGraphSpotLightDataWrapper()
        {
            API.A3DGraphSpotLightGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiAmbientColorIndex=>_d.m_uiAmbientColorIndex;
        public uint m_uiDiffuseColorIndex=>_d.m_uiDiffuseColorIndex;
        public uint m_uiSpecularColorIndex=>_d.m_uiSpecularColorIndex;
        public A3DVector3dData m_sDirection=>_d.m_sDirection;
        public double m_dFallOffAngle=>_d.m_dFallOffAngle;
        public double m_dFallOffExponent=>_d.m_dFallOffExponent;
        public A3DVector3dData m_sLocation=>_d.m_sLocation;
        public double m_dConstantAttenuation=>_d.m_dConstantAttenuation;
        public double m_dLinearAttenuation=>_d.m_dLinearAttenuation;
        public double m_dQuadraticAttenuation=>_d.m_dQuadraticAttenuation;

        private A3DGraphSpotLightData _d;
    }
    public class A3DGraphDirectionalLightDataWrapper
    {
        public A3DGraphDirectionalLightDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DGraphDirectionalLightDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DGraphDirectionalLightGet( p, ref _d );
            }
        }

        ~A3DGraphDirectionalLightDataWrapper()
        {
            API.A3DGraphDirectionalLightGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiAmbientColorIndex=>_d.m_uiAmbientColorIndex;
        public uint m_uiDiffuseColorIndex=>_d.m_uiDiffuseColorIndex;
        public uint m_uiSpecularColorIndex=>_d.m_uiSpecularColorIndex;
        public double m_dIntensity=>_d.m_dIntensity;
        public A3DVector3dData m_sDirection=>_d.m_sDirection;

        private A3DGraphDirectionalLightData _d;
    }
    public class A3DGraphSceneDisplayParametersDataWrapper
    {
        public A3DGraphSceneDisplayParametersDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DGraphSceneDisplayParametersDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DGraphSceneDisplayParametersGet( p, ref _d );
            }
        }

        ~A3DGraphSceneDisplayParametersDataWrapper()
        {
            API.A3DGraphSceneDisplayParametersGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIsActive => _d.m_bIsActive;
        public IntPtr m_pCamera=>_d.m_pCamera;
        public uint m_uiLightSize=>_d.m_uiLightSize;
        public IntPtr m_ppLights=>_d.m_ppLights;
        public uint m_uiPlaneSize=>_d.m_uiPlaneSize;
        public IntPtr m_ppClippingPlanes=>_d.m_ppClippingPlanes;
        public bool m_bHasRotationCenter => _d.m_bHasRotationCenter;
        public A3DVector3dData m_sRotationCenter=>_d.m_sRotationCenter;
        public uint m_uiBackgroundStyleIndex=>_d.m_uiBackgroundStyleIndex;
        public uint m_uiDefaultStyleIndex=>_d.m_uiDefaultStyleIndex;
        public uint m_uiDefaultPerTypeIndexSize=>_d.m_uiDefaultPerTypeIndexSize;
        public IntPtr m_puiDefaultStyleIndexesPerType=>_d.m_puiDefaultStyleIndexesPerType;
        public IntPtr m_puiTypesOfDefaultStyleIndexes=>_d.m_puiTypesOfDefaultStyleIndexes;

        private A3DGraphSceneDisplayParametersData _d;
    }
    public class A3DMiscCascadedAttributesDataWrapper
    {
        public A3DMiscCascadedAttributesDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMiscCascadedAttributesDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMiscCascadedAttributesGet( p, ref _d );
            }
        }

        ~A3DMiscCascadedAttributesDataWrapper()
        {
            API.A3DMiscCascadedAttributesGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bShow => _d.m_bShow;
        public bool m_bRemoved => _d.m_bRemoved;
        public ushort m_usLayer=>_d.m_usLayer;
        public A3DGraphStyleData m_sStyle=>_d.m_sStyle;
        public IntPtr m_pCoordinateSystem=>_d.m_pCoordinateSystem;

        private A3DMiscCascadedAttributesData _d;
    }
    public class A3DMiscGeneralTransformationDataWrapper
    {
        public A3DMiscGeneralTransformationDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMiscGeneralTransformationDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMiscGeneralTransformationGet( p, ref _d );
            }
        }

        ~A3DMiscGeneralTransformationDataWrapper()
        {
            API.A3DMiscGeneralTransformationGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double[] m_adCoeff {
            get {
                var result = new double[16];
                for( var idx = 0; idx < 16; ++idx ) unsafe {
                    result[idx] = _d.m_adCoeff[idx];
                }
                return result;
            }
        }

        private A3DMiscGeneralTransformationData _d;
    }
    public class A3DMiscCartesianTransformationDataWrapper
    {
        public A3DMiscCartesianTransformationDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMiscCartesianTransformationDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMiscCartesianTransformationGet( p, ref _d );
            }
        }

        ~A3DMiscCartesianTransformationDataWrapper()
        {
            API.A3DMiscCartesianTransformationGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DVector3dData m_sOrigin=>_d.m_sOrigin;
        public A3DVector3dData m_sXVector=>_d.m_sXVector;
        public A3DVector3dData m_sYVector=>_d.m_sYVector;
        public A3DVector3dData m_sScale=>_d.m_sScale;
        public byte m_ucBehaviour=>_d.m_ucBehaviour;

        private A3DMiscCartesianTransformationData _d;
    }
    public class A3DMiscEntityReferenceDataWrapper
    {
        public A3DMiscEntityReferenceDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMiscEntityReferenceDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMiscEntityReferenceGet( p, ref _d );
            }
        }

        ~A3DMiscEntityReferenceDataWrapper()
        {
            API.A3DMiscEntityReferenceGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pEntity=>_d.m_pEntity;
        public IntPtr m_pCoordinateSystem=>_d.m_pCoordinateSystem;

        private A3DMiscEntityReferenceData _d;
    }
    public class A3DMiscReferenceOnTopologyDataWrapper
    {
        public A3DMiscReferenceOnTopologyDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMiscReferenceOnTopologyDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMiscReferenceOnTopologyGet( p, ref _d );
            }
        }

        ~A3DMiscReferenceOnTopologyDataWrapper()
        {
            API.A3DMiscReferenceOnTopologyGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DEEntityType m_eTopoItemType=>_d.m_eTopoItemType;
        public IntPtr m_pBrepData=>_d.m_pBrepData;
        public uint m_uiSize=>_d.m_uiSize;
        public IntPtr m_puiAdditionalIndexes=>_d.m_puiAdditionalIndexes;

        private A3DMiscReferenceOnTopologyData _d;
    }
    public class A3DMiscReferenceOnTessDataWrapper
    {
        public A3DMiscReferenceOnTessDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMiscReferenceOnTessDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMiscReferenceOnTessGet( p, ref _d );
            }
        }

        ~A3DMiscReferenceOnTessDataWrapper()
        {
            API.A3DMiscReferenceOnTessGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DEEntityType m_eTopoItemType=>_d.m_eTopoItemType;
        public IntPtr m_pPolyBrepModel=>_d.m_pPolyBrepModel;
        public uint m_uiSize=>_d.m_uiSize;
        public IntPtr m_puiAdditionalIndexes=>_d.m_puiAdditionalIndexes;
        public IntPtr m_pTargetProductOccurrence=>_d.m_pTargetProductOccurrence;

        private A3DMiscReferenceOnTessData _d;
    }
    public class A3DMiscReferenceOnCsysItemDataWrapper
    {
        public A3DMiscReferenceOnCsysItemDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMiscReferenceOnCsysItemDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMiscReferenceOnCsysItemGet( p, ref _d );
            }
        }

        ~A3DMiscReferenceOnCsysItemDataWrapper()
        {
            API.A3DMiscReferenceOnCsysItemGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pCoordinateSystem=>_d.m_pCoordinateSystem;
        public ushort m_uiIndex=>_d.m_uiIndex;

        private A3DMiscReferenceOnCsysItemData _d;
    }
    public class A3DMiscPhysicMaterialDataWrapper
    {
        public A3DMiscPhysicMaterialDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DMiscPhysicMaterialDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dDensity=>_d.m_dDensity;

        private A3DMiscPhysicMaterialData _d;
    }
    public class A3DMiscMaterialFiberDataWrapper
    {
        public A3DMiscMaterialFiberDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DMiscMaterialFiberDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dYoungModulus_X=>_d.m_dYoungModulus_X;
        public double m_dYoungModulus_Y=>_d.m_dYoungModulus_Y;
        public double m_dPoissonRatio_XY=>_d.m_dPoissonRatio_XY;
        public double m_dShearModulus_XY=>_d.m_dShearModulus_XY;
        public double m_dShearModulus_YZ=>_d.m_dShearModulus_YZ;
        public double m_dThermalExpansion_X=>_d.m_dThermalExpansion_X;
        public double m_dThermalExpansion_Y=>_d.m_dThermalExpansion_Y;
        public double m_dTensileStressLimit_X=>_d.m_dTensileStressLimit_X;
        public double m_dCompressiveStressLimit_X=>_d.m_dCompressiveStressLimit_X;
        public double m_dTensileStressLimit_Y=>_d.m_dTensileStressLimit_Y;
        public double m_dCompressiveStressLimit_Y=>_d.m_dCompressiveStressLimit_Y;
        public double m_dShearStressLimit_XY=>_d.m_dShearStressLimit_XY;
        public double m_dShearStressLimit_YZ=>_d.m_dShearStressLimit_YZ;

        private A3DMiscMaterialFiberData _d;
    }
    public class A3DMiscMaterialHoneyCombDataWrapper
    {
        public A3DMiscMaterialHoneyCombDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DMiscMaterialHoneyCombDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dYoungModulus=>_d.m_dYoungModulus;
        public double m_dShearModulus_XZ=>_d.m_dShearModulus_XZ;
        public double m_dShearModulus_YZ=>_d.m_dShearModulus_YZ;
        public double m_dShearStressLimit_XZ=>_d.m_dShearStressLimit_XZ;
        public double m_dShearStressLimit_YZ=>_d.m_dShearStressLimit_YZ;
        public double m_dThermalExpansion=>_d.m_dThermalExpansion;

        private A3DMiscMaterialHoneyCombData _d;
    }
    public class A3DMiscMaterialIsotropicDataWrapper
    {
        public A3DMiscMaterialIsotropicDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DMiscMaterialIsotropicDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dYoungModulus=>_d.m_dYoungModulus;
        public double m_dPoissonRatio=>_d.m_dPoissonRatio;
        public double m_dShearModulus=>_d.m_dShearModulus;
        public double m_dThermalExpansion=>_d.m_dThermalExpansion;

        private A3DMiscMaterialIsotropicData _d;
    }
    public class A3DMiscMaterialOrthotropic2DDataWrapper
    {
        public A3DMiscMaterialOrthotropic2DDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DMiscMaterialOrthotropic2DDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dYoungModulus_X=>_d.m_dYoungModulus_X;
        public double m_dYoungModulus_Y=>_d.m_dYoungModulus_Y;
        public double m_dPoissonRatio_XY=>_d.m_dPoissonRatio_XY;
        public double m_dShearModulus_XY=>_d.m_dShearModulus_XY;
        public double m_dShearModulus_XZ=>_d.m_dShearModulus_XZ;
        public double m_dShearModulus_YZ=>_d.m_dShearModulus_YZ;
        public double m_dTensileStressLimit_X=>_d.m_dTensileStressLimit_X;
        public double m_dCompressiveStressLimit_X=>_d.m_dCompressiveStressLimit_X;
        public double m_dTensileStressLimit_Y=>_d.m_dTensileStressLimit_Y;
        public double m_dCompressiveStressLimit_Y=>_d.m_dCompressiveStressLimit_Y;
        public double m_dThermalExpansion_X=>_d.m_dThermalExpansion_X;
        public double m_dThermalExpansion_Y=>_d.m_dThermalExpansion_Y;
        public double m_dTensileStrainLimit_X=>_d.m_dTensileStrainLimit_X;
        public double m_dCompressiveStrainLimit_X=>_d.m_dCompressiveStrainLimit_X;
        public double m_dTensileStrainLimit_Y=>_d.m_dTensileStrainLimit_Y;
        public double m_dCompressiveStrainLimit_Y=>_d.m_dCompressiveStrainLimit_Y;
        public double m_dShearStressLimit_XY=>_d.m_dShearStressLimit_XY;

        private A3DMiscMaterialOrthotropic2DData _d;
    }
    public class A3DMiscMaterialOrthotropic3DDataWrapper
    {
        public A3DMiscMaterialOrthotropic3DDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DMiscMaterialOrthotropic3DDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dYoungModulus_X=>_d.m_dYoungModulus_X;
        public double m_dYoungModulus_Y=>_d.m_dYoungModulus_Y;
        public double m_dYoungModulus_Z=>_d.m_dYoungModulus_Z;
        public double m_dPoissonRatio_XY=>_d.m_dPoissonRatio_XY;
        public double m_dPoissonRatio_XZ=>_d.m_dPoissonRatio_XZ;
        public double m_dPoissonRatio_YZ=>_d.m_dPoissonRatio_YZ;
        public double m_dShearModulus_XY=>_d.m_dShearModulus_XY;
        public double m_dShearModulus_XZ=>_d.m_dShearModulus_XZ;
        public double m_dShearModulus_YZ=>_d.m_dShearModulus_YZ;
        public double m_dThermalExpansion_X=>_d.m_dThermalExpansion_X;
        public double m_dThermalExpansion_Y=>_d.m_dThermalExpansion_Y;
        public double m_dThermalExpansion_Z=>_d.m_dThermalExpansion_Z;
        public double m_dTensileStressLimit_X=>_d.m_dTensileStressLimit_X;
        public double m_dCompressiveStressLimit_X=>_d.m_dCompressiveStressLimit_X;
        public double m_dTensileStressLimit_Y=>_d.m_dTensileStressLimit_Y;
        public double m_dCompressiveStressLimit_Y=>_d.m_dCompressiveStressLimit_Y;
        public double m_dShearStressLimit_XY=>_d.m_dShearStressLimit_XY;
        public double m_dShearStressLimit_XZ=>_d.m_dShearStressLimit_XZ;
        public double m_dShearStressLimit_YZ=>_d.m_dShearStressLimit_YZ;

        private A3DMiscMaterialOrthotropic3DData _d;
    }
    public class A3DMiscMaterialAnisotropicDataWrapper
    {
        public A3DMiscMaterialAnisotropicDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DMiscMaterialAnisotropicDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dShearModulus_XX=>_d.m_dShearModulus_XX;
        public double m_dShearModulus_XY=>_d.m_dShearModulus_XY;
        public double m_dShearModulus_XZ=>_d.m_dShearModulus_XZ;
        public double m_dShearModulus_YY=>_d.m_dShearModulus_YY;
        public double m_dShearModulus_YZ=>_d.m_dShearModulus_YZ;
        public double m_dShearModulus_ZZ=>_d.m_dShearModulus_ZZ;
        public double m_dThermalExpansion_X=>_d.m_dThermalExpansion_X;
        public double m_dThermalExpansion_Y=>_d.m_dThermalExpansion_Y;
        public double m_dThermalExpansion_Z=>_d.m_dThermalExpansion_Z;
        public double m_dTensileStressLimit=>_d.m_dTensileStressLimit;
        public double m_dCompressiveStressLimit=>_d.m_dCompressiveStressLimit;
        public double m_dShearStressLimit=>_d.m_dShearStressLimit;

        private A3DMiscMaterialAnisotropicData _d;
    }
    public class A3DMiscMaterialPropertiesDataWrapper
    {
        public A3DMiscMaterialPropertiesDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DMiscMaterialPropertiesDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dDensity=>_d.m_dDensity;
        public string m_pcMaterialName => _d.m_pcMaterialName;
        public A3DMaterialPhysicType m_ePhysicType=>_d.m_ePhysicType;
        public A3DMiscMaterialFiberData m_sFiber => _d.m_sFiber;
        public A3DMiscMaterialHoneyCombData m_sHoneyComb => _d.m_sHoneyComb;
        public A3DMiscMaterialIsotropicData m_sIsotropic => _d.m_sIsotropic;
        public A3DMiscMaterialOrthotropic2DData m_sOrthotropic2D => _d.m_sOrthotropic2D;
        public A3DMiscMaterialOrthotropic3DData m_sOrthotropic3D => _d.m_sOrthotropic3D;
        public A3DMiscMaterialAnisotropicData m_sAnisotropic => _d.m_sAnisotropic;

        private A3DMiscMaterialPropertiesData _d;
    }
    public class A3DAsmModelFileDataWrapper
    {
        public A3DAsmModelFileDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DAsmModelFileDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DAsmModelFileGet( p, ref _d );
            }
        }

        ~A3DAsmModelFileDataWrapper()
        {
            API.A3DAsmModelFileGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DEModellerType m_eModellerType=>_d.m_eModellerType;
        public bool m_bUnitFromCAD => _d.m_bUnitFromCAD;
        public double m_dUnit=>_d.m_dUnit;
        public uint m_uiPOccurrencesSize=>_d.m_uiPOccurrencesSize;
        public IntPtr m_ppPOccurrences=>_d.m_ppPOccurrences;

        private A3DAsmModelFileData _d;
    }
    public class A3DAsmProductOccurrenceDataWrapper
    {
        public A3DAsmProductOccurrenceDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DAsmProductOccurrenceDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DAsmProductOccurrenceGet( p, ref _d );
            }
        }

        ~A3DAsmProductOccurrenceDataWrapper()
        {
            API.A3DAsmProductOccurrenceGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiPOccurrencesSize=>_d.m_uiPOccurrencesSize;
        public IntPtr m_ppPOccurrences=>_d.m_ppPOccurrences;
        public IntPtr m_pPart=>_d.m_pPart;
        public IntPtr m_pPrototype=>_d.m_pPrototype;
        public IntPtr m_pExternalData=>_d.m_pExternalData;
        public byte m_ucBehaviour=>_d.m_ucBehaviour;
        public IntPtr m_pLocation=>_d.m_pLocation;
        public uint m_uiEntityReferenceSize=>_d.m_uiEntityReferenceSize;
        public IntPtr m_ppEntityReferences=>_d.m_ppEntityReferences;
        public uint m_uiAnnotationsSize=>_d.m_uiAnnotationsSize;
        public IntPtr m_ppAnnotations=>_d.m_ppAnnotations;
        public uint m_uiViewsSize=>_d.m_uiViewsSize;
        public IntPtr m_ppViews=>_d.m_ppViews;
        public IntPtr m_pEntityFilter=>_d.m_pEntityFilter;
        public uint m_uiDisplayFilterSize=>_d.m_uiDisplayFilterSize;
        public IntPtr m_ppDisplayFilters=>_d.m_ppDisplayFilters;
        public uint m_uiSceneDisplayParameterSize=>_d.m_uiSceneDisplayParameterSize;
        public IntPtr m_psSceneDisplayParameters=>_d.m_psSceneDisplayParameters;
        public A3DEProductLoadStatus m_eProductLoadStatus=>_d.m_eProductLoadStatus;
        public uint m_uiProductFlags=>_d.m_uiProductFlags;
        public bool m_bUnitFromCAD => _d.m_bUnitFromCAD;
        public double m_dUnit=>_d.m_dUnit;
        public double m_dDensityVolumeUnit=>_d.m_dDensityVolumeUnit;
        public double m_dDensityMassUnit=>_d.m_dDensityMassUnit;
        public A3DEModellerType m_eModellerType=>_d.m_eModellerType;
        public bool m_bInactivateAnnotations => _d.m_bInactivateAnnotations;
        public uint m_uiMaterialAndVisualisationSetupSize=>_d.m_uiMaterialAndVisualisationSetupSize;
        public IntPtr m_psMaterialAndVisualisationSetup=>_d.m_psMaterialAndVisualisationSetup;
        public uint m_uiCameraSize=>_d.m_uiCameraSize;
        public IntPtr m_ppCamera=>_d.m_ppCamera;
        public uint m_uiFeatureBasedEntitiesSize=>_d.m_uiFeatureBasedEntitiesSize;
        public IntPtr m_ppFeatureBasedEntities=>_d.m_ppFeatureBasedEntities;

        private A3DAsmProductOccurrenceData _d;
    }
    public class A3DAsmProductOccurrenceDataSLWWrapper
    {
        public A3DAsmProductOccurrenceDataSLWWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DAsmProductOccurrenceDataSLWWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_psNodeSlwID => _d.m_psNodeSlwID;
        public int m_iIndexCfg=>_d.m_iIndexCfg;
        public string m_psCfgName => _d.m_psCfgName;
        public A3DEProductOccurrenceTypeSLW m_usType=>_d.m_usType;
        public uint m_uiAttachementsSize=>_d.m_uiAttachementsSize;
        public IntPtr m_psAttachements=>_d.m_psAttachements;

        private A3DAsmProductOccurrenceDataSLW _d;
    }
    public class A3DAsmProductOccurrenceDataCatWrapper
    {
        public A3DAsmProductOccurrenceDataCatWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DAsmProductOccurrenceDataCatWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DEProductOccurrenceTypeCat m_eCatiaFileType=>_d.m_eCatiaFileType;
        public int m_iModelNumber=>_d.m_iModelNumber;
        public uint m_uiIdWorkspace=>_d.m_uiIdWorkspace;
        public int m_iTypeWorkspace=>_d.m_iTypeWorkspace;
        public string m_psModelName => _d.m_psModelName;
        public string m_psUser => _d.m_psUser;
        public string m_psDatm => _d.m_psDatm;
        public string m_psTimem => _d.m_psTimem;
        public string m_psVersion => _d.m_psVersion;
        public string m_psRelease => _d.m_psRelease;

        private A3DAsmProductOccurrenceDataCat _d;
    }
    public class A3DAsmProductOccurrenceDataCV5Wrapper
    {
        public A3DAsmProductOccurrenceDataCV5Wrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DAsmProductOccurrenceDataCV5Wrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_psRootFilePath => _d.m_psRootFilePath;
        public int m_iRootModificationTime=>_d.m_iRootModificationTime;
        public int m_iRootUpdateIndex=>_d.m_iRootUpdateIndex;
        public int m_iCurrentAsmProductIdentifier=>_d.m_iCurrentAsmProductIdentifier;
        public int m_iNotUpdatedAsmProductIdentifier=>_d.m_iNotUpdatedAsmProductIdentifier;
        public int[] m_aiCLSID {
            get {
                var result = new int[4];
                for( var idx = 0; idx < 4; ++idx ) unsafe {
                    result[idx] = _d.m_aiCLSID[idx];
                }
                return result;
            }
        }
        public bool m_bProductInError => _d.m_bProductInError;
        public bool m_bHasCGMInformation => _d.m_bHasCGMInformation;
        public bool m_bFromCATPart => _d.m_bFromCATPart;
        public string m_psVersion => _d.m_psVersion;
        public string m_psPartNumber => _d.m_psPartNumber;

        private A3DAsmProductOccurrenceDataCV5 _d;
    }
    public class A3DAsmProductOccurrenceDataUgWrapper
    {
        public A3DAsmProductOccurrenceDataUgWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DAsmProductOccurrenceDataUgWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_psRootFilePath => _d.m_psRootFilePath;
        public string m_psFileName => _d.m_psFileName;
        public string m_psInstanceFileName => _d.m_psInstanceFileName;
        public string m_psRefSet => _d.m_psRefSet;
        public string m_psPartUID => _d.m_psPartUID;
        public uint m_uiInstanceTag=>_d.m_uiInstanceTag;
        public uint m_uiPromotedBodiesSize=>_d.m_uiPromotedBodiesSize;
        public IntPtr m_asPromotedBodies=>_d.m_asPromotedBodies;
        public uint m_uiChildrenByRefsetsSize=>_d.m_uiChildrenByRefsetsSize;
        public IntPtr m_asChildrenByRefsets=>_d.m_asChildrenByRefsets;
        public uint m_uiSolidsByRefsetsSize=>_d.m_uiSolidsByRefsetsSize;
        public IntPtr m_asSolidsByRefsets=>_d.m_asSolidsByRefsets;

        private A3DAsmProductOccurrenceDataUg _d;
    }
    public class A3DAsmProductOccurrenceDataProeWrapper
    {
        public A3DAsmProductOccurrenceDataProeWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DAsmProductOccurrenceDataProeWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dAccuracy=>_d.m_dAccuracy;
        public string m_sPartName => _d.m_sPartName;
        public int m_iProEMemberType=>_d.m_iProEMemberType;
        public int m_iProEMemberId=>_d.m_iProEMemberId;
        public bool m_bXprOrXas => _d.m_bXprOrXas;
        public bool m_bHasFamilyTable => _d.m_bHasFamilyTable;
        public bool m_bHasBooleanOperation => _d.m_bHasBooleanOperation;
        public bool m_bHasFlexibleComponent => _d.m_bHasFlexibleComponent;
        public IntPtr m_pDefaultExplodePosition=>_d.m_pDefaultExplodePosition;
        public uint m_uiExplodedProductsSize=>_d.m_uiExplodedProductsSize;
        public IntPtr m_ppExplodedProducts=>_d.m_ppExplodedProducts;

        private A3DAsmProductOccurrenceDataProe _d;
    }
    public class A3DAsmProductOccurrenceDataInvWrapper
    {
        public A3DAsmProductOccurrenceDataInvWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DAsmProductOccurrenceDataInvWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DEProductOccurrenceTypeInv m_eType=>_d.m_eType;
        public int[] m_aiCLSID {
            get {
                var result = new int[4];
                for( var idx = 0; idx < 4; ++idx ) unsafe {
                    result[idx] = _d.m_aiCLSID[idx];
                }
                return result;
            }
        }
        public int m_iNodeID=>_d.m_iNodeID;
        public uint m_uiOccurrenceIDsSize=>_d.m_uiOccurrenceIDsSize;
        public IntPtr m_aiOccurrenceIDs=>_d.m_aiOccurrenceIDs;
        public uint m_uiFlexibleOccurrenceIDsSize=>_d.m_uiFlexibleOccurrenceIDsSize;
        public IntPtr m_aiFlexibleOccurrenceIDs=>_d.m_aiFlexibleOccurrenceIDs;
        public bool m_bIsSubstituted => _d.m_bIsSubstituted;

        private A3DAsmProductOccurrenceDataInv _d;
    }
    public class A3DAsmProductOccurrenceDataJTWrapper
    {
        public A3DAsmProductOccurrenceDataJTWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DAsmProductOccurrenceDataJTWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public ushort m_usValidDisplayFields=>_d.m_usValidDisplayFields;

        private A3DAsmProductOccurrenceDataJT _d;
    }
    public class A3DAsmPartDefinitionDataWrapper
    {
        public A3DAsmPartDefinitionDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DAsmPartDefinitionDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DAsmPartDefinitionGet( p, ref _d );
            }
        }

        ~A3DAsmPartDefinitionDataWrapper()
        {
            API.A3DAsmPartDefinitionGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DBoundingBoxData m_sBoundingBox=>_d.m_sBoundingBox;
        public uint m_uiRepItemsSize=>_d.m_uiRepItemsSize;
        public IntPtr m_ppRepItems=>_d.m_ppRepItems;
        public uint m_uiAnnotationsSize=>_d.m_uiAnnotationsSize;
        public IntPtr m_ppAnnotations=>_d.m_ppAnnotations;
        public uint m_uiViewsSize=>_d.m_uiViewsSize;
        public IntPtr m_ppViews=>_d.m_ppViews;
        public uint m_uiDrawingModelsSize=>_d.m_uiDrawingModelsSize;
        public IntPtr m_ppDrawingModels=>_d.m_ppDrawingModels;
        public bool m_bInactivateAnnotations => _d.m_bInactivateAnnotations;

        private A3DAsmPartDefinitionData _d;
    }
    public class A3DAsmLayerFilterItemDataWrapper
    {
        public A3DAsmLayerFilterItemDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DAsmLayerFilterItemDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIsInclusive => _d.m_bIsInclusive;
        public uint m_uiSize=>_d.m_uiSize;
        public IntPtr m_puiLayerIndexes=>_d.m_puiLayerIndexes;

        private A3DAsmLayerFilterItemData _d;
    }
    public class A3DAsmEntityFilterItemDataWrapper
    {
        public A3DAsmEntityFilterItemDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DAsmEntityFilterItemDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIsInclusive => _d.m_bIsInclusive;
        public uint m_uiSize=>_d.m_uiSize;
        public IntPtr m_ppEntities=>_d.m_ppEntities;

        private A3DAsmEntityFilterItemData _d;
    }
    public class A3DAsmFilterDataWrapper
    {
        public A3DAsmFilterDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DAsmFilterDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DAsmFilterGet( p, ref _d );
            }
        }

        ~A3DAsmFilterDataWrapper()
        {
            API.A3DAsmFilterGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIsActive => _d.m_bIsActive;
        public A3DAsmLayerFilterItemData m_sLayerFilterItem=>_d.m_sLayerFilterItem;
        public A3DAsmEntityFilterItemData m_sEntityFilterItem=>_d.m_sEntityFilterItem;

        private A3DAsmFilterData _d;
    }
    public class A3DRWParamsGeneralDataWrapper
    {
        public A3DRWParamsGeneralDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsGeneralDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bReadSolids => _d.m_bReadSolids;
        public bool m_bReadSurfaces => _d.m_bReadSurfaces;
        public bool m_bReadWireframes => _d.m_bReadWireframes;
        public bool m_bReadPmis => _d.m_bReadPmis;
        public bool m_bReadAttributes => _d.m_bReadAttributes;
        public bool m_bReadHiddenObjects => _d.m_bReadHiddenObjects;
        public bool m_bReadConstructionAndReferences => _d.m_bReadConstructionAndReferences;
        public bool m_bReadActiveFilter => _d.m_bReadActiveFilter;
        public A3DEReadingMode2D3D m_eReadingMode2D3D=>_d.m_eReadingMode2D3D;
        public A3DEReadGeomTessMode m_eReadGeomTessMode=>_d.m_eReadGeomTessMode;
        public A3DEUnits m_eDefaultUnit=>_d.m_eDefaultUnit;
        public bool m_bReadFeature => _d.m_bReadFeature;
        public int m_iNbMultiProcess=>_d.m_iNbMultiProcess;
        public uint m_uiSearchTextureDirectoriesSize=>_d.m_uiSearchTextureDirectoriesSize;
        public IntPtr m_ppcSearchTextureDirectories=>_d.m_ppcSearchTextureDirectories;

        private A3DRWParamsGeneralData _d;
    }
    public class A3DRWParamsPmiDataWrapper
    {
        public A3DRWParamsPmiDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsPmiDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bAlwaysSubstituteFont => _d.m_bAlwaysSubstituteFont;
        public string m_pcSubstitutionFont => _d.m_pcSubstitutionFont;
        public int m_iNumberOfDigitsAfterDot=>_d.m_iNumberOfDigitsAfterDot;
        public A3DEUnits m_eDefaultUnit=>_d.m_eDefaultUnit;
        public uint m_uiProprietaryFontDirectoriesSize=>_d.m_uiProprietaryFontDirectoriesSize;
        public IntPtr m_ppcProprietaryFontDirectories=>_d.m_ppcProprietaryFontDirectories;
        public A3DGraphRgbColorData m_sDefaultColor=>_d.m_sDefaultColor;
        public bool m_bAlwaysUseDefaultColor => _d.m_bAlwaysUseDefaultColor;

        private A3DRWParamsPmiData _d;
    }
    public class A3DRWParamsTessellationDataWrapper
    {
        public A3DRWParamsTessellationDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsTessellationDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DETessellationLevelOfDetail m_eTessellationLevelOfDetail=>_d.m_eTessellationLevelOfDetail;
        public double m_dChordHeightRatio=>_d.m_dChordHeightRatio;
        public double m_dAngleToleranceDeg=>_d.m_dAngleToleranceDeg;
        public double m_dMinimalTriangleAngleDeg=>_d.m_dMinimalTriangleAngleDeg;
        public double m_dMaxChordHeight=>_d.m_dMaxChordHeight;
        public bool m_bAccurateTessellation => _d.m_bAccurateTessellation;
        public bool m_bAccurateTessellationWithGrid => _d.m_bAccurateTessellationWithGrid;
        public double m_dAccurateTessellationWithGridMaximumStitchLength=>_d.m_dAccurateTessellationWithGridMaximumStitchLength;
        public bool m_bAccurateSurfaceCurvatures => _d.m_bAccurateSurfaceCurvatures;
        public bool m_bDoNotComputeNormalsInAccurateTessellation => _d.m_bDoNotComputeNormalsInAccurateTessellation;
        public bool m_bKeepUVPoints => _d.m_bKeepUVPoints;
        public bool m_bUseHeightInsteadOfRatio => _d.m_bUseHeightInsteadOfRatio;
        public double m_dMaximalTriangleEdgeLength=>_d.m_dMaximalTriangleEdgeLength;

        private A3DRWParamsTessellationData _d;
    }
    public class A3DRWParamsSearchDirDataWrapper
    {
        public A3DRWParamsSearchDirDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsSearchDirDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_pcPhysicalPath => _d.m_pcPhysicalPath;
        public string m_pcLogicalName => _d.m_pcLogicalName;
        public bool m_bRecursive => _d.m_bRecursive;

        private A3DRWParamsSearchDirData _d;
    }
    public class A3DRWParamsAssemblyDataWrapper
    {
        public A3DRWParamsAssemblyDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsAssemblyDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bUseRootDirectory => _d.m_bUseRootDirectory;
        public bool m_bRootDirRecursive => _d.m_bRootDirRecursive;
        public uint m_uiSearchDirectoriesSize=>_d.m_uiSearchDirectoriesSize;
        public IntPtr m_ppcSearchDirectories=>_d.m_ppcSearchDirectories;
        public uint m_uiPathDefinitionsSize=>_d.m_uiPathDefinitionsSize;
        public IntPtr m_ppcPathDefinitions=>_d.m_ppcPathDefinitions;

        private A3DRWParamsAssemblyData _d;
    }
    public class A3DRWParamsMultiEntriesDataWrapper
    {
        public A3DRWParamsMultiEntriesDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsMultiEntriesDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bLoadDefault => _d.m_bLoadDefault;
        public uint m_uiEntriesSize=>_d.m_uiEntriesSize;
        public IntPtr m_ppcEntries=>_d.m_ppcEntries;

        private A3DRWParamsMultiEntriesData _d;
    }
    public class A3DRWParamsCatiaV4DataWrapper
    {
        public A3DRWParamsCatiaV4DataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsCatiaV4DataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_pcRootDirLogicalName => _d.m_pcRootDirLogicalName;
        public bool m_bAllowSearchInOtherLogicalNames => _d.m_bAllowSearchInOtherLogicalNames;

        private A3DRWParamsCatiaV4Data _d;
    }
    public class A3DRWParamsCatiaV5DataWrapper
    {
        public A3DRWParamsCatiaV5DataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsCatiaV5DataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bCacheActivation => _d.m_bCacheActivation;
        public string m_pcCachePath => _d.m_pcCachePath;
        public bool m_bUseMaterialRendering => _d.m_bUseMaterialRendering;

        private A3DRWParamsCatiaV5Data _d;
    }
    public class A3DRWParamsUnigraphicsDataWrapper
    {
        public A3DRWParamsUnigraphicsDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsUnigraphicsDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bApplyToAllLevels => _d.m_bApplyToAllLevels;
        public uint m_uiPreferredReferenceSetsSize=>_d.m_uiPreferredReferenceSetsSize;
        public IntPtr m_ppcPreferredReferenceSets=>_d.m_ppcPreferredReferenceSets;
        public bool m_bFitAllToUpdateViewCameras => _d.m_bFitAllToUpdateViewCameras;

        private A3DRWParamsUnigraphicsData _d;
    }
    public class A3DRWParamsProEDataWrapper
    {
        public A3DRWParamsProEDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsProEDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_pcCodePageName => _d.m_pcCodePageName;
        public bool m_bDisplayTolerance => _d.m_bDisplayTolerance;
        public bool m_bDisplaySubpartAnnotations => _d.m_bDisplaySubpartAnnotations;
        public A3DProESessionColorType m_eSessionColorType=>_d.m_eSessionColorType;
        public A3DProEFamilyTables m_eFamilyTables=>_d.m_eFamilyTables;
        public bool m_bBoolOpUseGenericIfNoTess => _d.m_bBoolOpUseGenericIfNoTess;
        public bool m_bFlexCompUseGenericIfNoTess => _d.m_bFlexCompUseGenericIfNoTess;
        public bool m_bHideSkeletons => _d.m_bHideSkeletons;
        public bool m_bReadExplodeStateAsView => _d.m_bReadExplodeStateAsView;
        public bool m_bDisplayVisibleDatum => _d.m_bDisplayVisibleDatum;
        public A3DProEReadConstructEntities m_eReadConstructEntities=>_d.m_eReadConstructEntities;
        public bool m_bComputeHomeView => _d.m_bComputeHomeView;
        public bool m_bHandlePMIScreenLocation => _d.m_bHandlePMIScreenLocation;
        public bool m_bIsometricDefaultView => _d.m_bIsometricDefaultView;

        private A3DRWParamsProEData _d;
    }
    public class A3DRWValidationPropertiesThresholdDataWrapper
    {
        public A3DRWValidationPropertiesThresholdDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWValidationPropertiesThresholdDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dGEOMPercentVolume=>_d.m_dGEOMPercentVolume;
        public double m_dGEOMPercentSurfaceArea=>_d.m_dGEOMPercentSurfaceArea;
        public double m_dGEOMPercentIndependentSurfaceArea=>_d.m_dGEOMPercentIndependentSurfaceArea;
        public double m_dGEOMPercentIndependentCurveLength=>_d.m_dGEOMPercentIndependentCurveLength;
        public double m_dGEOMDeviationCentroid=>_d.m_dGEOMDeviationCentroid;
        public double m_dGEOMDeviationIndependentSurfaceCentroid=>_d.m_dGEOMDeviationIndependentSurfaceCentroid;
        public double m_dGEOMDeviationIndependentCurveCentroid=>_d.m_dGEOMDeviationIndependentCurveCentroid;
        public double m_dGEOMDeviationPointSetCentroid=>_d.m_dGEOMDeviationPointSetCentroid;
        public double m_dGEOMDeviationBoundingBox=>_d.m_dGEOMDeviationBoundingBox;
        public double m_dPMIPercentAffectedArea=>_d.m_dPMIPercentAffectedArea;
        public double m_dPMIPercentAffectedCurveLength=>_d.m_dPMIPercentAffectedCurveLength;
        public double m_dPMIPercentCurveLength=>_d.m_dPMIPercentCurveLength;
        public double m_dPMIPercentSurfaceArea=>_d.m_dPMIPercentSurfaceArea;
        public double m_dPMIDeviationCurveCentroid=>_d.m_dPMIDeviationCurveCentroid;
        public double m_dPMIDeviationSurfaceCentroid=>_d.m_dPMIDeviationSurfaceCentroid;
        public double m_dASMDeviationNotionalSolidsCentroid=>_d.m_dASMDeviationNotionalSolidsCentroid;

        private A3DRWValidationPropertiesThresholdData _d;
    }
    public class A3DRWParamsStepDataWrapper
    {
        public A3DRWParamsStepDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsStepDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bPreferProductName => _d.m_bPreferProductName;
        public bool m_bPreferFirstColor => _d.m_bPreferFirstColor;
        public A3DEStepNameFromNAUO m_eNameFromNAUO=>_d.m_eNameFromNAUO;
        public string m_pcCodePageName => _d.m_pcCodePageName;
        public bool m_bSplitSHELL_BASED_SURFACE_MODEL => _d.m_bSplitSHELL_BASED_SURFACE_MODEL;
        public bool m_bHealOrientations => _d.m_bHealOrientations;
        public bool m_bReadValidationProperties => _d.m_bReadValidationProperties;
        public bool m_bComputeValidationProperties => _d.m_bComputeValidationProperties;
        public bool m_bAddResultToName => _d.m_bAddResultToName;
        public A3DRWValidationPropertiesThresholdData m_sValidationPropertiesThreshold=>_d.m_sValidationPropertiesThreshold;

        private A3DRWParamsStepData _d;
    }
    public class A3DRWParamsIGESDataWrapper
    {
        public A3DRWParamsIGESDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsIGESDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bSewBrepModels => _d.m_bSewBrepModels;

        private A3DRWParamsIGESData _d;
    }
    public class A3DRWParamsIFCDataWrapper
    {
        public A3DRWParamsIFCDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsIFCDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_pcCodePageName => _d.m_pcCodePageName;
        public string m_pcXMLFilePathForAttributes => _d.m_pcXMLFilePathForAttributes;
        public bool m_bIFCOWNERHISTORYOptimized => _d.m_bIFCOWNERHISTORYOptimized;
        public bool m_bFACETED_BREPAsOneFace => _d.m_bFACETED_BREPAsOneFace;
        public bool m_bAttributesOnlyGlobalId => _d.m_bAttributesOnlyGlobalId;
        public bool m_bHideWireframes => _d.m_bHideWireframes;

        private A3DRWParamsIFCData _d;
    }
    public class A3DRWParamsJTDataWrapper
    {
        public A3DRWParamsJTDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsJTDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DEJTReadTessellationLevelOfDetail m_eReadTessellationLevelOfDetail=>_d.m_eReadTessellationLevelOfDetail;

        private A3DRWParamsJTData _d;
    }
    public class A3DRWParamsParasolidDataWrapper
    {
        public A3DRWParamsParasolidDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsParasolidDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bKeepParsedEntities => _d.m_bKeepParsedEntities;

        private A3DRWParamsParasolidData _d;
    }
    public class A3DRWParamsSolidworksDataWrapper
    {
        public A3DRWParamsSolidworksDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsSolidworksDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bLoadAllConfigsData => _d.m_bLoadAllConfigsData;
        public ushort m_usDisplayVisibleDatum=>_d.m_usDisplayVisibleDatum;

        private A3DRWParamsSolidworksData _d;
    }
    public class A3DRWParamsInventorDataWrapper
    {
        public A3DRWParamsInventorDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsInventorDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bUseTessForFile => _d.m_bUseTessForFile;

        private A3DRWParamsInventorData _d;
    }
    public class A3DRWParamsRhinoDataWrapper
    {
        public A3DRWParamsRhinoDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsRhinoDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bForceRenderedModeColors => _d.m_bForceRenderedModeColors;

        private A3DRWParamsRhinoData _d;
    }
    public class A3DRWParamsRevitDataWrapper
    {
        public A3DRWParamsRevitDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsRevitDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public EA3DRevitPhysicalProperties m_ePhysicalProperties=>_d.m_ePhysicalProperties;

        private A3DRWParamsRevitData _d;
    }
    public class A3DRWParamsSpecificLoadDataWrapper
    {
        public A3DRWParamsSpecificLoadDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsSpecificLoadDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DRWParamsCatiaV4Data m_sCatiaV4=>_d.m_sCatiaV4;
        public A3DRWParamsCatiaV5Data m_sCatiaV5=>_d.m_sCatiaV5;
        public A3DRWParamsUnigraphicsData m_sUnigraphics=>_d.m_sUnigraphics;
        public A3DRWParamsProEData m_sProE=>_d.m_sProE;
        public A3DRWParamsStepData m_sStep=>_d.m_sStep;
        public A3DRWParamsIGESData m_sIGES=>_d.m_sIGES;
        public A3DRWParamsIFCData m_sIFC=>_d.m_sIFC;
        public A3DRWParamsJTData m_sJT=>_d.m_sJT;
        public A3DRWParamsParasolidData m_sParasolid=>_d.m_sParasolid;
        public A3DRWParamsSolidworksData m_sSolidworks=>_d.m_sSolidworks;
        public A3DRWParamsInventorData m_sInventor=>_d.m_sInventor;
        public A3DRWParamsRhinoData m_sRhino=>_d.m_sRhino;
        public A3DRWParamsRevitData m_sRevit=>_d.m_sRevit;

        private A3DRWParamsSpecificLoadData _d;
    }
    public class A3DRWParamsIncrementalLoadDataWrapper
    {
        public A3DRWParamsIncrementalLoadDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsIncrementalLoadDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bLoadStructureOnly => _d.m_bLoadStructureOnly;
        public bool m_bLoadNoDependencies => _d.m_bLoadNoDependencies;
        public IntPtr m_pRootProductOccurrence=>_d.m_pRootProductOccurrence;
        public uint m_uiProductOccurrencesSize=>_d.m_uiProductOccurrencesSize;
        public IntPtr m_ppProductOccurrences=>_d.m_ppProductOccurrences;

        private A3DRWParamsIncrementalLoadData _d;
    }
    public class A3DRWParamsLoadDataWrapper
    {
        public A3DRWParamsLoadDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsLoadDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DRWParamsGeneralData m_sGeneral=>_d.m_sGeneral;
        public A3DRWParamsPmiData m_sPmi=>_d.m_sPmi;
        public A3DRWParamsTessellationData m_sTessellation=>_d.m_sTessellation;
        public A3DRWParamsAssemblyData m_sAssembly=>_d.m_sAssembly;
        public A3DRWParamsMultiEntriesData m_sMultiEntries=>_d.m_sMultiEntries;
        public A3DRWParamsSpecificLoadData m_sSpecifics=>_d.m_sSpecifics;
        public A3DRWParamsIncrementalLoadData m_sIncremental=>_d.m_sIncremental;

        private A3DRWParamsLoadData _d;
    }
    public class A3DStream3DPDFDataWrapper
    {
        public A3DStream3DPDFDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DStream3DPDFDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiStreamSize=>_d.m_uiStreamSize;
        public string m_acStream => _d.m_acStream;
        public bool m_bIsPrc => _d.m_bIsPrc;
        public uint m_uiIdentifier=>_d.m_uiIdentifier;

        private A3DStream3DPDFData _d;
    }
    public class A3DRWParamsExportPrcDataWrapper
    {
        public A3DRWParamsExportPrcDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsExportPrcDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bCompressBrep => _d.m_bCompressBrep;
        public bool m_bCompressTessellation => _d.m_bCompressTessellation;
        public A3DECompressBrepType m_eCompressBrepType=>_d.m_eCompressBrepType;
        public bool m_bRemoveBRep => _d.m_bRemoveBRep;
        public bool m_bRemoveAttributes => _d.m_bRemoveAttributes;

        private A3DRWParamsExportPrcData _d;
    }
    public class A3DRWParamsExportU3DDataWrapper
    {
        public A3DRWParamsExportU3DDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsExportU3DDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DEU3DVersion m_eU3DVersion=>_d.m_eU3DVersion;
        public bool m_bMeshQuality => _d.m_bMeshQuality;
        public byte m_ucMeshQualityValue=>_d.m_ucMeshQualityValue;

        private A3DRWParamsExportU3DData _d;
    }
    public class A3DRWParamsExportStepDataWrapper
    {
        public A3DRWParamsExportStepDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsExportStepDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DEStepFormat m_eStepFormat=>_d.m_eStepFormat;
        public bool m_bSaveFacetedToWireframe => _d.m_bSaveFacetedToWireframe;
        public bool m_bSaveAnalyticsToNurbs => _d.m_bSaveAnalyticsToNurbs;
        public bool m_bUseShortNames => _d.m_bUseShortNames;
        public string m_pcApplication => _d.m_pcApplication;
        public string m_pcVersion => _d.m_pcVersion;
        public bool m_bWritePMI => _d.m_bWritePMI;
        public bool m_bWriteAttributes => _d.m_bWriteAttributes;
        public bool m_bWriteUVCurves => _d.m_bWriteUVCurves;
        public string m_pcConfig => _d.m_pcConfig;
        public bool m_bWriteValidationProperties => _d.m_bWriteValidationProperties;
        public bool m_bWritePMIWithSemantic => _d.m_bWritePMIWithSemantic;
        public bool m_bWritePMIAsTessellated => _d.m_bWritePMIAsTessellated;
        public string m_pcUser => _d.m_pcUser;
        public string m_pcOrganisation => _d.m_pcOrganisation;
        public string m_pcAuthorisation => _d.m_pcAuthorisation;

        private A3DRWParamsExportStepData _d;
    }
    public class A3DRWParamsExportJTDataWrapper
    {
        public A3DRWParamsExportJTDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsExportJTDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DEWriteGeomTessMode m_eWriteGeomTessMode=>_d.m_eWriteGeomTessMode;
        public bool m_bWriteHiddenObjects => _d.m_bWriteHiddenObjects;
        public bool m_bWritePMI => _d.m_bWritePMI;
        public A3DEJTVersion m_eJTVersion=>_d.m_eJTVersion;

        private A3DRWParamsExportJTData _d;
    }
    public class A3DRWParamsExportIgesDataWrapper
    {
        public A3DRWParamsExportIgesDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsExportIgesDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bSaveAnalyticsToNurbs => _d.m_bSaveAnalyticsToNurbs;
        public bool m_bSaveFacetedToWireframe => _d.m_bSaveFacetedToWireframe;
        public bool m_bSaveSolidsAsFaces => _d.m_bSaveSolidsAsFaces;
        public bool m_bWriteHiddenObjects => _d.m_bWriteHiddenObjects;
        public bool m_bWriteTessellation => _d.m_bWriteTessellation;
        public string m_pcApplication => _d.m_pcApplication;
        public string m_pcVersion => _d.m_pcVersion;

        private A3DRWParamsExportIgesData _d;
    }
    public class A3DRWParamsExportStlDataWrapper
    {
        public A3DRWParamsExportStlDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsExportStlDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bBinaryFile => _d.m_bBinaryFile;
        public A3DETessellationLevelOfDetail m_eTessellationLevelOfDetail=>_d.m_eTessellationLevelOfDetail;
        public double m_dChordHeightRatio=>_d.m_dChordHeightRatio;
        public double m_dAngleToleranceDeg=>_d.m_dAngleToleranceDeg;
        public double m_dMinimalTriangleAngleDeg=>_d.m_dMinimalTriangleAngleDeg;
        public double m_dMaxChordHeight=>_d.m_dMaxChordHeight;
        public bool m_bAccurateTessellation => _d.m_bAccurateTessellation;
        public bool m_bAccurateTessellationWithGrid => _d.m_bAccurateTessellationWithGrid;
        public double m_dAccurateTessellationWithGridMaximumStitchLength=>_d.m_dAccurateTessellationWithGridMaximumStitchLength;
        public bool m_bAccurateSurfaceCurvatures => _d.m_bAccurateSurfaceCurvatures;
        public bool m_bKeepCurrentTessellation => _d.m_bKeepCurrentTessellation;
        public bool m_bUseHeightInsteadOfRatio => _d.m_bUseHeightInsteadOfRatio;
        public double m_dMaximalTriangleEdgeLength=>_d.m_dMaximalTriangleEdgeLength;
        public A3DEUnits m_eExportUnit=>_d.m_eExportUnit;

        private A3DRWParamsExportStlData _d;
    }
    public class A3DRWParamsExport3mfDataWrapper
    {
        public A3DRWParamsExport3mfDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsExport3mfDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bKeepCurrentTessellation => _d.m_bKeepCurrentTessellation;
        public A3DRWParamsTessellationData m_sTessellation=>_d.m_sTessellation;
        public string m_pcDescription => _d.m_pcDescription;
        public string m_pcCopyright => _d.m_pcCopyright;
        public string m_pcLicenseTerms => _d.m_pcLicenseTerms;

        private A3DRWParamsExport3mfData _d;
    }
    public class A3DRWParamsExportXMLDataWrapper
    {
        public A3DRWParamsExportXMLDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsExportXMLDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bExportMetadata => _d.m_bExportMetadata;
        public bool m_bExportTransformations => _d.m_bExportTransformations;
        public bool m_bExportColorMaterial => _d.m_bExportColorMaterial;
        public bool m_bExportProductInformationByFormat => _d.m_bExportProductInformationByFormat;

        private A3DRWParamsExportXMLData _d;
    }
    public class A3DRWParamsExportObjDataWrapper
    {
        public A3DRWParamsExportObjDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsExportObjDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_pcTextureFolder => _d.m_pcTextureFolder;

        private A3DRWParamsExportObjData _d;
    }
    public class A3DRWParamsExportFbxDataWrapper
    {
        public A3DRWParamsExportFbxDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsExportFbxDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bAscii => _d.m_bAscii;
        public string m_pcTextureFolder => _d.m_pcTextureFolder;

        private A3DRWParamsExportFbxData _d;
    }
    public class A3DSewOptionsDataWrapper
    {
        public A3DSewOptionsDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DSewOptionsDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bComputePreferredOpenShellOrientation => _d.m_bComputePreferredOpenShellOrientation;

        private A3DSewOptionsData _d;
    }
    public class A3DFaceUVPointInsideManagerDataWrapper
    {
        public A3DFaceUVPointInsideManagerDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DFaceUVPointInsideManagerDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiFaceSize=>_d.m_uiFaceSize;

        private A3DFaceUVPointInsideManagerData _d;
    }
    public class A3DProjectedPointCloudDataWrapper
    {
        public A3DProjectedPointCloudDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DProjectedPointCloudDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bSuccess => _d.m_bSuccess;
        public double m_dDist=>_d.m_dDist;
        public A3DVector3dData m_sPt=>_d.m_sPt;
        public int m_iBRepIndice=>_d.m_iBRepIndice;
        public int m_iFaceIndice=>_d.m_iFaceIndice;
        public int m_iEdgeIndice=>_d.m_iEdgeIndice;
        public A3DVector2dData m_sUV=>_d.m_sUV;
        public double m_dEdgeParameter=>_d.m_dEdgeParameter;
        public bool m_bIsInFace => _d.m_bIsInFace;

        private A3DProjectedPointCloudData _d;
    }
    public class A3DProjectPointCloudManagerDataFromRIWrapper
    {
        public A3DProjectPointCloudManagerDataFromRIWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DProjectPointCloudManagerDataFromRIWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uRepItemSize=>_d.m_uRepItemSize;
        public IntPtr m_pRepItems=>_d.m_pRepItems;
        public IntPtr m_pOptPlacements=>_d.m_pOptPlacements;
        public bool m_bUseExactComputation => _d.m_bUseExactComputation;

        private A3DProjectPointCloudManagerDataFromRI _d;
    }
    public class A3DPlanarSectionDataWrapper
    {
        public A3DPlanarSectionDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DPlanarSectionDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DVector3dData m_sOrigin=>_d.m_sOrigin;
        public A3DVector3dData m_sDirection=>_d.m_sDirection;
        public bool m_bColor => _d.m_bColor;
        public bool m_bCreateFaces => _d.m_bCreateFaces;

        private A3DPlanarSectionData _d;
    }
    public class A3DCompareInputDataWrapper
    {
        public A3DCompareInputDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DCompareInputDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dTol=>_d.m_dTol;
        public uint m_uiOldRiBrepModelsSize=>_d.m_uiOldRiBrepModelsSize;
        public IntPtr m_ppOldRiBrepModels=>_d.m_ppOldRiBrepModels;
        public IntPtr m_pOldRiBrepModelPlacements=>_d.m_pOldRiBrepModelPlacements;
        public uint m_uiNewRiBrepModelsSize=>_d.m_uiNewRiBrepModelsSize;
        public IntPtr m_ppNewRiBrepModels=>_d.m_ppNewRiBrepModels;
        public IntPtr m_pNewRiBrepModelPlacements=>_d.m_pNewRiBrepModelPlacements;

        private A3DCompareInputData _d;
    }
    public class A3DCompareOutputDataWrapper
    {
        public A3DCompareOutputDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DCompareOutputDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiOldFaceSize=>_d.m_uiOldFaceSize;
        public IntPtr m_pOldFace=>_d.m_pOldFace;
        public IntPtr m_pOldFaceMatch=>_d.m_pOldFaceMatch;
        public uint m_uiNewFaceSize=>_d.m_uiNewFaceSize;
        public IntPtr m_pNewFace=>_d.m_pNewFace;
        public IntPtr m_pNewFaceMatch=>_d.m_pNewFaceMatch;
        public IntPtr m_pResultRiSet=>_d.m_pResultRiSet;
        public IntPtr m_pResultAsmModeFile=>_d.m_pResultAsmModeFile;

        private A3DCompareOutputData _d;
    }
    public class A3DMultiPlanarSectionDataWrapper
    {
        public A3DMultiPlanarSectionDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DMultiPlanarSectionDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiPointSize=>_d.m_uiPointSize;
        public IntPtr m_pPoints=>_d.m_pPoints;
        public A3DVector3dData m_sExtrudeDirection=>_d.m_sExtrudeDirection;
        public A3DVector3dData m_sProfileNormal=>_d.m_sProfileNormal;

        private A3DMultiPlanarSectionData _d;
    }
    public class A3DHLRViewPlaneDataWrapper
    {
        public A3DHLRViewPlaneDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DHLRViewPlaneDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double[] m_adOrigin {
            get {
                var result = new double[3];
                for( var idx = 0; idx < 3; ++idx ) unsafe {
                    result[idx] = _d.m_adOrigin[idx];
                }
                return result;
            }
        }
        public double[] m_adAxis1 {
            get {
                var result = new double[3];
                for( var idx = 0; idx < 3; ++idx ) unsafe {
                    result[idx] = _d.m_adAxis1[idx];
                }
                return result;
            }
        }
        public double[] m_adAxis2 {
            get {
                var result = new double[3];
                for( var idx = 0; idx < 3; ++idx ) unsafe {
                    result[idx] = _d.m_adAxis2[idx];
                }
                return result;
            }
        }
        public bool m_bUseClipBox => _d.m_bUseClipBox;

        private A3DHLRViewPlaneData _d;
    }
    public class A3DHLRCurveDataWrapper
    {
        public A3DHLRCurveDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DHLRCurveDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pProjectedPolyLine=>_d.m_pProjectedPolyLine;
        public IntPtr m_psTopoEdge=>_d.m_psTopoEdge;
        public IntPtr m_psTopoFirstFace=>_d.m_psTopoFirstFace;
        public IntPtr m_psTopoSecondFace=>_d.m_psTopoSecondFace;
        public bool m_bFirstFaceIsSection => _d.m_bFirstFaceIsSection;
        public bool m_bSecondFaceIsSection => _d.m_bSecondFaceIsSection;
        public byte m_cType=>_d.m_cType;
        public bool m_bIsHidden => _d.m_bIsHidden;
        public bool m_bIsEdge => _d.m_bIsEdge;
        public bool m_bIsSection => _d.m_bIsSection;
        public bool m_bIsSilhouette => _d.m_bIsSilhouette;
        public bool m_bIsTanEdge => _d.m_bIsTanEdge;

        private A3DHLRCurveData _d;
    }
    public class A3DHLRSectionFaceDataWrapper
    {
        public A3DHLRSectionFaceDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DHLRSectionFaceDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiNbLoop=>_d.m_uiNbLoop;
        public IntPtr m_puiLoopSize=>_d.m_puiLoopSize;
        public IntPtr m_puiCurveIndex=>_d.m_puiCurveIndex;
        public IntPtr m_pbCurveOrientation=>_d.m_pbCurveOrientation;

        private A3DHLRSectionFaceData _d;
    }
    public class A3DHLRRepresentationItemDataWrapper
    {
        public A3DHLRRepresentationItemDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DHLRRepresentationItemDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DHLRRepresentationItemGet( p, ref _d );
            }
        }

        ~A3DHLRRepresentationItemDataWrapper()
        {
            API.A3DHLRRepresentationItemGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pRepItem=>_d.m_pRepItem;
        public double[] m_adMatrix {
            get {
                var result = new double[16];
                for( var idx = 0; idx < 16; ++idx ) unsafe {
                    result[idx] = _d.m_adMatrix[idx];
                }
                return result;
            }
        }
        public uint m_uiNumberHLRCurves=>_d.m_uiNumberHLRCurves;
        public IntPtr m_pppHLRCurves=>_d.m_pppHLRCurves;
        public uint m_uiNumberSectionFace=>_d.m_uiNumberSectionFace;
        public IntPtr m_pHLRSectionFaces=>_d.m_pHLRSectionFaces;

        private A3DHLRRepresentationItemData _d;
    }
    public class A3DHLROptionsDataWrapper
    {
        public A3DHLROptionsDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DHLROptionsDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bTangentEdgeDetect => _d.m_bTangentEdgeDetect;
        public double m_dTangentEdgeAngle=>_d.m_dTangentEdgeAngle;
        public bool m_bRemoveHidden => _d.m_bRemoveHidden;
        public bool m_bRemoveTangentEdge => _d.m_bRemoveTangentEdge;

        private A3DHLROptionsData _d;
    }
    public class A3DTransfoRepresentationItemDataWrapper
    {
        public A3DTransfoRepresentationItemDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DTransfoRepresentationItemDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pRepItem=>_d.m_pRepItem;
        public IntPtr m_pOptPlacement=>_d.m_pOptPlacement;

        private A3DTransfoRepresentationItemData _d;
    }
    public class A3DCollisionGroupDataWrapper
    {
        public A3DCollisionGroupDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DCollisionGroupDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uRepItemSize=>_d.m_uRepItemSize;
        public IntPtr m_apRepItems=>_d.m_apRepItems;

        private A3DCollisionGroupData _d;
    }
    public class A3DCollisionParameterDataWrapper
    {
        public A3DCollisionParameterDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DCollisionParameterDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dSafetyDistance=>_d.m_dSafetyDistance;
        public double m_dContactLimit=>_d.m_dContactLimit;
        public double m_dTessellationTolerance=>_d.m_dTessellationTolerance;

        private A3DCollisionParameterData _d;
    }
    public class A3DCollisionResultDataWrapper
    {
        public A3DCollisionResultDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DCollisionResultDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_iRepItemIndex1=>_d.m_iRepItemIndex1;
        public uint m_iRepItemIndex2=>_d.m_iRepItemIndex2;
        public A3DCollisionType m_eStatus=>_d.m_eStatus;

        private A3DCollisionResultData _d;
    }
    public class A3DMkpLeaderDataWrapper
    {
        public A3DMkpLeaderDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMkpLeaderDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMkpLeaderGet( p, ref _d );
            }
        }

        ~A3DMkpLeaderDataWrapper()
        {
            API.A3DMkpLeaderGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pLinkedItem=>_d.m_pLinkedItem;
        public IntPtr m_pTessellation=>_d.m_pTessellation;

        private A3DMkpLeaderData _d;
    }
    public class A3DMkpAnnotationItemDataWrapper
    {
        public A3DMkpAnnotationItemDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMkpAnnotationItemDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMkpAnnotationItemGet( p, ref _d );
            }
        }

        ~A3DMkpAnnotationItemDataWrapper()
        {
            API.A3DMkpAnnotationItemGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pMarkup=>_d.m_pMarkup;

        private A3DMkpAnnotationItemData _d;
    }
    public class A3DMkpAnnotationSetDataWrapper
    {
        public A3DMkpAnnotationSetDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMkpAnnotationSetDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMkpAnnotationSetGet( p, ref _d );
            }
        }

        ~A3DMkpAnnotationSetDataWrapper()
        {
            API.A3DMkpAnnotationSetGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiAnnotationsSize=>_d.m_uiAnnotationsSize;
        public IntPtr m_ppAnnotations=>_d.m_ppAnnotations;

        private A3DMkpAnnotationSetData _d;
    }
    public class A3DMkpAnnotationReferenceDataWrapper
    {
        public A3DMkpAnnotationReferenceDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMkpAnnotationReferenceDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMkpAnnotationReferenceGet( p, ref _d );
            }
        }

        ~A3DMkpAnnotationReferenceDataWrapper()
        {
            API.A3DMkpAnnotationReferenceGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiLinkedItemsSize=>_d.m_uiLinkedItemsSize;
        public IntPtr m_ppLinkedItems=>_d.m_ppLinkedItems;

        private A3DMkpAnnotationReferenceData _d;
    }
    public class A3DMkpViewDataWrapper
    {
        public A3DMkpViewDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMkpViewDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMkpViewGet( p, ref _d );
            }
        }

        ~A3DMkpViewDataWrapper()
        {
            API.A3DMkpViewGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiAnnotationsSize=>_d.m_uiAnnotationsSize;
        public IntPtr m_ppAnnotations=>_d.m_ppAnnotations;
        public IntPtr m_pPlane=>_d.m_pPlane;
        public IntPtr m_pSceneDisplayParameters=>_d.m_pSceneDisplayParameters;
        public bool m_bIsAnnotationView => _d.m_bIsAnnotationView;
        public bool m_bIsDefaultView => _d.m_bIsDefaultView;
        public uint m_uiLinkedItemsSize=>_d.m_uiLinkedItemsSize;
        public IntPtr m_ppLinkedItems=>_d.m_ppLinkedItems;
        public uint m_uiDisplayFilterSize=>_d.m_uiDisplayFilterSize;
        public IntPtr m_ppDisplayFilters=>_d.m_ppDisplayFilters;

        private A3DMkpViewData _d;
    }
    public class A3DMkpViewFlagsDataWrapper
    {
        public A3DMkpViewFlagsDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DMkpViewFlagsDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIsCameraSet => _d.m_bIsCameraSet;
        public bool m_bIsPMIFilteringSet => _d.m_bIsPMIFilteringSet;
        public bool m_bIsGeomFilteringSet => _d.m_bIsGeomFilteringSet;
        public bool m_bIsCrossSectionSet => _d.m_bIsCrossSectionSet;
        public bool m_bIsExplosionSet => _d.m_bIsExplosionSet;
        public bool m_bIsCombineState => _d.m_bIsCombineState;

        private A3DMkpViewFlagsData _d;
    }
    public class A3DMiscMarkupLinkedItemDataWrapper
    {
        public A3DMiscMarkupLinkedItemDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMiscMarkupLinkedItemDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMiscMarkupLinkedItemGet( p, ref _d );
            }
        }

        ~A3DMiscMarkupLinkedItemDataWrapper()
        {
            API.A3DMiscMarkupLinkedItemGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bMarkupShowControl => _d.m_bMarkupShowControl;
        public bool m_bMarkupDeleteControl => _d.m_bMarkupDeleteControl;
        public bool m_bLeaderShowControl => _d.m_bLeaderShowControl;
        public bool m_bLeaderDeleteControl => _d.m_bLeaderDeleteControl;
        public IntPtr m_pTargetProductOccurrence=>_d.m_pTargetProductOccurrence;
        public IntPtr m_pReference=>_d.m_pReference;

        private A3DMiscMarkupLinkedItemData _d;
    }
    public class A3DMkpMarkupDataWrapper
    {
        public A3DMkpMarkupDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMkpMarkupDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMkpMarkupGet( p, ref _d );
            }
        }

        ~A3DMkpMarkupDataWrapper()
        {
            API.A3DMkpMarkupGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DEMarkupType m_eType=>_d.m_eType;
        public A3DEMarkupSubType m_eSubType=>_d.m_eSubType;
        public uint m_uiLeadersSize=>_d.m_uiLeadersSize;
        public IntPtr m_ppLeaders=>_d.m_ppLeaders;
        public uint m_uiLinkedItemsSize=>_d.m_uiLinkedItemsSize;
        public IntPtr m_ppLinkedItems=>_d.m_ppLinkedItems;
        public IntPtr m_pTessellation=>_d.m_pTessellation;

        private A3DMkpMarkupData _d;
    }
    public class A3DMkpRTFFieldDataWrapper
    {
        public A3DMkpRTFFieldDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMkpRTFFieldDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMkpRTFFieldGet( p, ref _d );
            }
        }

        ~A3DMkpRTFFieldDataWrapper()
        {
            API.A3DMkpRTFFieldGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_usGetFieldIndex=>_d.m_usGetFieldIndex;
        public string m_pcText => _d.m_pcText;
        public string m_pcFamilyName => _d.m_pcFamilyName;
        public A3DEMarkupSymbol m_eSymbol=>_d.m_eSymbol;
        public int[] m_aRGB {
            get {
                var result = new int[3];
                for( var idx = 0; idx < 3; ++idx ) unsafe {
                    result[idx] = _d.m_aRGB[idx];
                }
                return result;
            }
        }
        public float m_fHeight=>_d.m_fHeight;
        public byte m_cAttributes=>_d.m_cAttributes;

        private A3DMkpRTFFieldData _d;
    }
    public class A3DFontKeyDataWrapper
    {
        public A3DFontKeyDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DFontKeyDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public int m_iFontFamilyIndex=>_d.m_iFontFamilyIndex;
        public int m_iFontStyleIndex=>_d.m_iFontStyleIndex;
        public int m_iFontSizeIndex=>_d.m_iFontSizeIndex;
        public byte m_cAttributes=>_d.m_cAttributes;

        private A3DFontKeyData _d;
    }
    public class A3DFontDataWrapper
    {
        public A3DFontDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DFontDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_pcFamilyName => _d.m_pcFamilyName;
        public string m_pcFontFilePath => _d.m_pcFontFilePath;
        public A3DECharSet m_eCharset=>_d.m_eCharset;
        public uint m_uiSize=>_d.m_uiSize;
        public byte m_cAttributes=>_d.m_cAttributes;

        private A3DFontData _d;
    }
    public class A3DGraphTextureTransformationDataWrapper
    {
        public A3DGraphTextureTransformationDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DGraphTextureTransformationDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DGraphTextureTransformationGet( p, ref _d );
            }
        }

        ~A3DGraphTextureTransformationDataWrapper()
        {
            API.A3DGraphTextureTransformationGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bTextureFlipS => _d.m_bTextureFlipS;
        public bool m_bTextureFlipT => _d.m_bTextureFlipT;
        public double[] m_dMatrix {
            get {
                var result = new double[16];
                for( var idx = 0; idx < 16; ++idx ) unsafe {
                    result[idx] = _d.m_dMatrix[idx];
                }
                return result;
            }
        }
        public bool m_bIs2D => _d.m_bIs2D;

        private A3DGraphTextureTransformationData _d;
    }
    public class A3DGraphTextureDefinitionDataWrapper
    {
        public A3DGraphTextureDefinitionDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DGraphTextureDefinitionDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiPictureIndex=>_d.m_uiPictureIndex;
        public byte m_ucTextureDimension=>_d.m_ucTextureDimension;
        public A3DETextureMappingType m_eMappingType=>_d.m_eMappingType;
        public A3DETextureMappingOperator m_eMappingOperator=>_d.m_eMappingOperator;
        public IntPtr m_pOperatorTransfo=>_d.m_pOperatorTransfo;
        public uint m_uiMappingAttributes=>_d.m_uiMappingAttributes;
        public uint m_uiMappingAttributesIntensitySize=>_d.m_uiMappingAttributesIntensitySize;
        public IntPtr m_pdMappingAttributesIntensity=>_d.m_pdMappingAttributesIntensity;
        public uint m_uiMappingAttributesComponentsSize=>_d.m_uiMappingAttributesComponentsSize;
        public IntPtr m_pucMappingAttributesComponents=>_d.m_pucMappingAttributesComponents;
        public A3DETextureFunction m_eTextureFunction=>_d.m_eTextureFunction;
        public double m_dRed=>_d.m_dRed;
        public double m_dGreen=>_d.m_dGreen;
        public double m_dBlue=>_d.m_dBlue;
        public double m_dAlpha=>_d.m_dAlpha;
        public A3DETextureBlendParameter m_eBlend_src_RGB=>_d.m_eBlend_src_RGB;
        public A3DETextureBlendParameter m_eBlend_dst_RGB=>_d.m_eBlend_dst_RGB;
        public A3DETextureBlendParameter m_eBlend_src_Alpha=>_d.m_eBlend_src_Alpha;
        public A3DETextureBlendParameter m_eBlend_dst_Alpha=>_d.m_eBlend_dst_Alpha;
        public byte m_ucTextureApplyingMode=>_d.m_ucTextureApplyingMode;
        public A3DETextureAlphaTest m_eTextureAlphaTest=>_d.m_eTextureAlphaTest;
        public double m_dAlphaTestReference=>_d.m_dAlphaTestReference;
        public A3DETextureWrappingMode m_eTextureWrappingModeS=>_d.m_eTextureWrappingModeS;
        public A3DETextureWrappingMode m_eTextureWrappingModeT=>_d.m_eTextureWrappingModeT;
        public IntPtr m_pTextureTransfo=>_d.m_pTextureTransfo;

        private A3DGraphTextureDefinitionData _d;
    }
    public class A3DGraphTextureApplicationDataWrapper
    {
        public A3DGraphTextureApplicationDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DGraphTextureApplicationDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiMaterialIndex=>_d.m_uiMaterialIndex;
        public uint m_uiTextureDefinitionIndex=>_d.m_uiTextureDefinitionIndex;
        public int m_iUVCoordinatesIndex=>_d.m_iUVCoordinatesIndex;
        public uint m_uiNextTextureApplicationIndex=>_d.m_uiNextTextureApplicationIndex;

        private A3DGraphTextureApplicationData _d;
    }
    public class A3DDrawCallbacksDataWrapper
    {
        public A3DDrawCallbacksDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DDrawCallbacksDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pfuncPushMatrix=>_d.m_pfuncPushMatrix;
        public IntPtr m_pfuncPopMatrix=>_d.m_pfuncPopMatrix;
        public IntPtr m_pfuncMultMatrix=>_d.m_pfuncMultMatrix;
        public IntPtr m_pfuncBegin=>_d.m_pfuncBegin;
        public IntPtr m_pfuncEnd=>_d.m_pfuncEnd;
        public IntPtr m_pfuncSetTessellationPoints=>_d.m_pfuncSetTessellationPoints;
        public IntPtr m_pfuncTriangle=>_d.m_pfuncTriangle;
        public IntPtr m_pfuncTriangleFan=>_d.m_pfuncTriangleFan;
        public IntPtr m_pfuncTriangleStripe=>_d.m_pfuncTriangleStripe;
        public IntPtr m_pfuncTriangleOneNormal=>_d.m_pfuncTriangleOneNormal;
        public IntPtr m_pfuncTriangleFanOneNormal=>_d.m_pfuncTriangleFanOneNormal;
        public IntPtr m_pfuncTriangleStripeOneNormal=>_d.m_pfuncTriangleStripeOneNormal;
        public IntPtr m_pfuncTriangleTextured=>_d.m_pfuncTriangleTextured;
        public IntPtr m_pfuncTriangleFanTextured=>_d.m_pfuncTriangleFanTextured;
        public IntPtr m_pfuncTriangleStripeTextured=>_d.m_pfuncTriangleStripeTextured;
        public IntPtr m_pfuncTriangleOneNormalTextured=>_d.m_pfuncTriangleOneNormalTextured;
        public IntPtr m_pfuncTriangleFanOneNormalTextured=>_d.m_pfuncTriangleFanOneNormalTextured;
        public IntPtr m_pfuncTriangleStripeOneNormalTextured=>_d.m_pfuncTriangleStripeOneNormalTextured;
        public IntPtr m_pfuncMaterial=>_d.m_pfuncMaterial;
        public IntPtr m_pfuncGetDrawContext=>_d.m_pfuncGetDrawContext;
        public IntPtr m_pfuncMarkupTriangle=>_d.m_pfuncMarkupTriangle;
        public IntPtr m_pfuncUnProject=>_d.m_pfuncUnProject;
        public IntPtr m_pfuncBeginFrameDraw=>_d.m_pfuncBeginFrameDraw;
        public IntPtr m_pfuncEndFrameDraw=>_d.m_pfuncEndFrameDraw;
        public IntPtr m_pfuncBeginFixedSize=>_d.m_pfuncBeginFixedSize;
        public IntPtr m_pfuncEndFixedSize=>_d.m_pfuncEndFixedSize;
        public IntPtr m_pfuncCylinder=>_d.m_pfuncCylinder;
        public IntPtr m_pfuncPolygon=>_d.m_pfuncPolygon;
        public IntPtr m_pfuncBeginLineWidth=>_d.m_pfuncBeginLineWidth;
        public IntPtr m_pfuncEndLineWidth=>_d.m_pfuncEndLineWidth;
        public IntPtr m_pfuncPoint=>_d.m_pfuncPoint;
        public IntPtr m_pfuncFont=>_d.m_pfuncFont;
        public IntPtr m_pfuncBeginLineStipple=>_d.m_pfuncBeginLineStipple;
        public IntPtr m_pfuncEndLineStipple=>_d.m_pfuncEndLineStipple;
        public IntPtr m_pfuncSymbol=>_d.m_pfuncSymbol;
        public IntPtr m_pfuncPolyLine=>_d.m_pfuncPolyLine;
        public IntPtr m_pfuncText=>_d.m_pfuncText;
        public IntPtr m_pfuncPattern=>_d.m_pfuncPattern;
        public IntPtr m_pfuncPicture=>_d.m_pfuncPicture;
        public IntPtr m_pfuncBeginMaterial=>_d.m_pfuncBeginMaterial;
        public IntPtr m_pfuncEndMaterial=>_d.m_pfuncEndMaterial;
        public IntPtr m_pfuncColor=>_d.m_pfuncColor;

        private A3DDrawCallbacksData _d;
    }
    public class A3DDrawingModelDataWrapper
    {
        public A3DDrawingModelDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DDrawingModelDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DDrawingModelGet( p, ref _d );
            }
        }

        ~A3DDrawingModelDataWrapper()
        {
            API.A3DDrawingModelGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiDrwSheetsSize=>_d.m_uiDrwSheetsSize;
        public IntPtr m_ppDrwSheets=>_d.m_ppDrwSheets;
        public uint m_uiActiveSheet=>_d.m_uiActiveSheet;

        private A3DDrawingModelData _d;
    }
    public class A3DDrawingSheetFormatDataWrapper
    {
        public A3DDrawingSheetFormatDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DDrawingSheetFormatDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DDrawingSheetFormatGet( p, ref _d );
            }
        }

        ~A3DDrawingSheetFormatDataWrapper()
        {
            API.A3DDrawingSheetFormatGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_pcName => _d.m_pcName;
        public A3DVector2dData m_sSize=>_d.m_sSize;

        private A3DDrawingSheetFormatData _d;
    }
    public class A3DDrawingSheetDataWrapper
    {
        public A3DDrawingSheetDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DDrawingSheetDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DDrawingSheetGet( p, ref _d );
            }
        }

        ~A3DDrawingSheetDataWrapper()
        {
            API.A3DDrawingSheetGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pFormat=>_d.m_pFormat;
        public A3DVector2dData m_sSize=>_d.m_sSize;
        public A3DVector2dData m_sRefPoint=>_d.m_sRefPoint;
        public double m_dScale=>_d.m_dScale;
        public bool m_bDrawFrame => _d.m_bDrawFrame;
        public ushort m_usStyle=>_d.m_usStyle;
        public ushort m_usBackgroundStyle=>_d.m_usBackgroundStyle;
        public IntPtr m_pBackgroundBlocks=>_d.m_pBackgroundBlocks;
        public uint m_uiDrwBlocksSize=>_d.m_uiDrwBlocksSize;
        public IntPtr m_ppDrwBlocks=>_d.m_ppDrwBlocks;
        public uint m_uiDrwViewsSize=>_d.m_uiDrwViewsSize;
        public IntPtr m_ppDrwViews=>_d.m_ppDrwViews;

        private A3DDrawingSheetData _d;
    }
    public class A3DDrawingClipFrameDataWrapper
    {
        public A3DDrawingClipFrameDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DDrawingClipFrameDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DDrawingClipFrameGet( p, ref _d );
            }
        }

        ~A3DDrawingClipFrameDataWrapper()
        {
            API.A3DDrawingClipFrameGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public ushort m_uiStyle=>_d.m_uiStyle;
        public bool m_bDrawBound => _d.m_bDrawBound;
        public bool m_bClipBound => _d.m_bClipBound;
        public A3DEDrawingClipFrameType m_eType=>_d.m_eType;
        public A3DDomainData m_sRectangularBox=>_d.m_sRectangularBox;
        public IntPtr m_pCurve=>_d.m_pCurve;

        private A3DDrawingClipFrameData _d;
    }
    public class A3DDrawingViewDataWrapper
    {
        public A3DDrawingViewDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DDrawingViewDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DDrawingViewGet( p, ref _d );
            }
        }

        ~A3DDrawingViewDataWrapper()
        {
            API.A3DDrawingViewGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DEDrawingViewType m_eType=>_d.m_eType;
        public IntPtr m_pClipFrame=>_d.m_pClipFrame;
        public A3DVector2dData m_sOriginOnSheet=>_d.m_sOriginOnSheet;
        public A3DVector2dData m_sOffsetLocation=>_d.m_sOffsetLocation;
        public double m_dScale=>_d.m_dScale;
        public double m_dAngle=>_d.m_dAngle;
        public uint m_uiSrcFilesNamesSize=>_d.m_uiSrcFilesNamesSize;
        public IntPtr m_ppcSrcFilesNames=>_d.m_ppcSrcFilesNames;
        public IntPtr m_pLocalBlocks=>_d.m_pLocalBlocks;
        public uint m_uiDrwBlocksSize=>_d.m_uiDrwBlocksSize;
        public IntPtr m_ppDrwBlocks=>_d.m_ppDrwBlocks;
        public IntPtr m_pBaseView=>_d.m_pBaseView;
        public IntPtr m_pFilter=>_d.m_pFilter;

        private A3DDrawingViewData _d;
    }
    public class A3DDrawingBlockBasicDataWrapper
    {
        public A3DDrawingBlockBasicDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DDrawingBlockBasicDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DDrawingBlockBasicGet( p, ref _d );
            }
        }

        ~A3DDrawingBlockBasicDataWrapper()
        {
            API.A3DDrawingBlockBasicGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiDrwEntitiesSize=>_d.m_uiDrwEntitiesSize;
        public IntPtr m_ppDrwEntities=>_d.m_ppDrwEntities;
        public uint m_uiMarkupsSize=>_d.m_uiMarkupsSize;
        public IntPtr m_ppMarkups=>_d.m_ppMarkups;
        public uint m_uiDrwBlocksSize=>_d.m_uiDrwBlocksSize;
        public IntPtr m_ppDrwBlocks=>_d.m_ppDrwBlocks;

        private A3DDrawingBlockBasicData _d;
    }
    public class A3DDrawingBlockOperatorDataWrapper
    {
        public A3DDrawingBlockOperatorDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DDrawingBlockOperatorDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DDrawingBlockOperatorGet( p, ref _d );
            }
        }

        ~A3DDrawingBlockOperatorDataWrapper()
        {
            API.A3DDrawingBlockOperatorGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DEDrawingOperatorType m_eType=>_d.m_eType;
        public IntPtr m_pViewResult=>_d.m_pViewResult;
        public uint m_uiDrwEntitiesSize=>_d.m_uiDrwEntitiesSize;
        public IntPtr m_ppDrwEntities=>_d.m_ppDrwEntities;
        public uint m_uiMarkupsSize=>_d.m_uiMarkupsSize;
        public IntPtr m_ppMarkups=>_d.m_ppMarkups;
        public uint m_uiDrwBlocksSize=>_d.m_uiDrwBlocksSize;
        public IntPtr m_ppDrwBlocks=>_d.m_ppDrwBlocks;

        private A3DDrawingBlockOperatorData _d;
    }
    public class A3DDrawingCurveDataWrapper
    {
        public A3DDrawingCurveDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DDrawingCurveDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DDrawingCurveGet( p, ref _d );
            }
        }

        ~A3DDrawingCurveDataWrapper()
        {
            API.A3DDrawingCurveGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pCurve=>_d.m_pCurve;
        public A3DIntervalData m_sTrimInterval=>_d.m_sTrimInterval;
        public IntPtr m_pPlane=>_d.m_pPlane;

        private A3DDrawingCurveData _d;
    }
    public class A3DDrawingFilledAreaDataWrapper
    {
        public A3DDrawingFilledAreaDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DDrawingFilledAreaDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DDrawingFilledAreaGet( p, ref _d );
            }
        }

        ~A3DDrawingFilledAreaDataWrapper()
        {
            API.A3DDrawingFilledAreaGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DEDrawingFilledAreaMode m_eMode=>_d.m_eMode;
        public uint m_uiPatternIndex=>_d.m_uiPatternIndex;
        public bool m_bIgnoreViewTransfo => _d.m_bIgnoreViewTransfo;
        public uint m_uiBoundaryCurvesSize=>_d.m_uiBoundaryCurvesSize;
        public IntPtr m_ppBoundaryCurves=>_d.m_ppBoundaryCurves;

        private A3DDrawingFilledAreaData _d;
    }
    public class A3DDrawingPictureDataWrapper
    {
        public A3DDrawingPictureDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DDrawingPictureDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DDrawingPictureGet( p, ref _d );
            }
        }

        ~A3DDrawingPictureDataWrapper()
        {
            API.A3DDrawingPictureGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiPictureIndex=>_d.m_uiPictureIndex;
        public A3DVector2dData m_sPosition=>_d.m_sPosition;
        public A3DVector2dData m_sSize=>_d.m_sSize;

        private A3DDrawingPictureData _d;
    }
    public class A3DDrawingVerticesDataWrapper
    {
        public A3DDrawingVerticesDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DDrawingVerticesDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DDrawingVerticesGet( p, ref _d );
            }
        }

        ~A3DDrawingVerticesDataWrapper()
        {
            API.A3DDrawingVerticesGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiPointsSize=>_d.m_uiPointsSize;
        public IntPtr m_pPoints=>_d.m_pPoints;

        private A3DDrawingVerticesData _d;
    }
    public class A3DThumbnailDataWrapper
    {
        public A3DThumbnailDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DThumbnailDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pcBuffer=>_d.m_pcBuffer;
        public A3DEPictureDataFormat m_eFormat=>_d.m_eFormat;
        public uint m_iLength=>_d.m_iLength;

        private A3DThumbnailData _d;
    }
    public class A3DFileInformationDataWrapper
    {
        public A3DFileInformationDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DFileInformationDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DEModellerType m_eModellerType=>_d.m_eModellerType;
        public string m_pcModelName => _d.m_pcModelName;
        public string m_pcSoftwareVersion => _d.m_pcSoftwareVersion;
        public string m_pcAuthor => _d.m_pcAuthor;
        public string m_pcOrganization => _d.m_pcOrganization;
        public int m_iTimeStamp=>_d.m_iTimeStamp;

        private A3DFileInformationData _d;
    }
    public class A3DFileContextDataWrapper
    {
        public A3DFileContextDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DFileContextDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_pcFileName => _d.m_pcFileName;
        public uint m_uiNbContexts=>_d.m_uiNbContexts;
        public IntPtr m_apcContexts=>_d.m_apcContexts;

        private A3DFileContextData _d;
    }
    public class A3DRWParamsExportParasolidDataWrapper
    {
        public A3DRWParamsExportParasolidDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsExportParasolidDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bSaveSolidsAsFaces => _d.m_bSaveSolidsAsFaces;
        public bool m_bWriteTessellation => _d.m_bWriteTessellation;
        public bool m_bWriteBlankedEntities => _d.m_bWriteBlankedEntities;
        public string m_pcApplication => _d.m_pcApplication;
        public string m_pcVersion => _d.m_pcVersion;
        public bool m_bBStrictAssemblyStructure => _d.m_bBStrictAssemblyStructure;
        public bool m_bExplodeMultiBodies => _d.m_bExplodeMultiBodies;
        public bool m_bMakePointsWithCoordinateSystems => _d.m_bMakePointsWithCoordinateSystems;

        private A3DRWParamsExportParasolidData _d;
    }
    public class A3DRWParamsTranslateToPkPartsDataWrapper
    {
        public A3DRWParamsTranslateToPkPartsDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsTranslateToPkPartsDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DETranslateToPkPartsHealing m_eHealing=>_d.m_eHealing;
        public A3DETranslateToPkPartsAccurate m_eComputeAccurateEdges=>_d.m_eComputeAccurateEdges;
        public bool m_bDisjoinIfFaceFaceError => _d.m_bDisjoinIfFaceFaceError;
        public bool m_bSew => _d.m_bSew;
        public double m_dSewingTolerance=>_d.m_dSewingTolerance;
        public A3DETranslateToPkPartsSimplifyGeometry m_eSimplifyGeometry=>_d.m_eSimplifyGeometry;
        public A3DETranslateToPkPartsMergeEntities m_eMergeEntities=>_d.m_eMergeEntities;
        public string m_pcPSBodyShopPath => _d.m_pcPSBodyShopPath;
        public IntPtr m_pMapper=>_d.m_pMapper;
        public bool m_bUseColour2Attribute => _d.m_bUseColour2Attribute;
        public bool m_bUseUNameAttribute => _d.m_bUseUNameAttribute;
        public bool m_bUseLayerAttribute => _d.m_bUseLayerAttribute;
        public uint m_uiNbProc=>_d.m_uiNbProc;
        public bool m_bExportNormalsWithTessellation => _d.m_bExportNormalsWithTessellation;

        private A3DRWParamsTranslateToPkPartsData _d;
    }
    public class A3DRWParamsExportAcisDataWrapper
    {
        public A3DRWParamsExportAcisDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DRWParamsExportAcisDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bSaveAsMillimeter => _d.m_bSaveAsMillimeter;
        public bool m_bSaveAsBinary => _d.m_bSaveAsBinary;
        public bool m_bForceSurfaceDuplication => _d.m_bForceSurfaceDuplication;

        private A3DRWParamsExportAcisData _d;
    }
    public class A3DRiRepresentationItemDataWrapper
    {
        public A3DRiRepresentationItemDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DRiRepresentationItemDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DRiRepresentationItemGet( p, ref _d );
            }
        }

        ~A3DRiRepresentationItemDataWrapper()
        {
            API.A3DRiRepresentationItemGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pTessBase=>_d.m_pTessBase;
        public IntPtr m_pCoordinateSystem=>_d.m_pCoordinateSystem;

        private A3DRiRepresentationItemData _d;
    }
    public class A3DRiSetDataWrapper
    {
        public A3DRiSetDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DRiSetDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DRiSetGet( p, ref _d );
            }
        }

        ~A3DRiSetDataWrapper()
        {
            API.A3DRiSetGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiRepItemsSize=>_d.m_uiRepItemsSize;
        public IntPtr m_ppRepItems=>_d.m_ppRepItems;

        private A3DRiSetData _d;
    }
    public class A3DRiPointSetDataWrapper
    {
        public A3DRiPointSetDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DRiPointSetDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DRiPointSetGet( p, ref _d );
            }
        }

        ~A3DRiPointSetDataWrapper()
        {
            API.A3DRiPointSetGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiSize=>_d.m_uiSize;
        public IntPtr m_pPts=>_d.m_pPts;

        private A3DRiPointSetData _d;
    }
    public class A3DRiDirectionDataWrapper
    {
        public A3DRiDirectionDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DRiDirectionDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DRiDirectionGet( p, ref _d );
            }
        }

        ~A3DRiDirectionDataWrapper()
        {
            API.A3DRiDirectionGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bHasOrigin => _d.m_bHasOrigin;
        public A3DVector3dData m_sOrigin=>_d.m_sOrigin;
        public A3DVector3dData m_sDirection=>_d.m_sDirection;

        private A3DRiDirectionData _d;
    }
    public class A3DRiCoordinateSystemDataWrapper
    {
        public A3DRiCoordinateSystemDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DRiCoordinateSystemDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DRiCoordinateSystemGet( p, ref _d );
            }
        }

        ~A3DRiCoordinateSystemDataWrapper()
        {
            API.A3DRiCoordinateSystemGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pTransformation=>_d.m_pTransformation;

        private A3DRiCoordinateSystemData _d;
    }
    public class A3DRiCurveDataWrapper
    {
        public A3DRiCurveDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DRiCurveDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DRiCurveGet( p, ref _d );
            }
        }

        ~A3DRiCurveDataWrapper()
        {
            API.A3DRiCurveGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pBody=>_d.m_pBody;

        private A3DRiCurveData _d;
    }
    public class A3DRiPlaneDataWrapper
    {
        public A3DRiPlaneDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DRiPlaneDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DRiPlaneGet( p, ref _d );
            }
        }

        ~A3DRiPlaneDataWrapper()
        {
            API.A3DRiPlaneGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pBrepData=>_d.m_pBrepData;

        private A3DRiPlaneData _d;
    }
    public class A3DRiBrepModelDataWrapper
    {
        public A3DRiBrepModelDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DRiBrepModelDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DRiBrepModelGet( p, ref _d );
            }
        }

        ~A3DRiBrepModelDataWrapper()
        {
            API.A3DRiBrepModelGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bSolid => _d.m_bSolid;
        public IntPtr m_pBrepData=>_d.m_pBrepData;

        private A3DRiBrepModelData _d;
    }
    public class A3DRiPolyBrepModelDataWrapper
    {
        public A3DRiPolyBrepModelDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DRiPolyBrepModelDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DRiPolyBrepModelGet( p, ref _d );
            }
        }

        ~A3DRiPolyBrepModelDataWrapper()
        {
            API.A3DRiPolyBrepModelGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIsClosed => _d.m_bIsClosed;

        private A3DRiPolyBrepModelData _d;
    }
    public class A3DRiPolyWireDataWrapper
    {
        public A3DRiPolyWireDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DRiPolyWireDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DRiPolyWireGet( p, ref _d );
            }
        }

        ~A3DRiPolyWireDataWrapper()
        {
            API.A3DRiPolyWireGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;

        private A3DRiPolyWireData _d;
    }
    public class A3DFRMFeatureTreeDataWrapper
    {
        public A3DFRMFeatureTreeDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DFRMFeatureTreeDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DFRMFeatureTreeGet( p, ref _d );
            }
        }

        ~A3DFRMFeatureTreeDataWrapper()
        {
            API.A3DFRMFeatureTreeGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiParametersSize=>_d.m_uiParametersSize;
        public IntPtr m_ppsParameters=>_d.m_ppsParameters;
        public uint m_uiIntermediateGeometriesSize=>_d.m_uiIntermediateGeometriesSize;
        public IntPtr m_ppIntermediateGeometries=>_d.m_ppIntermediateGeometries;
        public uint m_uiInternalGeometriesSize=>_d.m_uiInternalGeometriesSize;
        public IntPtr m_ppInternalGeometries=>_d.m_ppInternalGeometries;

        private A3DFRMFeatureTreeData _d;
    }
    public class A3DFRMParameterDataWrapper
    {
        public A3DFRMParameterDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DFRMParameterDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DFRMParameterGet( p, ref _d );
            }
        }

        ~A3DFRMParameterDataWrapper()
        {
            API.A3DFRMParameterGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiFeatureSize=>_d.m_uiFeatureSize;
        public IntPtr m_ppFeatures=>_d.m_ppFeatures;
        public EA3DFRMParameterType m_eType=>_d.m_eType;

        private A3DFRMParameterData _d;
    }
    public class A3DFRMFeatureTypeDataWrapper
    {
        public A3DFRMFeatureTypeDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DFRMFeatureTypeDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public EA3DFRMFamily m_eFamily=>_d.m_eFamily;
        public uint m_uiType=>_d.m_uiType;
        public EA3DFRMStatus m_eStatus=>_d.m_eStatus;

        private A3DFRMFeatureTypeData _d;
    }
    public class A3DFRMStringDataWrapper
    {
        public A3DFRMStringDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DFRMStringDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiValuesSize=>_d.m_uiValuesSize;
        public IntPtr m_ppcValues=>_d.m_ppcValues;

        private A3DFRMStringData _d;
    }
    public class A3DFRMDoubleDataWrapper
    {
        public A3DFRMDoubleDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DFRMDoubleDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiValuesSize=>_d.m_uiValuesSize;
        public IntPtr m_pdValues=>_d.m_pdValues;

        private A3DFRMDoubleData _d;
    }
    public class A3DFRMIntegerDataWrapper
    {
        public A3DFRMIntegerDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DFRMIntegerDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiValuesSize=>_d.m_uiValuesSize;
        public IntPtr m_piValues=>_d.m_piValues;

        private A3DFRMIntegerData _d;
    }
    public class A3DFRMFeatureLinkedItemDataWrapper
    {
        public A3DFRMFeatureLinkedItemDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DFRMFeatureLinkedItemDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DFRMFeatureLinkedItemGet( p, ref _d );
            }
        }

        ~A3DFRMFeatureLinkedItemDataWrapper()
        {
            API.A3DFRMFeatureLinkedItemGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public EA3DFRMLinkType m_eType=>_d.m_eType;
        public IntPtr m_pTargetProductOccurrence=>_d.m_pTargetProductOccurrence;
        public IntPtr m_pReference=>_d.m_pReference;

        private A3DFRMFeatureLinkedItemData _d;
    }
    public class A3DFRMFeatureDataWrapper
    {
        public A3DFRMFeatureDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DFRMFeatureDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DFRMFeatureGet( p, ref _d );
            }
        }

        ~A3DFRMFeatureDataWrapper()
        {
            API.A3DFRMFeatureGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DFRMFeatureTypeData m_sType=>_d.m_sType;
        public uint m_uiParametersSize=>_d.m_uiParametersSize;
        public IntPtr m_ppParameters=>_d.m_ppParameters;
        public EA3DFRMDataType m_eDataType=>_d.m_eDataType;
        public uint m_uiConnectionSize=>_d.m_uiConnectionSize;
        public IntPtr m_ppConnections=>_d.m_ppConnections;
        public bool m_bIsNode => _d.m_bIsNode;
        public bool m_bIsSubTree => _d.m_bIsSubTree;

        private A3DFRMFeatureData _d;
    }
    public class A3DFRMFeatureGeomEntitiesDataWrapper
    {
        public A3DFRMFeatureGeomEntitiesDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DFRMFeatureGeomEntitiesDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiGeomEntitiesSize=>_d.m_uiGeomEntitiesSize;
        public IntPtr m_ppGeomEntities=>_d.m_ppGeomEntities;

        private A3DFRMFeatureGeomEntitiesData _d;
    }
    public class A3DCrvNurbsDataWrapper
    {
        public A3DCrvNurbsDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DCrvNurbsDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DCrvNurbsGet( p, ref _d );
            }
        }

        ~A3DCrvNurbsDataWrapper()
        {
            API.A3DCrvNurbsGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIs2D => _d.m_bIs2D;
        public bool m_bRational => _d.m_bRational;
        public uint m_uiDegree=>_d.m_uiDegree;
        public uint m_uiCtrlSize=>_d.m_uiCtrlSize;
        public IntPtr m_pCtrlPts=>_d.m_pCtrlPts;
        public uint m_uiWeightSize=>_d.m_uiWeightSize;
        public IntPtr m_pdWeights=>_d.m_pdWeights;
        public uint m_uiKnotSize=>_d.m_uiKnotSize;
        public IntPtr m_pdKnots=>_d.m_pdKnots;
        public A3DEKnotType m_eKnotType=>_d.m_eKnotType;
        public A3DEBSplineCurveForm m_eCurveForm=>_d.m_eCurveForm;

        private A3DCrvNurbsData _d;
    }
    public class A3DCrvLineDataWrapper
    {
        public A3DCrvLineDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DCrvLineDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DCrvLineGet( p, ref _d );
            }
        }

        ~A3DCrvLineDataWrapper()
        {
            API.A3DCrvLineGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIs2D => _d.m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DParameterizationData m_sParam=>_d.m_sParam;

        private A3DCrvLineData _d;
    }
    public class A3DCrvCircleDataWrapper
    {
        public A3DCrvCircleDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DCrvCircleDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DCrvCircleGet( p, ref _d );
            }
        }

        ~A3DCrvCircleDataWrapper()
        {
            API.A3DCrvCircleGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIs2D => _d.m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DParameterizationData m_sParam=>_d.m_sParam;
        public double m_dRadius=>_d.m_dRadius;

        private A3DCrvCircleData _d;
    }
    public class A3DCrvEllipseDataWrapper
    {
        public A3DCrvEllipseDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DCrvEllipseDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DCrvEllipseGet( p, ref _d );
            }
        }

        ~A3DCrvEllipseDataWrapper()
        {
            API.A3DCrvEllipseGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIs2D => _d.m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DParameterizationData m_sParam=>_d.m_sParam;
        public double m_dXRadius=>_d.m_dXRadius;
        public double m_dYRadius=>_d.m_dYRadius;

        private A3DCrvEllipseData _d;
    }
    public class A3DCrvParabolaDataWrapper
    {
        public A3DCrvParabolaDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DCrvParabolaDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DCrvParabolaGet( p, ref _d );
            }
        }

        ~A3DCrvParabolaDataWrapper()
        {
            API.A3DCrvParabolaGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIs2D => _d.m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DParameterizationData m_sParam=>_d.m_sParam;
        public double m_dFocal=>_d.m_dFocal;
        public byte m_cParamType=>_d.m_cParamType;

        private A3DCrvParabolaData _d;
    }
    public class A3DCrvHyperbolaDataWrapper
    {
        public A3DCrvHyperbolaDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DCrvHyperbolaDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DCrvHyperbolaGet( p, ref _d );
            }
        }

        ~A3DCrvHyperbolaDataWrapper()
        {
            API.A3DCrvHyperbolaGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIs2D => _d.m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DParameterizationData m_sParam=>_d.m_sParam;
        public double m_dSemiAxis=>_d.m_dSemiAxis;
        public double m_dSemiImageAxis=>_d.m_dSemiImageAxis;
        public byte m_cParamType=>_d.m_cParamType;

        private A3DCrvHyperbolaData _d;
    }
    public class A3DCrvPolyLineDataWrapper
    {
        public A3DCrvPolyLineDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DCrvPolyLineDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DCrvPolyLineGet( p, ref _d );
            }
        }

        ~A3DCrvPolyLineDataWrapper()
        {
            API.A3DCrvPolyLineGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIs2D => _d.m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DParameterizationData m_sParam=>_d.m_sParam;
        public uint m_uiSize=>_d.m_uiSize;
        public IntPtr m_pPts=>_d.m_pPts;

        private A3DCrvPolyLineData _d;
    }
    public class A3DCrvCompositeDataWrapper
    {
        public A3DCrvCompositeDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DCrvCompositeDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DCrvCompositeGet( p, ref _d );
            }
        }

        ~A3DCrvCompositeDataWrapper()
        {
            API.A3DCrvCompositeGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIs2D => _d.m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DParameterizationData m_sParam=>_d.m_sParam;
        public uint m_uiSize=>_d.m_uiSize;
        public IntPtr m_ppCurves=>_d.m_ppCurves;
        public IntPtr m_pbSenses=>_d.m_pbSenses;
        public bool m_bClosed => _d.m_bClosed;

        private A3DCrvCompositeData _d;
    }
    public class A3DCrvEquationDataWrapper
    {
        public A3DCrvEquationDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DCrvEquationDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DCrvEquationGet( p, ref _d );
            }
        }

        ~A3DCrvEquationDataWrapper()
        {
            API.A3DCrvEquationGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIs2D => _d.m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DParameterizationData m_sParam=>_d.m_sParam;
        public A3DIntervalData m_sMaxInterval=>_d.m_sMaxInterval;
        public IntPtr m_pFunctionX=>_d.m_pFunctionX;
        public IntPtr m_pFunctionY=>_d.m_pFunctionY;
        public IntPtr m_pFunctionZ=>_d.m_pFunctionZ;

        private A3DCrvEquationData _d;
    }
    public class A3DCrvTransformDataWrapper
    {
        public A3DCrvTransformDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DCrvTransformDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DCrvTransformGet( p, ref _d );
            }
        }

        ~A3DCrvTransformDataWrapper()
        {
            API.A3DCrvTransformGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIs2D => _d.m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DParameterizationData m_sParam=>_d.m_sParam;
        public IntPtr m_pTransfo=>_d.m_pTransfo;
        public IntPtr m_pBasisCrv=>_d.m_pBasisCrv;

        private A3DCrvTransformData _d;
    }
    public class A3DCrvOnSurfDataWrapper
    {
        public A3DCrvOnSurfDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DCrvOnSurfDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DCrvOnSurfGet( p, ref _d );
            }
        }

        ~A3DCrvOnSurfDataWrapper()
        {
            API.A3DCrvOnSurfGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIs2D => _d.m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DParameterizationData m_sParam=>_d.m_sParam;
        public IntPtr m_pUVCurve=>_d.m_pUVCurve;
        public IntPtr m_pSurface=>_d.m_pSurface;

        private A3DCrvOnSurfData _d;
    }
    public class A3DCrvOffsetDataWrapper
    {
        public A3DCrvOffsetDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DCrvOffsetDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DCrvOffsetGet( p, ref _d );
            }
        }

        ~A3DCrvOffsetDataWrapper()
        {
            API.A3DCrvOffsetGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIs2D => _d.m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DParameterizationData m_sParam=>_d.m_sParam;
        public IntPtr m_pBasisCrv=>_d.m_pBasisCrv;
        public double m_dOffset=>_d.m_dOffset;
        public A3DVector3dData m_sVector=>_d.m_sVector;

        private A3DCrvOffsetData _d;
    }
    public class A3DCrvHelixPitchCstDataWrapper
    {
        public A3DCrvHelixPitchCstDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DCrvHelixPitchCstDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bTrigonometricOrientation => _d.m_bTrigonometricOrientation;
        public A3DVector3dData m_sStartPoint=>_d.m_sStartPoint;
        public A3DVector3dData m_sOrigin=>_d.m_sOrigin;
        public A3DVector3dData m_sDirection=>_d.m_sDirection;
        public double m_dPitch=>_d.m_dPitch;
        public double m_dRadiusEvolution=>_d.m_dRadiusEvolution;

        private A3DCrvHelixPitchCstData _d;
    }
    public class A3DCrvHelixPitchVarDataWrapper
    {
        public A3DCrvHelixPitchVarDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DCrvHelixPitchVarDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bTrigonometricOrientation => _d.m_bTrigonometricOrientation;
        public A3DVector3dData m_sStartPoint=>_d.m_sStartPoint;
        public A3DVector3dData m_sUnitZ=>_d.m_sUnitZ;
        public A3DVector3dData m_sUnitU=>_d.m_sUnitU;
        public IntPtr m_psRadiusLaw=>_d.m_psRadiusLaw;
        public IntPtr m_psZLaw=>_d.m_psZLaw;
        public IntPtr m_psThetaLaw=>_d.m_psThetaLaw;
        public double m_dRatioU=>_d.m_dRatioU;
        public double m_dRatioV=>_d.m_dRatioV;
        public double m_dRatioZ=>_d.m_dRatioZ;
        public double m_dTheta0=>_d.m_dTheta0;

        private A3DCrvHelixPitchVarData _d;
    }
    public class A3DCrvHelixDataWrapper
    {
        public A3DCrvHelixDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DCrvHelixDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DCrvHelixGet( p, ref _d );
            }
        }

        ~A3DCrvHelixDataWrapper()
        {
            API.A3DCrvHelixGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIs2D => _d.m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DParameterizationData m_sParam=>_d.m_sParam;
        public A3DEHelixType m_eType=>_d.m_eType;
        public A3DCrvHelixPitchCstData m_sCstHelixData=>_d.m_sCstHelixData;
        public A3DCrvHelixPitchVarData m_sVarHelixData=>_d.m_sVarHelixData;

        private A3DCrvHelixData _d;
    }
    public class A3DCrossingPointsCrvIntersectionDataWrapper
    {
        public A3DCrossingPointsCrvIntersectionDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DCrossingPointsCrvIntersectionDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DVector3dData m_sPosition=>_d.m_sPosition;
        public A3DVector2dData m_sUVPosition1=>_d.m_sUVPosition1;
        public A3DVector2dData m_sUVPosition2=>_d.m_sUVPosition2;
        public A3DVector3dData m_sTangent=>_d.m_sTangent;
        public double m_dParameter=>_d.m_dParameter;
        public double m_dScale=>_d.m_dScale;
        public byte m_cFlags=>_d.m_cFlags;

        private A3DCrossingPointsCrvIntersectionData _d;
    }
    public class A3DCrvIntersectionDataWrapper
    {
        public A3DCrvIntersectionDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DCrvIntersectionDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DCrvIntersectionGet( p, ref _d );
            }
        }

        ~A3DCrvIntersectionDataWrapper()
        {
            API.A3DCrvIntersectionGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIs2D => _d.m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DParameterizationData m_sParam=>_d.m_sParam;
        public IntPtr m_pSurface1=>_d.m_pSurface1;
        public IntPtr m_pSurface2=>_d.m_pSurface2;
        public bool m_bSensSurface1 => _d.m_bSensSurface1;
        public bool m_bSensSurface2 => _d.m_bSensSurface2;
        public bool m_bSens => _d.m_bSens;
        public uint m_uiCrossingPtsSize=>_d.m_uiCrossingPtsSize;
        public IntPtr m_pCrossingPts=>_d.m_pCrossingPts;
        public A3DVector3dData m_sStartLimitPoint=>_d.m_sStartLimitPoint;
        public A3DEIntersectionLimitType m_sStartLimitType=>_d.m_sStartLimitType;
        public A3DVector3dData m_sEndLimitPoint=>_d.m_sEndLimitPoint;
        public A3DEIntersectionLimitType m_sEndLimitType=>_d.m_sEndLimitType;
        public double m_dChordalError=>_d.m_dChordalError;
        public double m_dAngularError=>_d.m_dAngularError;
        public bool m_bParameterizationDefinitionRespected => _d.m_bParameterizationDefinitionRespected;

        private A3DCrvIntersectionData _d;
    }
    public class A3DCrvBlend02BoundaryDataWrapper
    {
        public A3DCrvBlend02BoundaryDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DCrvBlend02BoundaryDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DCrvBlend02BoundaryGet( p, ref _d );
            }
        }

        ~A3DCrvBlend02BoundaryDataWrapper()
        {
            API.A3DCrvBlend02BoundaryGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bIs2D => _d.m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DParameterizationData m_sParam=>_d.m_sParam;
        public IntPtr m_pBlend=>_d.m_pBlend;
        public uint m_uiBlend=>_d.m_uiBlend;
        public uint m_uiCrossingPtsSize=>_d.m_uiCrossingPtsSize;
        public IntPtr m_pCrossingPts=>_d.m_pCrossingPts;
        public double m_dChordalError=>_d.m_dChordalError;
        public double m_dAngularError=>_d.m_dAngularError;
        public IntPtr m_pBoundingSurface=>_d.m_pBoundingSurface;
        public bool m_bBoundingSurfaceSens => _d.m_bBoundingSurfaceSens;
        public bool m_bIntersectionOrder => _d.m_bIntersectionOrder;
        public bool m_bIntersectionCurveSens => _d.m_bIntersectionCurveSens;
        public double m_dBaseParameter=>_d.m_dBaseParameter;
        public double m_dBaseScale=>_d.m_dBaseScale;
        public A3DVector3dData m_sStartLimitPoint=>_d.m_sStartLimitPoint;
        public A3DEIntersectionLimitType m_sStartLimitType=>_d.m_sStartLimitType;
        public A3DVector3dData m_sEndLimitPoint=>_d.m_sEndLimitPoint;
        public A3DEIntersectionLimitType m_sEndLimitType=>_d.m_sEndLimitType;

        private A3DCrvBlend02BoundaryData _d;
    }
    public class A3DSurfNurbsDataWrapper
    {
        public A3DSurfNurbsDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DSurfNurbsDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DSurfNurbsGet( p, ref _d );
            }
        }

        ~A3DSurfNurbsDataWrapper()
        {
            API.A3DSurfNurbsGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DEKnotType m_eKnotType=>_d.m_eKnotType;
        public A3DEBSplineSurfaceForm m_eSurfaceForm=>_d.m_eSurfaceForm;
        public uint m_uiUDegree=>_d.m_uiUDegree;
        public uint m_uiVDegree=>_d.m_uiVDegree;
        public uint m_uiUKnotSize=>_d.m_uiUKnotSize;
        public uint m_uiVKnotSize=>_d.m_uiVKnotSize;
        public uint m_uiUCtrlSize=>_d.m_uiUCtrlSize;
        public uint m_uiVCtrlSize=>_d.m_uiVCtrlSize;
        public IntPtr m_pdUKnots=>_d.m_pdUKnots;
        public IntPtr m_pdVKnots=>_d.m_pdVKnots;
        public IntPtr m_pdWeights=>_d.m_pdWeights;
        public IntPtr m_pCtrlPts=>_d.m_pCtrlPts;

        private A3DSurfNurbsData _d;
    }
    public class A3DSurfSphereDataWrapper
    {
        public A3DSurfSphereDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DSurfSphereDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DSurfSphereGet( p, ref _d );
            }
        }

        ~A3DSurfSphereDataWrapper()
        {
            API.A3DSurfSphereGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DUVParameterizationData m_sParam=>_d.m_sParam;
        public double m_dRadius=>_d.m_dRadius;

        private A3DSurfSphereData _d;
    }
    public class A3DSurfCylinderDataWrapper
    {
        public A3DSurfCylinderDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DSurfCylinderDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DSurfCylinderGet( p, ref _d );
            }
        }

        ~A3DSurfCylinderDataWrapper()
        {
            API.A3DSurfCylinderGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DUVParameterizationData m_sParam=>_d.m_sParam;
        public double m_dRadius=>_d.m_dRadius;

        private A3DSurfCylinderData _d;
    }
    public class A3DSurfTorusDataWrapper
    {
        public A3DSurfTorusDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DSurfTorusDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DSurfTorusGet( p, ref _d );
            }
        }

        ~A3DSurfTorusDataWrapper()
        {
            API.A3DSurfTorusGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DUVParameterizationData m_sParam=>_d.m_sParam;
        public double m_dMajorRadius=>_d.m_dMajorRadius;
        public double m_dMinorRadius=>_d.m_dMinorRadius;

        private A3DSurfTorusData _d;
    }
    public class A3DSurfRevolutionDataWrapper
    {
        public A3DSurfRevolutionDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DSurfRevolutionDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DSurfRevolutionGet( p, ref _d );
            }
        }

        ~A3DSurfRevolutionDataWrapper()
        {
            API.A3DSurfRevolutionGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DUVParameterizationData m_sParam=>_d.m_sParam;
        public IntPtr m_pCurve=>_d.m_pCurve;
        public A3DVector3dData m_sOrigin=>_d.m_sOrigin;
        public A3DVector3dData m_sDirection=>_d.m_sDirection;

        private A3DSurfRevolutionData _d;
    }
    public class A3DSurfExtrusionDataWrapper
    {
        public A3DSurfExtrusionDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DSurfExtrusionDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DSurfExtrusionGet( p, ref _d );
            }
        }

        ~A3DSurfExtrusionDataWrapper()
        {
            API.A3DSurfExtrusionGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DUVParameterizationData m_sParam=>_d.m_sParam;
        public IntPtr m_pCurve=>_d.m_pCurve;
        public A3DVector3dData m_sDirection=>_d.m_sDirection;

        private A3DSurfExtrusionData _d;
    }
    public class A3DSurfOffsetDataWrapper
    {
        public A3DSurfOffsetDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DSurfOffsetDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DSurfOffsetGet( p, ref _d );
            }
        }

        ~A3DSurfOffsetDataWrapper()
        {
            API.A3DSurfOffsetGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DUVParameterizationData m_sParam=>_d.m_sParam;
        public IntPtr m_pBasisSurf=>_d.m_pBasisSurf;
        public double m_dOffset=>_d.m_dOffset;

        private A3DSurfOffsetData _d;
    }
    public class A3DSurfPlaneDataWrapper
    {
        public A3DSurfPlaneDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DSurfPlaneDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DSurfPlaneGet( p, ref _d );
            }
        }

        ~A3DSurfPlaneDataWrapper()
        {
            API.A3DSurfPlaneGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DUVParameterizationData m_sParam=>_d.m_sParam;

        private A3DSurfPlaneData _d;
    }
    public class A3DSurfBlend01DataWrapper
    {
        public A3DSurfBlend01DataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DSurfBlend01DataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DSurfBlend01Get( p, ref _d );
            }
        }

        ~A3DSurfBlend01DataWrapper()
        {
            API.A3DSurfBlend01Get( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DUVParameterizationData m_sParam=>_d.m_sParam;
        public IntPtr m_pPntCurve=>_d.m_pPntCurve;
        public IntPtr m_pCtrCurve=>_d.m_pCtrCurve;
        public IntPtr m_pTanCurve=>_d.m_pTanCurve;

        private A3DSurfBlend01Data _d;
    }
    public class A3DSurfBlend02DataWrapper
    {
        public A3DSurfBlend02DataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DSurfBlend02DataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DSurfBlend02Get( p, ref _d );
            }
        }

        ~A3DSurfBlend02DataWrapper()
        {
            API.A3DSurfBlend02Get( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DUVParameterizationData m_sParam=>_d.m_sParam;
        public IntPtr m_pSurface0=>_d.m_pSurface0;
        public IntPtr m_pCurve0=>_d.m_pCurve0;
        public IntPtr m_pSurface1=>_d.m_pSurface1;
        public IntPtr m_pCurve1=>_d.m_pCurve1;
        public IntPtr m_pCenterCurve=>_d.m_pCenterCurve;
        public bool m_bCenterCurveSens => _d.m_bCenterCurveSens;
        public bool m_bBound0Sens => _d.m_bBound0Sens;
        public bool m_bBound1Sens => _d.m_bBound1Sens;
        public double m_dRadius0=>_d.m_dRadius0;
        public double m_dRadius1=>_d.m_dRadius1;
        public byte m_cParameterizationType=>_d.m_cParameterizationType;
        public IntPtr m_pCliffSurface0=>_d.m_pCliffSurface0;
        public IntPtr m_pCliffSurface1=>_d.m_pCliffSurface1;

        private A3DSurfBlend02Data _d;
    }
    public class A3DSurfBlend03DataWrapper
    {
        public A3DSurfBlend03DataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DSurfBlend03DataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DSurfBlend03Get( p, ref _d );
            }
        }

        ~A3DSurfBlend03DataWrapper()
        {
            API.A3DSurfBlend03Get( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool Struct_not_implemented_____A3DSurfBlend03Data => _d.Struct_not_implemented_____A3DSurfBlend03Data;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DUVParameterizationData m_sParam=>_d.m_sParam;
        public uint m_uiNbOfElement=>_d.m_uiNbOfElement;
        public IntPtr m_pdParameters=>_d.m_pdParameters;
        public IntPtr m_piMultiplicities=>_d.m_piMultiplicities;
        public IntPtr m_pPositions=>_d.m_pPositions;
        public IntPtr m_pdRail2AnglesV=>_d.m_pdRail2AnglesV;
        public IntPtr m_pTangent=>_d.m_pTangent;
        public IntPtr m_pdRail2DerivativesV=>_d.m_pdRail2DerivativesV;
        public IntPtr m_pSecondDerivatives=>_d.m_pSecondDerivatives;
        public IntPtr m_pdRail2SecondDerivatives=>_d.m_pdRail2SecondDerivatives;
        public double m_dRail2ParameterV=>_d.m_dRail2ParameterV;
        public double m_dTrimVMin=>_d.m_dTrimVMin;
        public double m_dTrimVMax=>_d.m_dTrimVMax;
        public int[] m_piReserveInt {
            get {
                var result = new int[6];
                for( var idx = 0; idx < 6; ++idx ) unsafe {
                    result[idx] = _d.m_piReserveInt[idx];
                }
                return result;
            }
        }
        public byte m_cReservedChar0=>_d.m_cReservedChar0;
        public byte m_cReservedChar1=>_d.m_cReservedChar1;
        public byte m_cReservedChar2=>_d.m_cReservedChar2;
        public uint m_uiReservedDoublesSize=>_d.m_uiReservedDoublesSize;
        public IntPtr m_pdReservedDoubles=>_d.m_pdReservedDoubles;
        public double m_dInitialMaxV=>_d.m_dInitialMaxV;

        private A3DSurfBlend03Data _d;
    }
    public class A3DSurfConeDataWrapper
    {
        public A3DSurfConeDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DSurfConeDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DSurfConeGet( p, ref _d );
            }
        }

        ~A3DSurfConeDataWrapper()
        {
            API.A3DSurfConeGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DUVParameterizationData m_sParam=>_d.m_sParam;
        public double m_dRadius=>_d.m_dRadius;
        public double m_dSemiAngle=>_d.m_dSemiAngle;
        public bool m_bInsideOut => _d.m_bInsideOut;

        private A3DSurfConeData _d;
    }
    public class A3DSurfCylindricalDataWrapper
    {
        public A3DSurfCylindricalDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DSurfCylindricalDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DSurfCylindricalGet( p, ref _d );
            }
        }

        ~A3DSurfCylindricalDataWrapper()
        {
            API.A3DSurfCylindricalGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DUVParameterizationData m_sParam=>_d.m_sParam;
        public IntPtr m_pBasisSurf=>_d.m_pBasisSurf;

        private A3DSurfCylindricalData _d;
    }
    public class A3DSurfRuledDataWrapper
    {
        public A3DSurfRuledDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DSurfRuledDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DSurfRuledGet( p, ref _d );
            }
        }

        ~A3DSurfRuledDataWrapper()
        {
            API.A3DSurfRuledGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DUVParameterizationData m_sParam=>_d.m_sParam;
        public IntPtr m_pFirstCurve=>_d.m_pFirstCurve;
        public IntPtr m_pSecondCurve=>_d.m_pSecondCurve;

        private A3DSurfRuledData _d;
    }
    public class A3DSurfPipeDataWrapper
    {
        public A3DSurfPipeDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DSurfPipeDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DSurfPipeGet( p, ref _d );
            }
        }

        ~A3DSurfPipeDataWrapper()
        {
            API.A3DSurfPipeGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DUVParameterizationData m_sParam=>_d.m_sParam;
        public double m_dRadius=>_d.m_dRadius;
        public IntPtr m_pSpine=>_d.m_pSpine;
        public IntPtr m_pOrigine=>_d.m_pOrigine;

        private A3DSurfPipeData _d;
    }
    public class A3DSurfTransformDataWrapper
    {
        public A3DSurfTransformDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DSurfTransformDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DSurfTransformGet( p, ref _d );
            }
        }

        ~A3DSurfTransformDataWrapper()
        {
            API.A3DSurfTransformGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DUVParameterizationData m_sParam=>_d.m_sParam;
        public IntPtr m_pTransfo=>_d.m_pTransfo;
        public IntPtr m_pBasisSurf=>_d.m_pBasisSurf;

        private A3DSurfTransformData _d;
    }
    public class A3DSurfFromCurvesDataWrapper
    {
        public A3DSurfFromCurvesDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DSurfFromCurvesDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DSurfFromCurvesGet( p, ref _d );
            }
        }

        ~A3DSurfFromCurvesDataWrapper()
        {
            API.A3DSurfFromCurvesGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf=>_d.m_sTrsf;
        public A3DUVParameterizationData m_sParam=>_d.m_sParam;
        public A3DVector3dData m_sOrigin=>_d.m_sOrigin;
        public IntPtr m_pFirstCurve=>_d.m_pFirstCurve;
        public IntPtr m_pSecondCurve=>_d.m_pSecondCurve;

        private A3DSurfFromCurvesData _d;
    }
    public class A3DGlobalDataWrapper
    {
        public A3DGlobalDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DGlobalDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DGlobalGet( p, ref _d );
            }
        }

        ~A3DGlobalDataWrapper()
        {
            API.A3DGlobalGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiColorsSize=>_d.m_uiColorsSize;
        public uint m_uiPicturesSize=>_d.m_uiPicturesSize;
        public uint m_uiTextureDefinitionsSize=>_d.m_uiTextureDefinitionsSize;
        public uint m_uiMaterialsSize=>_d.m_uiMaterialsSize;
        public uint m_uiLinePatternsSize=>_d.m_uiLinePatternsSize;
        public uint m_uiStylesSize=>_d.m_uiStylesSize;
        public uint m_uiFillPatternsSize=>_d.m_uiFillPatternsSize;
        public uint m_uiUnitsSize=>_d.m_uiUnitsSize;

        private A3DGlobalData _d;
    }
    public class A3DMDPosition3DDataWrapper
    {
        public A3DMDPosition3DDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDPosition3DDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDPosition3DGet( p, ref _d );
            }
        }

        ~A3DMDPosition3DDataWrapper()
        {
            API.A3DMDPosition3DGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DVector3dData m_sPosition=>_d.m_sPosition;

        private A3DMDPosition3DData _d;
    }
    public class A3DMDPosition2DDataWrapper
    {
        public A3DMDPosition2DDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDPosition2DDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDPosition2DGet( p, ref _d );
            }
        }

        ~A3DMDPosition2DDataWrapper()
        {
            API.A3DMDPosition2DGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DVector2dData m_sPosition=>_d.m_sPosition;
        public double m_dOffset=>_d.m_dOffset;
        public IntPtr m_pPlane=>_d.m_pPlane;

        private A3DMDPosition2DData _d;
    }
    public class A3DMDPositionReferenceDataWrapper
    {
        public A3DMDPositionReferenceDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDPositionReferenceDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDPositionReferenceGet( p, ref _d );
            }
        }

        ~A3DMDPositionReferenceDataWrapper()
        {
            API.A3DMDPositionReferenceGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_psLinkedItem=>_d.m_psLinkedItem;
        public EA3DMDAnchorPointType m_eAttachType=>_d.m_eAttachType;
        public A3DVector2dData m_sOffsetToReference=>_d.m_sOffsetToReference;

        private A3DMDPositionReferenceData _d;
    }
    public class A3DMDLeaderSymbolDataWrapper
    {
        public A3DMDLeaderSymbolDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDLeaderSymbolDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDLeaderSymbolGet( p, ref _d );
            }
        }

        ~A3DMDLeaderSymbolDataWrapper()
        {
            API.A3DMDLeaderSymbolGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DMDLeaderSymbolType m_eHeadSymbol=>_d.m_eHeadSymbol;
        public double m_dLength=>_d.m_dLength;
        public double m_dAdditionalParameter=>_d.m_dAdditionalParameter;

        private A3DMDLeaderSymbolData _d;
    }
    public class A3DMDMarkupLeaderStubDataWrapper
    {
        public A3DMDMarkupLeaderStubDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDMarkupLeaderStubDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDMarkupLeaderStubGet( p, ref _d );
            }
        }

        ~A3DMDMarkupLeaderStubDataWrapper()
        {
            API.A3DMDMarkupLeaderStubGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiValuesAndAnchorTypesSize=>_d.m_uiValuesAndAnchorTypesSize;
        public IntPtr m_pdValues=>_d.m_pdValues;
        public IntPtr m_piAnchorTypes=>_d.m_piAnchorTypes;

        private A3DMDMarkupLeaderStubData _d;
    }
    public class A3DMDLeaderDefinitionDataWrapper
    {
        public A3DMDLeaderDefinitionDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDLeaderDefinitionDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDLeaderDefinitionGet( p, ref _d );
            }
        }

        ~A3DMDLeaderDefinitionDataWrapper()
        {
            API.A3DMDLeaderDefinitionGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiNumberOfPathLeaderPositions=>_d.m_uiNumberOfPathLeaderPositions;
        public IntPtr m_ppsPathLeaderPositions=>_d.m_ppsPathLeaderPositions;
        public uint m_uiNbGapsElements=>_d.m_uiNbGapsElements;
        public IntPtr m_pdGapList=>_d.m_pdGapList;
        public IntPtr m_pHeadSymbol=>_d.m_pHeadSymbol;
        public A3DMDLeaderSymbolType m_eTailSymbol=>_d.m_eTailSymbol;
        public IntPtr m_pNextLeader=>_d.m_pNextLeader;
        public uint m_uAnchorFrame=>_d.m_uAnchorFrame;
        public uint m_uAnchorPoint=>_d.m_uAnchorPoint;
        public IntPtr m_pStub=>_d.m_pStub;

        private A3DMDLeaderDefinitionData _d;
    }
    public class A3DMDTextPropertiesDataWrapper
    {
        public A3DMDTextPropertiesDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDTextPropertiesDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDTextPropertiesGet( p, ref _d );
            }
        }

        ~A3DMDTextPropertiesDataWrapper()
        {
            API.A3DMDTextPropertiesGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_pcFont => _d.m_pcFont;
        public double m_dAngle=>_d.m_dAngle;
        public bool m_bSlant => _d.m_bSlant;
        public ushort m_ucThickness=>_d.m_ucThickness;
        public ushort m_ucSize=>_d.m_ucSize;
        public ushort m_usLineStyle=>_d.m_usLineStyle;
        public double m_dCharHeight=>_d.m_dCharHeight;
        public double m_dCharSpacing=>_d.m_dCharSpacing;
        public double m_dCharWidth=>_d.m_dCharWidth;
        public ushort m_iCharFixedRatioMode=>_d.m_iCharFixedRatioMode;
        public EA3DMDTextPropertiesScore m_eGlobalTextScoring=>_d.m_eGlobalTextScoring;
        public EA3DMDTextPropertiesFormat m_eFormat=>_d.m_eFormat;
        public EA3DMDTextPropertiesJustification m_eJustification=>_d.m_eJustification;

        private A3DMDTextPropertiesData _d;
    }
    public class A3DMarkupDefinitionDataWrapper
    {
        public A3DMarkupDefinitionDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMarkupDefinitionDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMarkupDefinitionGet( p, ref _d );
            }
        }

        ~A3DMarkupDefinitionDataWrapper()
        {
            API.A3DMarkupDefinitionGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pAttach=>_d.m_pAttach;
        public EA3DMDAnchorPointType m_eAttachType=>_d.m_eAttachType;
        public double m_dAttachAngle=>_d.m_dAttachAngle;
        public bool m_bDisplayParallelOnScreen => _d.m_bDisplayParallelOnScreen;
        public bool m_bZoomable => _d.m_bZoomable;
        public bool m_bLeaderNotIntersectWithBox => _d.m_bLeaderNotIntersectWithBox;

        private A3DMarkupDefinitionData _d;
    }
    public class A3DMDDimensionValueFormatDataWrapper
    {
        public A3DMDDimensionValueFormatDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDDimensionValueFormatDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDDimensionValueFormatGet( p, ref _d );
            }
        }

        ~A3DMDDimensionValueFormatDataWrapper()
        {
            API.A3DMDDimensionValueFormatGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_pcName => _d.m_pcName;
        public int m_iType=>_d.m_iType;
        public int m_iUnit=>_d.m_iUnit;
        public double m_dGlobFact=>_d.m_dGlobFact;
        public int m_iNulFac_1=>_d.m_iNulFac_1;
        public int m_iNulFac_2=>_d.m_iNulFac_2;
        public int m_iExise=>_d.m_iExise;
        public int m_iSep1000=>_d.m_iSep1000;
        public double m_dFact_1=>_d.m_dFact_1;
        public double m_dFact_2=>_d.m_dFact_2;
        public double m_dFact_3=>_d.m_dFact_3;
        public double m_dValPos_1=>_d.m_dValPos_1;
        public double m_dValPos_2=>_d.m_dValPos_2;
        public double m_dValPos_3=>_d.m_dValPos_3;
        public string m_pcSepar_1 => _d.m_pcSepar_1;
        public string m_pcSepar_2 => _d.m_pcSepar_2;
        public string m_pcSepar_3 => _d.m_pcSepar_3;
        public double m_dSepScl_1=>_d.m_dSepScl_1;
        public double m_dSepScl_2=>_d.m_dSepScl_2;
        public double m_dSepScl_3=>_d.m_dSepScl_3;
        public double m_dSepPos_1=>_d.m_dSepPos_1;
        public double m_dSepPos_2=>_d.m_dSepPos_2;
        public double m_dSepPos_3=>_d.m_dSepPos_3;
        public double m_dRestY=>_d.m_dRestY;
        public int m_iFinZer=>_d.m_iFinZer;
        public int m_iSepNum=>_d.m_iSepNum;
        public int m_iTypFrac=>_d.m_iTypFrac;
        public int m_iSepDen=>_d.m_iSepDen;
        public double m_dOperY=>_d.m_dOperY;
        public int m_iNulOther=>_d.m_iNulOther;
        public double m_dResScl=>_d.m_dResScl;
        public int m_iFact=>_d.m_iFact;
        public double m_dRestX=>_d.m_dRestX;

        private A3DMDDimensionValueFormatData _d;
    }
    public class A3DMDDimensionSimpleToleranceFormatDataWrapper
    {
        public A3DMDDimensionSimpleToleranceFormatDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDDimensionSimpleToleranceFormatDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDDimensionSimpleToleranceFormatGet( p, ref _d );
            }
        }

        ~A3DMDDimensionSimpleToleranceFormatDataWrapper()
        {
            API.A3DMDDimensionSimpleToleranceFormatGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_pcName => _d.m_pcName;
        public int m_iType=>_d.m_iType;
        public int m_iSepar_1=>_d.m_iSepar_1;
        public int m_iSepar_2=>_d.m_iSepar_2;
        public double m_dSymbolH=>_d.m_dSymbolH;
        public int m_iSepTo_1=>_d.m_iSepTo_1;
        public int m_iSepTo_2=>_d.m_iSepTo_2;
        public int m_iSepTo_3=>_d.m_iSepTo_3;
        public int m_iTrailing=>_d.m_iTrailing;
        public int m_iFractLine=>_d.m_iFractLine;
        public int m_iPtOnValue=>_d.m_iPtOnValue;
        public int m_iAnchorPt=>_d.m_iAnchorPt;
        public double m_dIntX=>_d.m_dIntX;
        public double m_dIntY=>_d.m_dIntY;
        public double m_dExtX=>_d.m_dExtX;
        public double m_dExtY=>_d.m_dExtY;
        public int m_iMergeSame=>_d.m_iMergeSame;
        public int m_iShowNull=>_d.m_iShowNull;
        public double m_dScale=>_d.m_dScale;

        private A3DMDDimensionSimpleToleranceFormatData _d;
    }
    public class A3DMDDimensionCombinedToleranceFormatDataWrapper
    {
        public A3DMDDimensionCombinedToleranceFormatDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDDimensionCombinedToleranceFormatDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDDimensionCombinedToleranceFormatGet( p, ref _d );
            }
        }

        ~A3DMDDimensionCombinedToleranceFormatDataWrapper()
        {
            API.A3DMDDimensionCombinedToleranceFormatGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_pcName => _d.m_pcName;
        public int m_iType=>_d.m_iType;
        public IntPtr m_pToleranceFormat1=>_d.m_pToleranceFormat1;
        public double m_dExtX1=>_d.m_dExtX1;
        public double m_dExtY1=>_d.m_dExtY1;
        public int m_iAnchorPt1=>_d.m_iAnchorPt1;
        public int m_iPtOnValue1=>_d.m_iPtOnValue1;
        public int m_iSepar_1=>_d.m_iSepar_1;
        public IntPtr m_pToleranceFormat2=>_d.m_pToleranceFormat2;
        public double m_dExtX2=>_d.m_dExtX2;
        public double m_dExtY2=>_d.m_dExtY2;
        public int m_iAnchorPt2=>_d.m_iAnchorPt2;
        public int m_iPtOnValue2=>_d.m_iPtOnValue2;
        public int m_iSepar_2=>_d.m_iSepar_2;

        private A3DMDDimensionCombinedToleranceFormatData _d;
    }
    public class A3DMDDimensionValueDataWrapper
    {
        public A3DMDDimensionValueDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDDimensionValueDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDDimensionValueGet( p, ref _d );
            }
        }

        ~A3DMDDimensionValueDataWrapper()
        {
            API.A3DMDDimensionValueGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public int m_iType=>_d.m_iType;
        public bool m_bFormat => _d.m_bFormat;
        public double m_dAccuracy=>_d.m_dAccuracy;
        public double m_dToleranceAccuracy=>_d.m_dToleranceAccuracy;
        public string m_pcFakeValue => _d.m_pcFakeValue;
        public double m_dTolNumSup=>_d.m_dTolNumSup;
        public double m_dTolNumInf=>_d.m_dTolNumInf;
        public string m_pcTolTxtSup => _d.m_pcTolTxtSup;
        public string m_pcTolTxtInf => _d.m_pcTolTxtInf;
        public string m_pcBeforeText => _d.m_pcBeforeText;
        public string m_pcAfterText => _d.m_pcAfterText;
        public string m_pcAboveText => _d.m_pcAboveText;
        public string m_pcBelowText => _d.m_pcBelowText;
        public ushort m_usLastSeparDefinedNum=>_d.m_usLastSeparDefinedNum;
        public IntPtr m_pDimValueFormat=>_d.m_pDimValueFormat;
        public IntPtr m_pToleranceFormat=>_d.m_pToleranceFormat;
        public int m_iOption=>_d.m_iOption;
        public double m_dDeltaForMinMax=>_d.m_dDeltaForMinMax;
        public IntPtr m_pChamferDimSecondValue=>_d.m_pChamferDimSecondValue;

        private A3DMDDimensionValueData _d;
    }
    public class A3DMDDimensionSecondPartDataWrapper
    {
        public A3DMDDimensionSecondPartDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDDimensionSecondPartDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDDimensionSecondPartGet( p, ref _d );
            }
        }

        ~A3DMDDimensionSecondPartDataWrapper()
        {
            API.A3DMDDimensionSecondPartGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public EA3DMDDimensionOrientation m_eOrientation=>_d.m_eOrientation;
        public double m_dAngle=>_d.m_dAngle;
        public double m_dOffSet=>_d.m_dOffSet;

        private A3DMDDimensionSecondPartData _d;
    }
    public class A3DMDDimensionForeshortenedDataWrapper
    {
        public A3DMDDimensionForeshortenedDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDDimensionForeshortenedDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDDimensionForeshortenedGet( p, ref _d );
            }
        }

        ~A3DMDDimensionForeshortenedDataWrapper()
        {
            API.A3DMDDimensionForeshortenedGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bTextPosition => _d.m_bTextPosition;
        public bool m_bOrientation => _d.m_bOrientation;
        public double m_dAngle=>_d.m_dAngle;
        public float m_fRatio=>_d.m_fRatio;
        public ushort m_usPointScale=>_d.m_usPointScale;

        private A3DMDDimensionForeshortenedData _d;
    }
    public class A3DMDDimensionLineSymbolDataWrapper
    {
        public A3DMDDimensionLineSymbolDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDDimensionLineSymbolDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDDimensionLineSymbolGet( p, ref _d );
            }
        }

        ~A3DMDDimensionLineSymbolDataWrapper()
        {
            API.A3DMDDimensionLineSymbolGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public EA3DMDDimensionSymbolShape m_eShape=>_d.m_eShape;
        public uint m_iLineColor=>_d.m_iLineColor;
        public float m_fThickness=>_d.m_fThickness;
        public float m_fArrowLength=>_d.m_fArrowLength;
        public float m_fArrowAngle=>_d.m_fArrowAngle;

        private A3DMDDimensionLineSymbolData _d;
    }
    public class A3DMDDimensionLineDataWrapper
    {
        public A3DMDDimensionLineDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDDimensionLineDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDDimensionLineGet( p, ref _d );
            }
        }

        ~A3DMDDimensionLineDataWrapper()
        {
            API.A3DMDDimensionLineGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pSymbol1=>_d.m_pSymbol1;
        public IntPtr m_pSymbol2=>_d.m_pSymbol2;
        public IntPtr m_pLeaderSymbol=>_d.m_pLeaderSymbol;
        public EA3DMDDimensionLineGraphicalRepresentation m_eGraphRepresentation=>_d.m_eGraphRepresentation;
        public IntPtr m_pSecondPart=>_d.m_pSecondPart;
        public ushort m_usStyle=>_d.m_usStyle;
        public float m_fThickness=>_d.m_fThickness;
        public ushort m_usReversal=>_d.m_usReversal;
        public IntPtr m_psForeshortened=>_d.m_psForeshortened;
        public double m_dLeaderAngle=>_d.m_dLeaderAngle;
        public EA3DMDDimensionLineExtensionType m_eExtension=>_d.m_eExtension;
        public IntPtr m_pExplicitCurve=>_d.m_pExplicitCurve;

        private A3DMDDimensionLineData _d;
    }
    public class A3DMDDimensionFunnelDataWrapper
    {
        public A3DMDDimensionFunnelDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDDimensionFunnelDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDDimensionFunnelGet( p, ref _d );
            }
        }

        ~A3DMDDimensionFunnelDataWrapper()
        {
            API.A3DMDDimensionFunnelGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public ushort m_usIndex=>_d.m_usIndex;
        public bool m_bMode => _d.m_bMode;
        public double m_dAngle=>_d.m_dAngle;
        public double m_dHeight=>_d.m_dHeight;
        public double m_dWidth=>_d.m_dWidth;

        private A3DMDDimensionFunnelData _d;
    }
    public class A3DMDDimensionExtremityDataWrapper
    {
        public A3DMDDimensionExtremityDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDDimensionExtremityDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDDimensionExtremityGet( p, ref _d );
            }
        }

        ~A3DMDDimensionExtremityDataWrapper()
        {
            API.A3DMDDimensionExtremityGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bShow => _d.m_bShow;
        public double m_dBlanking=>_d.m_dBlanking;
        public double m_dOverrun=>_d.m_dOverrun;

        private A3DMDDimensionExtremityData _d;
    }
    public class A3DMDDimensionExtentionLineDataWrapper
    {
        public A3DMDDimensionExtentionLineDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDDimensionExtentionLineDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDDimensionExtentionLineGet( p, ref _d );
            }
        }

        ~A3DMDDimensionExtentionLineDataWrapper()
        {
            API.A3DMDDimensionExtentionLineGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pFunnel=>_d.m_pFunnel;
        public A3DMDDimensionExtremityData m_sExtremity1=>_d.m_sExtremity1;
        public A3DMDDimensionExtremityData m_sExtremity2=>_d.m_sExtremity2;
        public double m_dLineSlant=>_d.m_dLineSlant;
        public ushort m_usStyle=>_d.m_usStyle;
        public float m_fThickness=>_d.m_fThickness;

        private A3DMDDimensionExtentionLineData _d;
    }
    public class A3DMarkupDimensionDataWrapper
    {
        public A3DMarkupDimensionDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMarkupDimensionDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMarkupDimensionGet( p, ref _d );
            }
        }

        ~A3DMarkupDimensionDataWrapper()
        {
            API.A3DMarkupDimensionGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public EA3DMDDimensionType m_eType=>_d.m_eType;
        public IntPtr m_pMainValue=>_d.m_pMainValue;
        public IntPtr m_pDualValue=>_d.m_pDualValue;
        public EA3DMDDimensionDualDisplay m_eDualDisplay=>_d.m_eDualDisplay;
        public double m_dValue=>_d.m_dValue;
        public EA3DMDDimensionSymbolType m_eSymbol=>_d.m_eSymbol;
        public EA3DMDDimensionSymbolType m_eAdditionnalSymbol=>_d.m_eAdditionnalSymbol;
        public string m_pcSuffixe => _d.m_pcSuffixe;
        public string m_pcPrefixe => _d.m_pcPrefixe;
        public IntPtr m_pExtentionLine=>_d.m_pExtentionLine;
        public IntPtr m_pLine=>_d.m_pLine;
        public EA3DMDDimensionOrientation m_eOrientation=>_d.m_eOrientation;
        public A3DVector3dData m_sOffSet=>_d.m_sOffSet;
        public ushort m_usPosition=>_d.m_usPosition;
        public EA3DMDDimensionScore m_eScore=>_d.m_eScore;
        public ushort m_usScore=>_d.m_usScore;
        public ushort m_usScoreGroup=>_d.m_usScoreGroup;
        public EA3DMDDimensionFrame m_eFrame=>_d.m_eFrame;
        public ushort m_usFrame=>_d.m_usFrame;
        public ushort m_usFrameGroup=>_d.m_usFrameGroup;
        public IntPtr m_pTextProperties=>_d.m_pTextProperties;
        public double m_dChamferDimSecondValue=>_d.m_dChamferDimSecondValue;

        private A3DMarkupDimensionData _d;
    }
    public class A3DMarkupRoughnessDataWrapper
    {
        public A3DMarkupRoughnessDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMarkupRoughnessDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMarkupRoughnessGet( p, ref _d );
            }
        }

        ~A3DMarkupRoughnessDataWrapper()
        {
            API.A3DMarkupRoughnessGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_pcField1 => _d.m_pcField1;
        public string m_pcField2 => _d.m_pcField2;
        public string m_pcField3 => _d.m_pcField3;
        public string m_pcField4 => _d.m_pcField4;
        public string m_pcField5 => _d.m_pcField5;
        public string m_pcField6 => _d.m_pcField6;
        public string m_pcField7 => _d.m_pcField7;
        public string m_pcField8 => _d.m_pcField8;
        public string m_pcRoughMode => _d.m_pcRoughMode;
        public EA3DMDRoughnessType m_eRoughType=>_d.m_eRoughType;
        public EA3DMDRoughnessMode m_eRoughMode=>_d.m_eRoughMode;
        public EA3DMDRoughnessContactArea m_eRoughContactArea=>_d.m_eRoughContactArea;
        public IntPtr m_pTextProperties=>_d.m_pTextProperties;

        private A3DMarkupRoughnessData _d;
    }
    public class A3DMarkupBalloonDataWrapper
    {
        public A3DMarkupBalloonDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMarkupBalloonDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMarkupBalloonGet( p, ref _d );
            }
        }

        ~A3DMarkupBalloonDataWrapper()
        {
            API.A3DMarkupBalloonGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_pcUpText => _d.m_pcUpText;
        public string m_pcDownText => _d.m_pcDownText;
        public EA3DMDBalloonShape m_eBalloonShape=>_d.m_eBalloonShape;
        public double m_dBallownSize=>_d.m_dBallownSize;
        public IntPtr m_psTextPosition=>_d.m_psTextPosition;
        public uint m_uiFileLinksSize=>_d.m_uiFileLinksSize;
        public IntPtr m_ppFileLinks=>_d.m_ppFileLinks;
        public IntPtr m_pTextProperties=>_d.m_pTextProperties;

        private A3DMarkupBalloonData _d;
    }
    public class A3DMarkupFastenerDataWrapper
    {
        public A3DMarkupFastenerDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMarkupFastenerDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMarkupFastenerGet( p, ref _d );
            }
        }

        ~A3DMarkupFastenerDataWrapper()
        {
            API.A3DMarkupFastenerGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dDiameter1=>_d.m_dDiameter1;
        public double m_dDepth1=>_d.m_dDepth1;
        public double m_dDiameter2=>_d.m_dDiameter2;
        public double m_dDepth2=>_d.m_dDepth2;
        public double m_dDiameter3=>_d.m_dDiameter3;
        public double m_dDepth3=>_d.m_dDepth3;
        public double m_dDiameter4=>_d.m_dDiameter4;
        public double m_dDepth4=>_d.m_dDepth4;
        public string m_sType => _d.m_sType;
        public string m_sTypeId => _d.m_sTypeId;
        public string m_sSubtypeId => _d.m_sSubtypeId;
        public uint m_uiNoteTextsSize=>_d.m_uiNoteTextsSize;
        public IntPtr m_ppNoteTextsNotes=>_d.m_ppNoteTextsNotes;
        public ushort m_iDecimalPlaces=>_d.m_iDecimalPlaces;
        public A3DVector3dData m_sAxisVector=>_d.m_sAxisVector;
        public A3DVector3dData m_sIndexVector=>_d.m_sIndexVector;
        public A3DVector3dData m_sOptionalVector=>_d.m_sOptionalVector;
        public uint m_uiCoordinateEntitiesNotesSize=>_d.m_uiCoordinateEntitiesNotesSize;
        public IntPtr m_ppCoordinateEntitiesNotes=>_d.m_ppCoordinateEntitiesNotes;
        public string m_sStandard => _d.m_sStandard;
        public IntPtr m_pTextProperties=>_d.m_pTextProperties;

        private A3DMarkupFastenerData _d;
    }
    public class A3DMarkupLocatorDataWrapper
    {
        public A3DMarkupLocatorDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMarkupLocatorDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMarkupLocatorGet( p, ref _d );
            }
        }

        ~A3DMarkupLocatorDataWrapper()
        {
            API.A3DMarkupLocatorGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public EA3DLocatorSymbol m_eSymbol=>_d.m_eSymbol;
        public EA3DLocatorType m_eType=>_d.m_eType;
        public EA3DLocatorSubType m_eSubType=>_d.m_eSubType;
        public EA3DLocatorCoordinatePlane m_eCoordinatePlane=>_d.m_eCoordinatePlane;
        public EA3DLocatorChangeLevel m_eChangeLevel=>_d.m_eChangeLevel;
        public uint m_iDecimalPlaces=>_d.m_iDecimalPlaces;
        public string m_sNoteFont => _d.m_sNoteFont;
        public string m_sNote => _d.m_sNote;
        public string m_sPartNumberFont => _d.m_sPartNumberFont;
        public string m_sPartNumber => _d.m_sPartNumber;
        public uint m_uiCoordinateEntitiesNotesSize=>_d.m_uiCoordinateEntitiesNotesSize;
        public IntPtr m_sCoordinateEntitiesNotesFont=>_d.m_sCoordinateEntitiesNotesFont;
        public IntPtr m_sCoordinateEntitiesNotes=>_d.m_sCoordinateEntitiesNotes;
        public A3DVector3dData m_sHotSpot=>_d.m_sHotSpot;
        public A3DVector3dData m_sPunchDirection=>_d.m_sPunchDirection;
        public A3DVector3dData m_sPinDirection=>_d.m_sPinDirection;
        public A3DVector3dData m_sNormalDirection=>_d.m_sNormalDirection;
        public uint m_iUnit=>_d.m_iUnit;
        public double m_dAccuracy=>_d.m_dAccuracy;
        public ushort m_ucSubscripts=>_d.m_ucSubscripts;
        public IntPtr m_pTextProperties=>_d.m_pTextProperties;

        private A3DMarkupLocatorData _d;
    }
    public class A3DMarkupMeasurementPointDataWrapper
    {
        public A3DMarkupMeasurementPointDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMarkupMeasurementPointDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMarkupMeasurementPointGet( p, ref _d );
            }
        }

        ~A3DMarkupMeasurementPointDataWrapper()
        {
            API.A3DMarkupMeasurementPointGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_sLevel => _d.m_sLevel;
        public A3DVector3dData m_sLocation=>_d.m_sLocation;
        public A3DVector3dData m_sMeasurementVector=>_d.m_sMeasurementVector;
        public A3DVector3dData m_sCoordinationVector=>_d.m_sCoordinationVector;
        public A3DVector3dData m_sNormalVector=>_d.m_sNormalVector;
        public uint m_uiCoordinateEntitiesNotesSize=>_d.m_uiCoordinateEntitiesNotesSize;
        public IntPtr m_sCoordinateEntitiesNotesFont=>_d.m_sCoordinateEntitiesNotesFont;
        public IntPtr m_sCoordinateEntitiesNotes=>_d.m_sCoordinateEntitiesNotes;
        public EA3DMDMarkupDisplayType m_eDisplayType=>_d.m_eDisplayType;
        public IntPtr m_pTextProperties=>_d.m_pTextProperties;

        private A3DMarkupMeasurementPointData _d;
    }
    public class A3DMDTextPositionDataWrapper
    {
        public A3DMDTextPositionDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDTextPositionDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDTextPositionGet( p, ref _d );
            }
        }

        ~A3DMDTextPositionDataWrapper()
        {
            API.A3DMDTextPositionGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DVector3dData m_sPosition=>_d.m_sPosition;
        public A3DVector3dData m_sBaseVector=>_d.m_sBaseVector;
        public A3DVector3dData m_sUpVector=>_d.m_sUpVector;

        private A3DMDTextPositionData _d;
    }
    public class A3DMarkupTextDataWrapper
    {
        public A3DMarkupTextDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMarkupTextDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMarkupTextGet( p, ref _d );
            }
        }

        ~A3DMarkupTextDataWrapper()
        {
            API.A3DMarkupTextGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiLinesSize=>_d.m_uiLinesSize;
        public IntPtr m_ppLines=>_d.m_ppLines;
        public uint m_uiFileLinksSize=>_d.m_uiFileLinksSize;
        public IntPtr m_ppFileLinks=>_d.m_ppFileLinks;
        public double m_dWrappingWidth=>_d.m_dWrappingWidth;
        public EA3DMarkupFrameType m_eFrameType=>_d.m_eFrameType;
        public EA3DLeaderAlignementType m_eLeaderAlignementType=>_d.m_eLeaderAlignementType;
        public IntPtr m_pTextProperties=>_d.m_pTextProperties;
        public IntPtr m_psTextPosition=>_d.m_psTextPosition;

        private A3DMarkupTextData _d;
    }
    public class A3DMarkupCoordinateDataWrapper
    {
        public A3DMarkupCoordinateDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMarkupCoordinateDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMarkupCoordinateGet( p, ref _d );
            }
        }

        ~A3DMarkupCoordinateDataWrapper()
        {
            API.A3DMarkupCoordinateGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dLitDimensionedX=>_d.m_dLitDimensionedX;
        public double m_dLitDimensionedY=>_d.m_dLitDimensionedY;
        public double m_dLitDimensionedZ=>_d.m_dLitDimensionedZ;
        public bool m_bType3D => _d.m_bType3D;
        public IntPtr m_psTextPosition=>_d.m_psTextPosition;

        private A3DMarkupCoordinateData _d;
    }
    public class A3DMarkupRichTextDataWrapper
    {
        public A3DMarkupRichTextDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMarkupRichTextDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMarkupRichTextGet( p, ref _d );
            }
        }

        ~A3DMarkupRichTextDataWrapper()
        {
            API.A3DMarkupRichTextGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_pcRichText => _d.m_pcRichText;
        public uint m_uLength=>_d.m_uLength;
        public uint m_uiFileLinksSize=>_d.m_uiFileLinksSize;
        public IntPtr m_ppFileLinks=>_d.m_ppFileLinks;
        public double m_dWrappingWidth=>_d.m_dWrappingWidth;
        public EA3DMarkupFrameType m_eFrameType=>_d.m_eFrameType;
        public EA3DLeaderAlignementType m_eLeaderAlignementType=>_d.m_eLeaderAlignementType;
        public IntPtr m_psTextPosition=>_d.m_psTextPosition;

        private A3DMarkupRichTextData _d;
    }
    public class A3DMarkupDatumDataWrapper
    {
        public A3DMarkupDatumDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMarkupDatumDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMarkupDatumGet( p, ref _d );
            }
        }

        ~A3DMarkupDatumDataWrapper()
        {
            API.A3DMarkupDatumGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_pcUpText => _d.m_pcUpText;
        public string m_pcDownText => _d.m_pcDownText;
        public bool m_bTarget => _d.m_bTarget;
        public bool m_bDiameter => _d.m_bDiameter;
        public bool m_bIndividual => _d.m_bIndividual;
        public IntPtr m_pTextProperties=>_d.m_pTextProperties;
        public string m_pcAboveText => _d.m_pcAboveText;
        public string m_pcBelowText => _d.m_pcBelowText;
        public string m_pcBeforeText => _d.m_pcBeforeText;
        public string m_pcAfterText => _d.m_pcAfterText;

        private A3DMarkupDatumData _d;
    }
    public class A3DMDFCFDraftingRowDataWrapper
    {
        public A3DMDFCFDraftingRowDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDFCFDraftingRowDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDFCFDraftingRowGet( p, ref _d );
            }
        }

        ~A3DMDFCFDraftingRowDataWrapper()
        {
            API.A3DMDFCFDraftingRowGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public EA3DGDTType m_eType=>_d.m_eType;
        public uint m_uiNumberOfTextsInBoxes=>_d.m_uiNumberOfTextsInBoxes;
        public IntPtr m_ppcTextsInBoxes=>_d.m_ppcTextsInBoxes;

        private A3DMDFCFDraftingRowData _d;
    }
    public class A3DMDFCValueDataWrapper
    {
        public A3DMDFCValueDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDFCValueDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDFCValueGet( p, ref _d );
            }
        }

        ~A3DMDFCValueDataWrapper()
        {
            API.A3DMDFCValueGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dValue=>_d.m_dValue;
        public string m_pcValue => _d.m_pcValue;
        public bool m_bIsValue => _d.m_bIsValue;

        private A3DMDFCValueData _d;
    }
    public class A3DMDFCTolerancePerUnitDataWrapper
    {
        public A3DMDFCTolerancePerUnitDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDFCTolerancePerUnitDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDFCTolerancePerUnitGet( p, ref _d );
            }
        }

        ~A3DMDFCTolerancePerUnitDataWrapper()
        {
            API.A3DMDFCTolerancePerUnitGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dUnitLengthOrAreaFirstValue=>_d.m_dUnitLengthOrAreaFirstValue;
        public IntPtr m_pdUnitAreaSecondLength=>_d.m_pdUnitAreaSecondLength;
        public IntPtr m_psRefinementZone=>_d.m_psRefinementZone;

        private A3DMDFCTolerancePerUnitData _d;
    }
    public class A3DMDFCProjectedZoneDataWrapper
    {
        public A3DMDFCProjectedZoneDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDFCProjectedZoneDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDFCProjectedZoneGet( p, ref _d );
            }
        }

        ~A3DMDFCProjectedZoneDataWrapper()
        {
            API.A3DMDFCProjectedZoneGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DMDFCValueData m_sLength=>_d.m_sLength;
        public IntPtr m_pdPosition=>_d.m_pdPosition;

        private A3DMDFCProjectedZoneData _d;
    }
    public class A3DMDFCFToleranceValueDataWrapper
    {
        public A3DMDFCFToleranceValueDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDFCFToleranceValueDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDFCFToleranceValueGet( p, ref _d );
            }
        }

        ~A3DMDFCFToleranceValueDataWrapper()
        {
            API.A3DMDFCFToleranceValueGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DMDFCValueData m_sValue=>_d.m_sValue;
        public IntPtr m_psTolerancePerUnit=>_d.m_psTolerancePerUnit;
        public IntPtr m_psProjectedZone=>_d.m_psProjectedZone;
        public IntPtr m_psProfileTolerance=>_d.m_psProfileTolerance;
        public IntPtr m_psMaximumBonus=>_d.m_psMaximumBonus;
        public A3DMDGDTValueType m_eValueType=>_d.m_eValueType;
        public EA3DMDGDTModifierType m_eModifier=>_d.m_eModifier;
        public bool m_bFreeState => _d.m_bFreeState;
        public bool m_bStatistical => _d.m_bStatistical;
        public IntPtr m_psNext=>_d.m_psNext;

        private A3DMDFCFToleranceValueData _d;
    }
    public class A3DMDFCFRowDatumDataWrapper
    {
        public A3DMDFCFRowDatumDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDFCFRowDatumDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDFCFRowDatumGet( p, ref _d );
            }
        }

        ~A3DMDFCFRowDatumDataWrapper()
        {
            API.A3DMDFCFRowDatumGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_pcDatum => _d.m_pcDatum;
        public EA3DMDGDTModifierType m_eModifier=>_d.m_eModifier;
        public IntPtr m_pNext=>_d.m_pNext;
        public IntPtr m_pLinkedItem=>_d.m_pLinkedItem;

        private A3DMDFCFRowDatumData _d;
    }
    public class A3DMDFCFDrawingRowDataWrapper
    {
        public A3DMDFCFDrawingRowDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDFCFDrawingRowDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDFCFDrawingRowGet( p, ref _d );
            }
        }

        ~A3DMDFCFDrawingRowDataWrapper()
        {
            API.A3DMDFCFDrawingRowGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public EA3DGDTType m_eType=>_d.m_eType;
        public string m_pcValue => _d.m_pcValue;
        public IntPtr m_psSemanticValue=>_d.m_psSemanticValue;
        public IntPtr m_psPrimaryRef=>_d.m_psPrimaryRef;
        public IntPtr m_psSecondaryRef=>_d.m_psSecondaryRef;
        public IntPtr m_psTertiaryRef=>_d.m_psTertiaryRef;

        private A3DMDFCFDrawingRowData _d;
    }
    public class A3DMDFCFIndicatorDataWrapper
    {
        public A3DMDFCFIndicatorDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDFCFIndicatorDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDFCFIndicatorGet( p, ref _d );
            }
        }

        ~A3DMDFCFIndicatorDataWrapper()
        {
            API.A3DMDFCFIndicatorGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public EA3DFCFIndicatorType m_eType=>_d.m_eType;
        public EA3DFCFIndicatorSymbol m_eSymbol=>_d.m_eSymbol;
        public IntPtr m_pDatum=>_d.m_pDatum;

        private A3DMDFCFIndicatorData _d;
    }
    public class A3DMDFeatureControlFrameDataWrapper
    {
        public A3DMDFeatureControlFrameDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDFeatureControlFrameDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDFeatureControlFrameGet( p, ref _d );
            }
        }

        ~A3DMDFeatureControlFrameDataWrapper()
        {
            API.A3DMDFeatureControlFrameGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiNumberOfRows=>_d.m_uiNumberOfRows;
        public IntPtr m_ppRows=>_d.m_ppRows;
        public uint m_uiNumberOfIndicators=>_d.m_uiNumberOfIndicators;
        public IntPtr m_ppIndicators=>_d.m_ppIndicators;

        private A3DMDFeatureControlFrameData _d;
    }
    public class A3DMDToleranceSizeValueDataWrapper
    {
        public A3DMDToleranceSizeValueDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDToleranceSizeValueDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDToleranceSizeValueGet( p, ref _d );
            }
        }

        ~A3DMDToleranceSizeValueDataWrapper()
        {
            API.A3DMDToleranceSizeValueGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public EA3DMDDimensionType m_eType=>_d.m_eType;
        public A3DMDDimensionValueData m_sMainValue=>_d.m_sMainValue;
        public IntPtr m_pDualValue=>_d.m_pDualValue;
        public double m_dValue=>_d.m_dValue;
        public string m_pcSeparator => _d.m_pcSeparator;
        public EA3DMDDimensionSymbolType m_eSymbol=>_d.m_eSymbol;

        private A3DMDToleranceSizeValueData _d;
    }
    public class A3DMDToleranceSizeDataWrapper
    {
        public A3DMDToleranceSizeDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMDToleranceSizeDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMDToleranceSizeGet( p, ref _d );
            }
        }

        ~A3DMDToleranceSizeDataWrapper()
        {
            API.A3DMDToleranceSizeGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiNumberOfSizeValues=>_d.m_uiNumberOfSizeValues;
        public IntPtr m_ppTolSizeValue=>_d.m_ppTolSizeValue;

        private A3DMDToleranceSizeData _d;
    }
    public class A3DMarkupGDTDataWrapper
    {
        public A3DMarkupGDTDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMarkupGDTDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMarkupGDTGet( p, ref _d );
            }
        }

        ~A3DMarkupGDTDataWrapper()
        {
            API.A3DMarkupGDTGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_pcAboveText => _d.m_pcAboveText;
        public string m_pcBelowText => _d.m_pcBelowText;
        public string m_pcBeforeText => _d.m_pcBeforeText;
        public string m_pcAfterText => _d.m_pcAfterText;
        public uint m_uiNumberOfMarkupTolerances=>_d.m_uiNumberOfMarkupTolerances;
        public IntPtr m_ppsMarkupTolerances=>_d.m_ppsMarkupTolerances;
        public IntPtr m_pTextProperties=>_d.m_pTextProperties;

        private A3DMarkupGDTData _d;
    }
    public class A3DMarkupSpotWeldingDataWrapper
    {
        public A3DMarkupSpotWeldingDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMarkupSpotWeldingDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMarkupSpotWeldingGet( p, ref _d );
            }
        }

        ~A3DMarkupSpotWeldingDataWrapper()
        {
            API.A3DMarkupSpotWeldingGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public EA3DMDSpotWeldType m_eType=>_d.m_eType;
        public EA3DMDSpotWeldThickness m_eThickness=>_d.m_eThickness;
        public bool m_bIsCritical => _d.m_bIsCritical;
        public double m_dDiameter=>_d.m_dDiameter;
        public string m_pcJointId => _d.m_pcJointId;
        public string m_pcGroupId => _d.m_pcGroupId;
        public string m_pcProcess => _d.m_pcProcess;
        public uint m_uiCoordinateEntitiesNotesSize=>_d.m_uiCoordinateEntitiesNotesSize;
        public IntPtr m_ppCoordinateEntitiesNotes=>_d.m_ppCoordinateEntitiesNotes;
        public A3DVector3dData m_sApproachVector=>_d.m_sApproachVector;
        public A3DVector3dData m_sClampingVector=>_d.m_sClampingVector;
        public A3DVector3dData m_sNormalVector=>_d.m_sNormalVector;
        public IntPtr m_pTextProperties=>_d.m_pTextProperties;

        private A3DMarkupSpotWeldingData _d;
    }
    public class A3DMarkupLineWeldingDataWrapper
    {
        public A3DMarkupLineWeldingDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMarkupLineWeldingDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMarkupLineWeldingGet( p, ref _d );
            }
        }

        ~A3DMarkupLineWeldingDataWrapper()
        {
            API.A3DMarkupLineWeldingGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public EA3DMDLineWeldingType m_eArrowSideType=>_d.m_eArrowSideType;
        public EA3DMDLineWeldingSupplSymbolType m_eArrowSideSupplType=>_d.m_eArrowSideSupplType;
        public string m_pcArrowSideValue => _d.m_pcArrowSideValue;
        public string m_pcArrowSideLongitudinalValue => _d.m_pcArrowSideLongitudinalValue;
        public string m_pcArrowSideStaggeredValue => _d.m_pcArrowSideStaggeredValue;
        public EA3DMDLineWeldingFinishSymbol m_eArrowSideFinishSymbol=>_d.m_eArrowSideFinishSymbol;
        public string m_pcArrowSideAngle => _d.m_pcArrowSideAngle;
        public string m_pcArrowSideNumRootDepth => _d.m_pcArrowSideNumRootDepth;
        public string m_pcArrowSideSize => _d.m_pcArrowSideSize;
        public string m_pcArrowSidePitch => _d.m_pcArrowSidePitch;
        public EA3DMDLineWeldingType m_eOtherSideType=>_d.m_eOtherSideType;
        public EA3DMDLineWeldingSupplSymbolType m_eOtherSideSupplType=>_d.m_eOtherSideSupplType;
        public string m_pcOtherSideValue => _d.m_pcOtherSideValue;
        public string m_pcOtherSideLongitudinalValue => _d.m_pcOtherSideLongitudinalValue;
        public string m_pcOtherSideStaggeredValue => _d.m_pcOtherSideStaggeredValue;
        public EA3DMDLineWeldingFinishSymbol m_eOtherSideFinishSymbol=>_d.m_eOtherSideFinishSymbol;
        public string m_pcOtherSideAngle => _d.m_pcOtherSideAngle;
        public string m_pcOtherSideNumRootDepth => _d.m_pcOtherSideNumRootDepth;
        public string m_pcOtherSideSize => _d.m_pcOtherSideSize;
        public string m_pcOtherSidePitch => _d.m_pcOtherSidePitch;
        public string m_pcStandard => _d.m_pcStandard;
        public uint m_uiNumberOfProcesses=>_d.m_uiNumberOfProcesses;
        public uint m_uiNumberOfCoordinate=>_d.m_uiNumberOfCoordinate;
        public IntPtr m_ppcProcess=>_d.m_ppcProcess;
        public uint m_uiCoordinateEntitiesNotesSize=>_d.m_uiCoordinateEntitiesNotesSize;
        public IntPtr m_ppCoordinateEntitiesNotes=>_d.m_ppCoordinateEntitiesNotes;
        public uint m_uiProcessNotesSize=>_d.m_uiProcessNotesSize;
        public IntPtr m_ppProcessNotes=>_d.m_ppProcessNotes;
        public IntPtr m_pTextProperties=>_d.m_pTextProperties;

        private A3DMarkupLineWeldingData _d;
    }
    public class A3DMathFct1DPolynomDataWrapper
    {
        public A3DMathFct1DPolynomDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMathFct1DPolynomDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMathFct1DPolynomGet( p, ref _d );
            }
        }

        ~A3DMathFct1DPolynomDataWrapper()
        {
            API.A3DMathFct1DPolynomGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiSize=>_d.m_uiSize;
        public IntPtr m_pdCoeffs=>_d.m_pdCoeffs;

        private A3DMathFct1DPolynomData _d;
    }
    public class A3DMathFct1DTrigonometricDataWrapper
    {
        public A3DMathFct1DTrigonometricDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMathFct1DTrigonometricDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMathFct1DTrigonometricGet( p, ref _d );
            }
        }

        ~A3DMathFct1DTrigonometricDataWrapper()
        {
            API.A3DMathFct1DTrigonometricGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dAmplitude=>_d.m_dAmplitude;
        public double m_dPhase=>_d.m_dPhase;
        public double m_dFreq=>_d.m_dFreq;
        public double m_dDCOffset=>_d.m_dDCOffset;

        private A3DMathFct1DTrigonometricData _d;
    }
    public class A3DMathFct1DFractionDataWrapper
    {
        public A3DMathFct1DFractionDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMathFct1DFractionDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMathFct1DFractionGet( p, ref _d );
            }
        }

        ~A3DMathFct1DFractionDataWrapper()
        {
            API.A3DMathFct1DFractionGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pP=>_d.m_pP;
        public IntPtr m_pQ=>_d.m_pQ;

        private A3DMathFct1DFractionData _d;
    }
    public class A3DMathFct1DArctanCosDataWrapper
    {
        public A3DMathFct1DArctanCosDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMathFct1DArctanCosDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMathFct1DArctanCosGet( p, ref _d );
            }
        }

        ~A3DMathFct1DArctanCosDataWrapper()
        {
            API.A3DMathFct1DArctanCosGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dA=>_d.m_dA;
        public double m_dB=>_d.m_dB;
        public double m_dC=>_d.m_dC;
        public double m_dD=>_d.m_dD;
        public double m_dE=>_d.m_dE;

        private A3DMathFct1DArctanCosData _d;
    }
    public class A3DMathFct1DCombinationDataWrapper
    {
        public A3DMathFct1DCombinationDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMathFct1DCombinationDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMathFct1DCombinationGet( p, ref _d );
            }
        }

        ~A3DMathFct1DCombinationDataWrapper()
        {
            API.A3DMathFct1DCombinationGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiSize=>_d.m_uiSize;
        public IntPtr m_ppFunctions=>_d.m_ppFunctions;
        public IntPtr m_pdCoeffs=>_d.m_pdCoeffs;

        private A3DMathFct1DCombinationData _d;
    }
    public class A3DMathFct3DLinearDataWrapper
    {
        public A3DMathFct3DLinearDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMathFct3DLinearDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMathFct3DLinearGet( p, ref _d );
            }
        }

        ~A3DMathFct3DLinearDataWrapper()
        {
            API.A3DMathFct3DLinearGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double[] m_adMatrix {
            get {
                var result = new double[9];
                for( var idx = 0; idx < 9; ++idx ) unsafe {
                    result[idx] = _d.m_adMatrix[idx];
                }
                return result;
            }
        }
        public double[] m_adVector {
            get {
                var result = new double[3];
                for( var idx = 0; idx < 3; ++idx ) unsafe {
                    result[idx] = _d.m_adVector[idx];
                }
                return result;
            }
        }

        private A3DMathFct3DLinearData _d;
    }
    public class A3DMathFct3DNonLinearDataWrapper
    {
        public A3DMathFct3DNonLinearDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMathFct3DNonLinearDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMathFct3DNonLinearGet( p, ref _d );
            }
        }

        ~A3DMathFct3DNonLinearDataWrapper()
        {
            API.A3DMathFct3DNonLinearGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pLeftLinear=>_d.m_pLeftLinear;
        public IntPtr m_pRightLinear=>_d.m_pRightLinear;
        public double m_d2=>_d.m_d2;

        private A3DMathFct3DNonLinearData _d;
    }
    public class A3DRootBaseDataWrapper
    {
        public A3DRootBaseDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DRootBaseDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DRootBaseGet( p, ref _d );
            }
        }

        ~A3DRootBaseDataWrapper()
        {
            API.A3DRootBaseGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiSize=>_d.m_uiSize;
        public IntPtr m_ppAttributes=>_d.m_ppAttributes;
        public string m_pcName => _d.m_pcName;
        public uint m_uiPersistentId=>_d.m_uiPersistentId;
        public string m_pcPersistentId => _d.m_pcPersistentId;
        public uint m_uiNonPersistentId=>_d.m_uiNonPersistentId;

        private A3DRootBaseData _d;
    }
    public class A3DRootBaseWithGraphicsDataWrapper
    {
        public A3DRootBaseWithGraphicsDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DRootBaseWithGraphicsDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DRootBaseWithGraphicsGet( p, ref _d );
            }
        }

        ~A3DRootBaseWithGraphicsDataWrapper()
        {
            API.A3DRootBaseWithGraphicsGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pGraphics=>_d.m_pGraphics;

        private A3DRootBaseWithGraphicsData _d;
    }
    public class A3DMiscSingleAttributeDataWrapper
    {
        public A3DMiscSingleAttributeDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DMiscSingleAttributeDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bTitleIsInt => _d.m_bTitleIsInt;
        public string m_pcTitle => _d.m_pcTitle;
        public A3DEModellerAttributeType m_eType=>_d.m_eType;
        public string m_pcData => _d.m_pcData;
        public ushort m_usUnit=>_d.m_usUnit;

        private A3DMiscSingleAttributeData _d;
    }
    public class A3DMiscAttributeDataWrapper
    {
        public A3DMiscAttributeDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DMiscAttributeDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DMiscAttributeGet( p, ref _d );
            }
        }

        ~A3DMiscAttributeDataWrapper()
        {
            API.A3DMiscAttributeGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bTitleIsInt => _d.m_bTitleIsInt;
        public string m_pcTitle => _d.m_pcTitle;
        public uint m_uiSize=>_d.m_uiSize;
        public IntPtr m_asSingleAttributesData=>_d.m_asSingleAttributesData;

        private A3DMiscAttributeData _d;
    }
    public class A3DMiscAttributeBasicUnitDataWrapper
    {
        public A3DMiscAttributeBasicUnitDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DMiscAttributeBasicUnitDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DEBasicUnit m_eUnit=>_d.m_eUnit;
        public int m_iExponent=>_d.m_iExponent;
        public double m_dFactor=>_d.m_dFactor;

        private A3DMiscAttributeBasicUnitData _d;
    }
    public class A3DMiscAttributeUnitDataWrapper
    {
        public A3DMiscAttributeUnitDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DMiscAttributeUnitDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public string m_pcName => _d.m_pcName;
        public uint m_uiBasicUnitSize=>_d.m_uiBasicUnitSize;
        public IntPtr m_ppBasicUnits=>_d.m_ppBasicUnits;

        private A3DMiscAttributeUnitData _d;
    }
    public class A3DCopyAndAdaptBrepModelDataWrapper
    {
        public A3DCopyAndAdaptBrepModelDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DCopyAndAdaptBrepModelDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bUseSameParam => _d.m_bUseSameParam;
        public double m_dTol=>_d.m_dTol;
        public bool m_bDeleteCrossingUV => _d.m_bDeleteCrossingUV;
        public bool m_bSplitFaces => _d.m_bSplitFaces;
        public bool m_bSplitClosedFaces => _d.m_bSplitClosedFaces;
        public bool m_bForceComputeUV => _d.m_bForceComputeUV;
        public bool m_bAllowUVCrossingSeams => _d.m_bAllowUVCrossingSeams;
        public bool m_bForceCompute3D => _d.m_bForceCompute3D;
        public uint m_uiAcceptableSurfacesSize=>_d.m_uiAcceptableSurfacesSize;
        public IntPtr m_puiAcceptableSurfaces=>_d.m_puiAcceptableSurfaces;
        public uint m_uiAcceptableCurvesSize=>_d.m_uiAcceptableCurvesSize;
        public IntPtr m_puiAcceptableCurves=>_d.m_puiAcceptableCurves;
        public bool m_bContinueOnError => _d.m_bContinueOnError;
        public bool m_bClampTolerantUVCurvesInsideUVDomain => _d.m_bClampTolerantUVCurvesInsideUVDomain;
        public bool m_bForceDuplicateGeometries => _d.m_bForceDuplicateGeometries;

        private A3DCopyAndAdaptBrepModelData _d;
    }
    public class A3DPhysicalPropertiesDataWrapper
    {
        public A3DPhysicalPropertiesDataWrapper()
        {
            API.Initialize(out _d);
        }

        ~A3DPhysicalPropertiesDataWrapper()
        {
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public A3DVector3dData m_sGravityCenter=>_d.m_sGravityCenter;
        public double m_dSurface=>_d.m_dSurface;
        public bool m_bVolumeComputed => _d.m_bVolumeComputed;
        public double m_dVolume=>_d.m_dVolume;
        public A3DVector3dData m_sSurfacicGravityCenter=>_d.m_sSurfacicGravityCenter;
        public double[] m_adAreaMatrixOfInertia {
            get {
                var result = new double[9];
                for( var idx = 0; idx < 9; ++idx ) unsafe {
                    result[idx] = _d.m_adAreaMatrixOfInertia[idx];
                }
                return result;
            }
        }
        public double[] m_adVolumeMatrixOfInertia {
            get {
                var result = new double[9];
                for( var idx = 0; idx < 9; ++idx ) unsafe {
                    result[idx] = _d.m_adVolumeMatrixOfInertia[idx];
                }
                return result;
            }
        }
        public bool m_bUseGeometryOnRiBRep => _d.m_bUseGeometryOnRiBRep;
        public double m_dAccuracyLevel=>_d.m_dAccuracyLevel;
        public bool m_bIncludeHiddenRIs => _d.m_bIncludeHiddenRIs;

        private A3DPhysicalPropertiesData _d;
    }
    public class A3DTopoBodyDataWrapper
    {
        public A3DTopoBodyDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DTopoBodyDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DTopoBodyGet( p, ref _d );
            }
        }

        ~A3DTopoBodyDataWrapper()
        {
            API.A3DTopoBodyGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public byte m_ucBehaviour=>_d.m_ucBehaviour;
        public IntPtr m_pContext=>_d.m_pContext;

        private A3DTopoBodyData _d;
    }
    public class A3DTopoContextDataWrapper
    {
        public A3DTopoContextDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DTopoContextDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DTopoContextGet( p, ref _d );
            }
        }

        ~A3DTopoContextDataWrapper()
        {
            API.A3DTopoContextGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public byte m_ucBehaviour=>_d.m_ucBehaviour;
        public double m_dGranularity=>_d.m_dGranularity;
        public double m_dTolerance=>_d.m_dTolerance;
        public bool m_bHaveSmallestFaceThickness => _d.m_bHaveSmallestFaceThickness;
        public double m_dSmallestThickness=>_d.m_dSmallestThickness;
        public bool m_bHaveScale => _d.m_bHaveScale;
        public double m_dScale=>_d.m_dScale;

        private A3DTopoContextData _d;
    }
    public class A3DTopoSingleWireBodyDataWrapper
    {
        public A3DTopoSingleWireBodyDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DTopoSingleWireBodyDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DTopoSingleWireBodyGet( p, ref _d );
            }
        }

        ~A3DTopoSingleWireBodyDataWrapper()
        {
            API.A3DTopoSingleWireBodyGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pWireEdge=>_d.m_pWireEdge;

        private A3DTopoSingleWireBodyData _d;
    }
    public class A3DTopoBrepDataDataWrapper
    {
        public A3DTopoBrepDataDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DTopoBrepDataDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DTopoBrepDataGet( p, ref _d );
            }
        }

        ~A3DTopoBrepDataDataWrapper()
        {
            API.A3DTopoBrepDataGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiConnexSize=>_d.m_uiConnexSize;
        public IntPtr m_ppConnexes=>_d.m_ppConnexes;
        public A3DBoundingBoxData m_sBoundingBox=>_d.m_sBoundingBox;

        private A3DTopoBrepDataData _d;
    }
    public class A3DTopoConnexDataWrapper
    {
        public A3DTopoConnexDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DTopoConnexDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DTopoConnexGet( p, ref _d );
            }
        }

        ~A3DTopoConnexDataWrapper()
        {
            API.A3DTopoConnexGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiShellSize=>_d.m_uiShellSize;
        public IntPtr m_ppShells=>_d.m_ppShells;

        private A3DTopoConnexData _d;
    }
    public class A3DTopoShellDataWrapper
    {
        public A3DTopoShellDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DTopoShellDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DTopoShellGet( p, ref _d );
            }
        }

        ~A3DTopoShellDataWrapper()
        {
            API.A3DTopoShellGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public bool m_bClosed => _d.m_bClosed;
        public uint m_uiFaceSize=>_d.m_uiFaceSize;
        public IntPtr m_ppFaces=>_d.m_ppFaces;
        public IntPtr m_pucOrientationWithShell=>_d.m_pucOrientationWithShell;

        private A3DTopoShellData _d;
    }
    public class A3DTopoFaceDataWrapper
    {
        public A3DTopoFaceDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DTopoFaceDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DTopoFaceGet( p, ref _d );
            }
        }

        ~A3DTopoFaceDataWrapper()
        {
            API.A3DTopoFaceGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pSurface=>_d.m_pSurface;
        public bool m_bHasTrimDomain => _d.m_bHasTrimDomain;
        public A3DDomainData m_sSurfaceDomain=>_d.m_sSurfaceDomain;
        public uint m_uiLoopSize=>_d.m_uiLoopSize;
        public IntPtr m_ppLoops=>_d.m_ppLoops;
        public uint m_uiOuterLoopIndex=>_d.m_uiOuterLoopIndex;
        public double m_dTolerance=>_d.m_dTolerance;

        private A3DTopoFaceData _d;
    }
    public class A3DTopoLoopDataWrapper
    {
        public A3DTopoLoopDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DTopoLoopDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DTopoLoopGet( p, ref _d );
            }
        }

        ~A3DTopoLoopDataWrapper()
        {
            API.A3DTopoLoopGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public byte m_ucOrientationWithSurface=>_d.m_ucOrientationWithSurface;
        public uint m_uiCoEdgeSize=>_d.m_uiCoEdgeSize;
        public IntPtr m_ppCoEdges=>_d.m_ppCoEdges;

        private A3DTopoLoopData _d;
    }
    public class A3DTopoCoEdgeDataWrapper
    {
        public A3DTopoCoEdgeDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DTopoCoEdgeDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DTopoCoEdgeGet( p, ref _d );
            }
        }

        ~A3DTopoCoEdgeDataWrapper()
        {
            API.A3DTopoCoEdgeGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public byte m_ucOrientationWithLoop=>_d.m_ucOrientationWithLoop;
        public byte m_ucOrientationUVWithLoop=>_d.m_ucOrientationUVWithLoop;
        public IntPtr m_pEdge=>_d.m_pEdge;
        public IntPtr m_pUVCurve=>_d.m_pUVCurve;
        public IntPtr m_pNeighbor=>_d.m_pNeighbor;

        private A3DTopoCoEdgeData _d;
    }
    public class A3DTopoEdgeDataWrapper
    {
        public A3DTopoEdgeDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DTopoEdgeDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DTopoEdgeGet( p, ref _d );
            }
        }

        ~A3DTopoEdgeDataWrapper()
        {
            API.A3DTopoEdgeGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_pStartVertex=>_d.m_pStartVertex;
        public IntPtr m_pEndVertex=>_d.m_pEndVertex;
        public IntPtr m_p3dCurve=>_d.m_p3dCurve;
        public bool m_bHasTrimDomain => _d.m_bHasTrimDomain;
        public A3DIntervalData m_sInterval=>_d.m_sInterval;
        public double m_dTolerance=>_d.m_dTolerance;

        private A3DTopoEdgeData _d;
    }
    public class A3DTopoWireEdgeDataWrapper
    {
        public A3DTopoWireEdgeDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DTopoWireEdgeDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DTopoWireEdgeGet( p, ref _d );
            }
        }

        ~A3DTopoWireEdgeDataWrapper()
        {
            API.A3DTopoWireEdgeGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public IntPtr m_p3dCurve=>_d.m_p3dCurve;
        public bool m_bHasTrimDomain => _d.m_bHasTrimDomain;
        public A3DIntervalData m_sInterval=>_d.m_sInterval;

        private A3DTopoWireEdgeData _d;
    }
    public class A3DTopoUniqueVertexDataWrapper
    {
        public A3DTopoUniqueVertexDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DTopoUniqueVertexDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DTopoUniqueVertexGet( p, ref _d );
            }
        }

        ~A3DTopoUniqueVertexDataWrapper()
        {
            API.A3DTopoUniqueVertexGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public double m_dTolerance=>_d.m_dTolerance;
        public A3DVector3dData m_sPoint=>_d.m_sPoint;

        private A3DTopoUniqueVertexData _d;
    }
    public class A3DTopoMultipleVertexDataWrapper
    {
        public A3DTopoMultipleVertexDataWrapper()
        {
            API.Initialize(out _d);
        }

        public A3DTopoMultipleVertexDataWrapper(IntPtr p)
        {
            API.Initialize(out _d);
            if( p != IntPtr.Zero )
            {
                API.A3DTopoMultipleVertexGet( p, ref _d );
            }
        }

        ~A3DTopoMultipleVertexDataWrapper()
        {
            API.A3DTopoMultipleVertexGet( IntPtr.Zero, ref _d );
        }
        public ushort m_usStructSize=>_d.m_usStructSize;
        public uint m_uiSize=>_d.m_uiSize;
        public IntPtr m_pPts=>_d.m_pPts;

        private A3DTopoMultipleVertexData _d;
    }
}

