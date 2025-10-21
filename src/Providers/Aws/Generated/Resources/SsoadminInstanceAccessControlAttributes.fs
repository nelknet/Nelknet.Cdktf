namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsoadminInstanceAccessControlAttributesState<'Attribute, 'InstanceArn> = { assignments: ResizeArray<aws.SsoadminInstanceAccessControlAttributes.SsoadminInstanceAccessControlAttributesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_instance_access_control_attributes">aws_ssoadmin_instance_access_control_attributes</a>.
    /// </summary>
    type SsoadminInstanceAccessControlAttributesBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsoadminInstanceAccessControlAttributesState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminInstanceAccessControlAttributesState<Missing, Missing>)

        member _.Zero(()) : SsoadminInstanceAccessControlAttributesState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminInstanceAccessControlAttributesState<Missing, Missing>)

        /// <summary>
        /// attribute block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_instance_access_control_attributes#attribute-1">SsoadminInstanceAccessControlAttributes#attribute</a> Accepts: aws.IResolvable | aws.SsoadminInstanceAccessControlAttributes.SsoadminInstanceAccessControlAttributesAttribute[]
        /// </summary>
        [<CustomOperation "attribute">]
        member _.Attribute(state: SsoadminInstanceAccessControlAttributesState<Missing, 'InstanceArn>, value: HashiCorp.Cdktf.IResolvable) : SsoadminInstanceAccessControlAttributesState<Present, 'InstanceArn> =
            state.assignments.Add(fun config -> config.Attribute <- value)
            ({ assignments = state.assignments } : SsoadminInstanceAccessControlAttributesState<Present, 'InstanceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_instance_access_control_attributes#instance_arn-1">SsoadminInstanceAccessControlAttributes#instance_arn</a>.
        /// </summary>
        [<CustomOperation "instance_arn">]
        member _.InstanceArn(state: SsoadminInstanceAccessControlAttributesState<'Attribute, Missing>, value: string) : SsoadminInstanceAccessControlAttributesState<'Attribute, Present> =
            state.assignments.Add(fun config -> config.InstanceArn <- value)
            ({ assignments = state.assignments } : SsoadminInstanceAccessControlAttributesState<'Attribute, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_instance_access_control_attributes#id-1">SsoadminInstanceAccessControlAttributes#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsoadminInstanceAccessControlAttributesState<'Attribute, 'InstanceArn>, value: string) : SsoadminInstanceAccessControlAttributesState<'Attribute, 'InstanceArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsoadminInstanceAccessControlAttributesState<'Attribute, 'InstanceArn>

        member _.Run(state: SsoadminInstanceAccessControlAttributesState<Present, Present>) : aws.SsoadminInstanceAccessControlAttributes.SsoadminInstanceAccessControlAttributes =
            let config = aws.SsoadminInstanceAccessControlAttributes.SsoadminInstanceAccessControlAttributesConfig()
            for setter in state.assignments do
                setter config
            aws.SsoadminInstanceAccessControlAttributes.SsoadminInstanceAccessControlAttributes(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssoadminInstanceAccessControlAttributes: missing required arguments. Must call: attribute, instance_arn.", 9999, IsError = true)>]
        member _.Run(_: SsoadminInstanceAccessControlAttributesState<_, _>) : aws.SsoadminInstanceAccessControlAttributes.SsoadminInstanceAccessControlAttributes =
            Unchecked.defaultof<aws.SsoadminInstanceAccessControlAttributes.SsoadminInstanceAccessControlAttributes>
