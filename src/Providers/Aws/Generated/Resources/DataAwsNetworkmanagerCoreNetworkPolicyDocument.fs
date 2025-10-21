namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<'CoreNetworkConfiguration, 'Segments> = { assignments: ResizeArray<aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_core_network_policy_document">aws_networkmanager_core_network_policy_document</a>.
    /// </summary>
    type DataAwsNetworkmanagerCoreNetworkPolicyDocumentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<Missing, Missing>)

        member _.Zero(()) : DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<Missing, Missing>)

        /// <summary>
        /// core_network_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_core_network_policy_document#core_network_configuration-1">DataAwsNetworkmanagerCoreNetworkPolicyDocument#core_network_configuration</a> Accepts: aws.IResolvable | aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentCoreNetworkConfiguration[]
        /// </summary>
        [<CustomOperation "core_network_configuration">]
        member _.CoreNetworkConfiguration(state: DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<Missing, 'Segments>, value: HashiCorp.Cdktf.IResolvable) : DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<Present, 'Segments> =
            state.assignments.Add(fun config -> config.CoreNetworkConfiguration <- value)
            ({ assignments = state.assignments } : DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<Present, 'Segments>)

        /// <summary>
        /// segments block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_core_network_policy_document#segments-1">DataAwsNetworkmanagerCoreNetworkPolicyDocument#segments</a> Accepts: aws.IResolvable | aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentSegments[]
        /// </summary>
        [<CustomOperation "segments">]
        member _.Segments(state: DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<'CoreNetworkConfiguration, Missing>, value: HashiCorp.Cdktf.IResolvable) : DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<'CoreNetworkConfiguration, Present> =
            state.assignments.Add(fun config -> config.Segments <- value)
            ({ assignments = state.assignments } : DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<'CoreNetworkConfiguration, Present>)

        /// <summary>
        /// attachment_policies block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_core_network_policy_document#attachment_policies-1">DataAwsNetworkmanagerCoreNetworkPolicyDocument#attachment_policies</a> Accepts: aws.IResolvable | aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentAttachmentPolicies[]
        /// </summary>
        [<CustomOperation "attachment_policies">]
        member _.AttachmentPolicies(state: DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<'CoreNetworkConfiguration, 'Segments>, value: HashiCorp.Cdktf.IResolvable) : DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<'CoreNetworkConfiguration, 'Segments> =
            state.assignments.Add(fun config -> config.AttachmentPolicies <- value)
            state : DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<'CoreNetworkConfiguration, 'Segments>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_core_network_policy_document#id-1">DataAwsNetworkmanagerCoreNetworkPolicyDocument#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<'CoreNetworkConfiguration, 'Segments>, value: string) : DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<'CoreNetworkConfiguration, 'Segments> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<'CoreNetworkConfiguration, 'Segments>

        /// <summary>
        /// network_function_groups block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_core_network_policy_document#network_function_groups-1">DataAwsNetworkmanagerCoreNetworkPolicyDocument#network_function_groups</a> Accepts: aws.IResolvable | aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentNetworkFunctionGroups[]
        /// </summary>
        [<CustomOperation "network_function_groups">]
        member _.NetworkFunctionGroups(state: DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<'CoreNetworkConfiguration, 'Segments>, value: HashiCorp.Cdktf.IResolvable) : DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<'CoreNetworkConfiguration, 'Segments> =
            state.assignments.Add(fun config -> config.NetworkFunctionGroups <- value)
            state : DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<'CoreNetworkConfiguration, 'Segments>

        /// <summary>
        /// segment_actions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_core_network_policy_document#segment_actions-1">DataAwsNetworkmanagerCoreNetworkPolicyDocument#segment_actions</a> Accepts: aws.IResolvable | aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentSegmentActions[]
        /// </summary>
        [<CustomOperation "segment_actions">]
        member _.SegmentActions(state: DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<'CoreNetworkConfiguration, 'Segments>, value: HashiCorp.Cdktf.IResolvable) : DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<'CoreNetworkConfiguration, 'Segments> =
            state.assignments.Add(fun config -> config.SegmentActions <- value)
            state : DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<'CoreNetworkConfiguration, 'Segments>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_core_network_policy_document#version-1">DataAwsNetworkmanagerCoreNetworkPolicyDocument#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<'CoreNetworkConfiguration, 'Segments>, value: string) : DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<'CoreNetworkConfiguration, 'Segments> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<'CoreNetworkConfiguration, 'Segments>

        member _.Run(state: DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<Present, Present>) : aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocument =
            let config = aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocument(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument: missing required arguments. Must call: core_network_configuration, segments.", 9999, IsError = true)>]
        member _.Run(_: DataAwsNetworkmanagerCoreNetworkPolicyDocumentState<_, _>) : aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocument =
            Unchecked.defaultof<aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocument>
