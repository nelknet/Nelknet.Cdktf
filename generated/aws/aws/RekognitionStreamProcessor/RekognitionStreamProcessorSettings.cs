using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    [JsiiByValue(fqn: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorSettings")]
    public class RekognitionStreamProcessorSettings : aws.RekognitionStreamProcessor.IRekognitionStreamProcessorSettings
    {
        private object? _connectedHome;

        /// <summary>connected_home block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#connected_home RekognitionStreamProcessor#connected_home}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectedHome", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.rekognitionStreamProcessor.RekognitionStreamProcessorSettingsConnectedHome\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ConnectedHome
        {
            get => _connectedHome;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.RekognitionStreamProcessor.IRekognitionStreamProcessorSettingsConnectedHome[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.RekognitionStreamProcessor.IRekognitionStreamProcessorSettingsConnectedHome).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connectedHome = value;
            }
        }

        private object? _faceSearch;

        /// <summary>face_search block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#face_search RekognitionStreamProcessor#face_search}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "faceSearch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.rekognitionStreamProcessor.RekognitionStreamProcessorSettingsFaceSearch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FaceSearch
        {
            get => _faceSearch;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.RekognitionStreamProcessor.IRekognitionStreamProcessorSettingsFaceSearch[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.RekognitionStreamProcessor.IRekognitionStreamProcessorSettingsFaceSearch).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _faceSearch = value;
            }
        }
    }
}
