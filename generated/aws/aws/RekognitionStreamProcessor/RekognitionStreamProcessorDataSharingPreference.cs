using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorDataSharingPreference")]
    public class RekognitionStreamProcessorDataSharingPreference : aws.RekognitionStreamProcessor.IRekognitionStreamProcessorDataSharingPreference
    {
        private object _optIn;

        /// <summary>Do you want to share data with Rekognition to improve model performance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#opt_in RekognitionStreamProcessor#opt_in}
        /// </remarks>
        [JsiiProperty(name: "optIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object OptIn
        {
            get => _optIn;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _optIn = value;
            }
        }
    }
}
