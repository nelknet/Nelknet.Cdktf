namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudfrontOriginAccessControlState<'Id> = { assignments: ResizeArray<aws.DataAwsCloudfrontOriginAccessControl.DataAwsCloudfrontOriginAccessControlConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_origin_access_control">aws_cloudfront_origin_access_control</a>.
    /// </summary>
    type DataAwsCloudfrontOriginAccessControlBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudfrontOriginAccessControlState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudfrontOriginAccessControlState<Missing>)

        member _.Zero(()) : DataAwsCloudfrontOriginAccessControlState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudfrontOriginAccessControlState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_origin_access_control#id-1">DataAwsCloudfrontOriginAccessControl#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCloudfrontOriginAccessControlState<Missing>, value: string) : DataAwsCloudfrontOriginAccessControlState<Present> =
            state.assignments.Add(fun config -> config.Id <- value)
            ({ assignments = state.assignments } : DataAwsCloudfrontOriginAccessControlState<Present>)

        member _.Run(state: DataAwsCloudfrontOriginAccessControlState<Present>) : aws.DataAwsCloudfrontOriginAccessControl.DataAwsCloudfrontOriginAccessControl =
            let config = aws.DataAwsCloudfrontOriginAccessControl.DataAwsCloudfrontOriginAccessControlConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudfrontOriginAccessControl.DataAwsCloudfrontOriginAccessControl(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCloudfrontOriginAccessControl: missing required arguments. Must call: id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCloudfrontOriginAccessControlState<_>) : aws.DataAwsCloudfrontOriginAccessControl.DataAwsCloudfrontOriginAccessControl =
            Unchecked.defaultof<aws.DataAwsCloudfrontOriginAccessControl.DataAwsCloudfrontOriginAccessControl>
