using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueMlTransform
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glueMlTransform.GlueMlTransformParameters")]
    public class GlueMlTransformParameters : aws.GlueMlTransform.IGlueMlTransformParameters
    {
        /// <summary>find_matches_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#find_matches_parameters GlueMlTransform#find_matches_parameters}
        /// </remarks>
        [JsiiProperty(name: "findMatchesParameters", typeJson: "{\"fqn\":\"aws.glueMlTransform.GlueMlTransformParametersFindMatchesParameters\"}")]
        public aws.GlueMlTransform.IGlueMlTransformParametersFindMatchesParameters FindMatchesParameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#transform_type GlueMlTransform#transform_type}.</summary>
        [JsiiProperty(name: "transformType", typeJson: "{\"primitive\":\"string\"}")]
        public string TransformType
        {
            get;
            set;
        }
    }
}
