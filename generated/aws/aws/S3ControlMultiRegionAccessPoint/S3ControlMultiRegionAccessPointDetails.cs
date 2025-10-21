using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlMultiRegionAccessPoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointDetails")]
    public class S3ControlMultiRegionAccessPointDetails : aws.S3ControlMultiRegionAccessPoint.IS3ControlMultiRegionAccessPointDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point#name S3ControlMultiRegionAccessPoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object _region;

        /// <summary>region block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point#region S3ControlMultiRegionAccessPoint#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointDetailsRegion\"},\"kind\":\"array\"}}]}}")]
        public object Region
        {
            get => _region;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.S3ControlMultiRegionAccessPoint.IS3ControlMultiRegionAccessPointDetailsRegion[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3ControlMultiRegionAccessPoint.IS3ControlMultiRegionAccessPointDetailsRegion).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3ControlMultiRegionAccessPoint.IS3ControlMultiRegionAccessPointDetailsRegion).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _region = value;
            }
        }

        /// <summary>public_access_block block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point#public_access_block S3ControlMultiRegionAccessPoint#public_access_block}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "publicAccessBlock", typeJson: "{\"fqn\":\"aws.s3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointDetailsPublicAccessBlock\"}", isOptional: true)]
        public aws.S3ControlMultiRegionAccessPoint.IS3ControlMultiRegionAccessPointDetailsPublicAccessBlock? PublicAccessBlock
        {
            get;
            set;
        }
    }
}
