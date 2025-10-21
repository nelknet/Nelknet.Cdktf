namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerSpaceState<'DomainId, 'SpaceName> = { assignments: ResizeArray<aws.SagemakerSpace.SagemakerSpaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space">aws_sagemaker_space</a>.
    /// </summary>
    type SagemakerSpaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerSpaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerSpaceState<Missing, Missing>)

        member _.Zero(()) : SagemakerSpaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerSpaceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#domain_id-1">SagemakerSpace#domain_id</a>.
        /// </summary>
        [<CustomOperation "domain_id">]
        member _.DomainId(state: SagemakerSpaceState<Missing, 'SpaceName>, value: string) : SagemakerSpaceState<Present, 'SpaceName> =
            state.assignments.Add(fun config -> config.DomainId <- value)
            ({ assignments = state.assignments } : SagemakerSpaceState<Present, 'SpaceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#space_name-1">SagemakerSpace#space_name</a>.
        /// </summary>
        [<CustomOperation "space_name">]
        member _.SpaceName(state: SagemakerSpaceState<'DomainId, Missing>, value: string) : SagemakerSpaceState<'DomainId, Present> =
            state.assignments.Add(fun config -> config.SpaceName <- value)
            ({ assignments = state.assignments } : SagemakerSpaceState<'DomainId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#id-1">SagemakerSpace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerSpaceState<'DomainId, 'SpaceName>, value: string) : SagemakerSpaceState<'DomainId, 'SpaceName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerSpaceState<'DomainId, 'SpaceName>

        /// <summary>
        /// ownership_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#ownership_settings-1">SagemakerSpace#ownership_settings</a>
        /// </summary>
        [<CustomOperation "ownership_settings">]
        member _.OwnershipSettings(state: SagemakerSpaceState<'DomainId, 'SpaceName>, value: aws.SagemakerSpace.SagemakerSpaceOwnershipSettings) : SagemakerSpaceState<'DomainId, 'SpaceName> =
            state.assignments.Add(fun config -> config.OwnershipSettings <- value)
            state : SagemakerSpaceState<'DomainId, 'SpaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#space_display_name-1">SagemakerSpace#space_display_name</a>.
        /// </summary>
        [<CustomOperation "space_display_name">]
        member _.SpaceDisplayName(state: SagemakerSpaceState<'DomainId, 'SpaceName>, value: string) : SagemakerSpaceState<'DomainId, 'SpaceName> =
            state.assignments.Add(fun config -> config.SpaceDisplayName <- value)
            state : SagemakerSpaceState<'DomainId, 'SpaceName>

        /// <summary>
        /// space_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#space_settings-1">SagemakerSpace#space_settings</a>
        /// </summary>
        [<CustomOperation "space_settings">]
        member _.SpaceSettings(state: SagemakerSpaceState<'DomainId, 'SpaceName>, value: aws.SagemakerSpace.SagemakerSpaceSpaceSettings) : SagemakerSpaceState<'DomainId, 'SpaceName> =
            state.assignments.Add(fun config -> config.SpaceSettings <- value)
            state : SagemakerSpaceState<'DomainId, 'SpaceName>

        /// <summary>
        /// space_sharing_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#space_sharing_settings-1">SagemakerSpace#space_sharing_settings</a>
        /// </summary>
        [<CustomOperation "space_sharing_settings">]
        member _.SpaceSharingSettings(state: SagemakerSpaceState<'DomainId, 'SpaceName>, value: aws.SagemakerSpace.SagemakerSpaceSpaceSharingSettings) : SagemakerSpaceState<'DomainId, 'SpaceName> =
            state.assignments.Add(fun config -> config.SpaceSharingSettings <- value)
            state : SagemakerSpaceState<'DomainId, 'SpaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#tags-1">SagemakerSpace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerSpaceState<'DomainId, 'SpaceName>, value: seq<string * string>) : SagemakerSpaceState<'DomainId, 'SpaceName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerSpaceState<'DomainId, 'SpaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#tags_all-1">SagemakerSpace#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerSpaceState<'DomainId, 'SpaceName>, value: seq<string * string>) : SagemakerSpaceState<'DomainId, 'SpaceName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerSpaceState<'DomainId, 'SpaceName>

        member _.Run(state: SagemakerSpaceState<Present, Present>) : aws.SagemakerSpace.SagemakerSpace =
            let config = aws.SagemakerSpace.SagemakerSpaceConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerSpace.SagemakerSpace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerSpace: missing required arguments. Must call: domain_id, space_name.", 9999, IsError = true)>]
        member _.Run(_: SagemakerSpaceState<_, _>) : aws.SagemakerSpace.SagemakerSpace =
            Unchecked.defaultof<aws.SagemakerSpace.SagemakerSpace>
