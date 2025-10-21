using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorSettingsFaceSearch")]
    public class RekognitionStreamProcessorSettingsFaceSearch : aws.RekognitionStreamProcessor.IRekognitionStreamProcessorSettingsFaceSearch
    {
        /// <summary>The ID of a collection that contains faces that you want to search for.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#collection_id RekognitionStreamProcessor#collection_id}
        /// </remarks>
        [JsiiProperty(name: "collectionId", typeJson: "{\"primitive\":\"string\"}")]
        public string CollectionId
        {
            get;
            set;
        }

        /// <summary>Minimum face match confidence score that must be met to return a result for a recognized face.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#face_match_threshold RekognitionStreamProcessor#face_match_threshold}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "faceMatchThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FaceMatchThreshold
        {
            get;
            set;
        }
    }
}
