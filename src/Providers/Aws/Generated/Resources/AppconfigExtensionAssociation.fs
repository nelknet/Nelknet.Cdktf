namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppconfigExtensionAssociationState<'ExtensionArn, 'ResourceArn> = { assignments: ResizeArray<aws.AppconfigExtensionAssociation.AppconfigExtensionAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_extension_association">aws_appconfig_extension_association</a>.
    /// </summary>
    type AppconfigExtensionAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppconfigExtensionAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppconfigExtensionAssociationState<Missing, Missing>)

        member _.Zero(()) : AppconfigExtensionAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppconfigExtensionAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_extension_association#extension_arn-1">AppconfigExtensionAssociation#extension_arn</a>.
        /// </summary>
        [<CustomOperation "extension_arn">]
        member _.ExtensionArn(state: AppconfigExtensionAssociationState<Missing, 'ResourceArn>, value: string) : AppconfigExtensionAssociationState<Present, 'ResourceArn> =
            state.assignments.Add(fun config -> config.ExtensionArn <- value)
            ({ assignments = state.assignments } : AppconfigExtensionAssociationState<Present, 'ResourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_extension_association#resource_arn-1">AppconfigExtensionAssociation#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: AppconfigExtensionAssociationState<'ExtensionArn, Missing>, value: string) : AppconfigExtensionAssociationState<'ExtensionArn, Present> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : AppconfigExtensionAssociationState<'ExtensionArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_extension_association#id-1">AppconfigExtensionAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppconfigExtensionAssociationState<'ExtensionArn, 'ResourceArn>, value: string) : AppconfigExtensionAssociationState<'ExtensionArn, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppconfigExtensionAssociationState<'ExtensionArn, 'ResourceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_extension_association#parameters-1">AppconfigExtensionAssociation#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: AppconfigExtensionAssociationState<'ExtensionArn, 'ResourceArn>, value: seq<string * string>) : AppconfigExtensionAssociationState<'ExtensionArn, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : AppconfigExtensionAssociationState<'ExtensionArn, 'ResourceArn>

        member _.Run(state: AppconfigExtensionAssociationState<Present, Present>) : aws.AppconfigExtensionAssociation.AppconfigExtensionAssociation =
            let config = aws.AppconfigExtensionAssociation.AppconfigExtensionAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.AppconfigExtensionAssociation.AppconfigExtensionAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appconfigExtensionAssociation: missing required arguments. Must call: extension_arn, resource_arn.", 9999, IsError = true)>]
        member _.Run(_: AppconfigExtensionAssociationState<_, _>) : aws.AppconfigExtensionAssociation.AppconfigExtensionAssociation =
            Unchecked.defaultof<aws.AppconfigExtensionAssociation.AppconfigExtensionAssociation>
