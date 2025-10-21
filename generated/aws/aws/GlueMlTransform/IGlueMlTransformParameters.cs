using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueMlTransform
{
    [JsiiInterface(nativeType: typeof(IGlueMlTransformParameters), fullyQualifiedName: "aws.glueMlTransform.GlueMlTransformParameters")]
    public interface IGlueMlTransformParameters
    {
        /// <summary>find_matches_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#find_matches_parameters GlueMlTransform#find_matches_parameters}
        /// </remarks>
        [JsiiProperty(name: "findMatchesParameters", typeJson: "{\"fqn\":\"aws.glueMlTransform.GlueMlTransformParametersFindMatchesParameters\"}")]
        aws.GlueMlTransform.IGlueMlTransformParametersFindMatchesParameters FindMatchesParameters
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#transform_type GlueMlTransform#transform_type}.</summary>
        [JsiiProperty(name: "transformType", typeJson: "{\"primitive\":\"string\"}")]
        string TransformType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueMlTransformParameters), fullyQualifiedName: "aws.glueMlTransform.GlueMlTransformParameters")]
        internal sealed class _Proxy : DeputyBase, aws.GlueMlTransform.IGlueMlTransformParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>find_matches_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#find_matches_parameters GlueMlTransform#find_matches_parameters}
            /// </remarks>
            [JsiiProperty(name: "findMatchesParameters", typeJson: "{\"fqn\":\"aws.glueMlTransform.GlueMlTransformParametersFindMatchesParameters\"}")]
            public aws.GlueMlTransform.IGlueMlTransformParametersFindMatchesParameters FindMatchesParameters
            {
                get => GetInstanceProperty<aws.GlueMlTransform.IGlueMlTransformParametersFindMatchesParameters>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#transform_type GlueMlTransform#transform_type}.</summary>
            [JsiiProperty(name: "transformType", typeJson: "{\"primitive\":\"string\"}")]
            public string TransformType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
