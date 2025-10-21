namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudfrontOriginAccessControlState<'Name, 'OriginAccessControlOriginType, 'SigningBehavior, 'SigningProtocol> = { assignments: ResizeArray<aws.CloudfrontOriginAccessControl.CloudfrontOriginAccessControlConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_access_control">aws_cloudfront_origin_access_control</a>.
    /// </summary>
    type CloudfrontOriginAccessControlBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudfrontOriginAccessControlState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontOriginAccessControlState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CloudfrontOriginAccessControlState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontOriginAccessControlState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_access_control#name-1">CloudfrontOriginAccessControl#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudfrontOriginAccessControlState<Missing, 'OriginAccessControlOriginType, 'SigningBehavior, 'SigningProtocol>, value: string) : CloudfrontOriginAccessControlState<Present, 'OriginAccessControlOriginType, 'SigningBehavior, 'SigningProtocol> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudfrontOriginAccessControlState<Present, 'OriginAccessControlOriginType, 'SigningBehavior, 'SigningProtocol>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_access_control#origin_access_control_origin_type-1">CloudfrontOriginAccessControl#origin_access_control_origin_type</a>.
        /// </summary>
        [<CustomOperation "origin_access_control_origin_type">]
        member _.OriginAccessControlOriginType(state: CloudfrontOriginAccessControlState<'Name, Missing, 'SigningBehavior, 'SigningProtocol>, value: string) : CloudfrontOriginAccessControlState<'Name, Present, 'SigningBehavior, 'SigningProtocol> =
            state.assignments.Add(fun config -> config.OriginAccessControlOriginType <- value)
            ({ assignments = state.assignments } : CloudfrontOriginAccessControlState<'Name, Present, 'SigningBehavior, 'SigningProtocol>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_access_control#signing_behavior-1">CloudfrontOriginAccessControl#signing_behavior</a>.
        /// </summary>
        [<CustomOperation "signing_behavior">]
        member _.SigningBehavior(state: CloudfrontOriginAccessControlState<'Name, 'OriginAccessControlOriginType, Missing, 'SigningProtocol>, value: string) : CloudfrontOriginAccessControlState<'Name, 'OriginAccessControlOriginType, Present, 'SigningProtocol> =
            state.assignments.Add(fun config -> config.SigningBehavior <- value)
            ({ assignments = state.assignments } : CloudfrontOriginAccessControlState<'Name, 'OriginAccessControlOriginType, Present, 'SigningProtocol>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_access_control#signing_protocol-1">CloudfrontOriginAccessControl#signing_protocol</a>.
        /// </summary>
        [<CustomOperation "signing_protocol">]
        member _.SigningProtocol(state: CloudfrontOriginAccessControlState<'Name, 'OriginAccessControlOriginType, 'SigningBehavior, Missing>, value: string) : CloudfrontOriginAccessControlState<'Name, 'OriginAccessControlOriginType, 'SigningBehavior, Present> =
            state.assignments.Add(fun config -> config.SigningProtocol <- value)
            ({ assignments = state.assignments } : CloudfrontOriginAccessControlState<'Name, 'OriginAccessControlOriginType, 'SigningBehavior, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_access_control#description-1">CloudfrontOriginAccessControl#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: CloudfrontOriginAccessControlState<'Name, 'OriginAccessControlOriginType, 'SigningBehavior, 'SigningProtocol>, value: string) : CloudfrontOriginAccessControlState<'Name, 'OriginAccessControlOriginType, 'SigningBehavior, 'SigningProtocol> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : CloudfrontOriginAccessControlState<'Name, 'OriginAccessControlOriginType, 'SigningBehavior, 'SigningProtocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_access_control#id-1">CloudfrontOriginAccessControl#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudfrontOriginAccessControlState<'Name, 'OriginAccessControlOriginType, 'SigningBehavior, 'SigningProtocol>, value: string) : CloudfrontOriginAccessControlState<'Name, 'OriginAccessControlOriginType, 'SigningBehavior, 'SigningProtocol> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudfrontOriginAccessControlState<'Name, 'OriginAccessControlOriginType, 'SigningBehavior, 'SigningProtocol>

        member _.Run(state: CloudfrontOriginAccessControlState<Present, Present, Present, Present>) : aws.CloudfrontOriginAccessControl.CloudfrontOriginAccessControl =
            let config = aws.CloudfrontOriginAccessControl.CloudfrontOriginAccessControlConfig()
            for setter in state.assignments do
                setter config
            aws.CloudfrontOriginAccessControl.CloudfrontOriginAccessControl(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudfrontOriginAccessControl: missing required arguments. Must call: name, origin_access_control_origin_type, signing_behavior, signing_protocol.", 9999, IsError = true)>]
        member _.Run(_: CloudfrontOriginAccessControlState<_, _, _, _>) : aws.CloudfrontOriginAccessControl.CloudfrontOriginAccessControl =
            Unchecked.defaultof<aws.CloudfrontOriginAccessControl.CloudfrontOriginAccessControl>
