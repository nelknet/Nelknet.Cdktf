namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId> = { assignments: ResizeArray<azurerm.SpringCloudCustomizedAccelerator.SpringCloudCustomizedAcceleratorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_customized_accelerator">azurerm_spring_cloud_customized_accelerator</a>.
    /// </summary>
    type SpringCloudCustomizedAcceleratorBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudCustomizedAcceleratorState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudCustomizedAcceleratorState<Missing, Missing, Missing>)

        member _.Zero(()) : SpringCloudCustomizedAcceleratorState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudCustomizedAcceleratorState<Missing, Missing, Missing>)

        /// <summary>
        /// git_repository block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_customized_accelerator#git_repository-1">SpringCloudCustomizedAccelerator#git_repository</a>
        /// </summary>
        [<CustomOperation "git_repository">]
        member _.GitRepository(state: SpringCloudCustomizedAcceleratorState<Missing, 'Name, 'SpringCloudAcceleratorId>, value: azurerm.SpringCloudCustomizedAccelerator.SpringCloudCustomizedAcceleratorGitRepository) : SpringCloudCustomizedAcceleratorState<Present, 'Name, 'SpringCloudAcceleratorId> =
            state.assignments.Add(fun config -> config.GitRepository <- value)
            ({ assignments = state.assignments } : SpringCloudCustomizedAcceleratorState<Present, 'Name, 'SpringCloudAcceleratorId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_customized_accelerator#name-1">SpringCloudCustomizedAccelerator#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudCustomizedAcceleratorState<'GitRepository, Missing, 'SpringCloudAcceleratorId>, value: string) : SpringCloudCustomizedAcceleratorState<'GitRepository, Present, 'SpringCloudAcceleratorId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudCustomizedAcceleratorState<'GitRepository, Present, 'SpringCloudAcceleratorId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_customized_accelerator#spring_cloud_accelerator_id-1">SpringCloudCustomizedAccelerator#spring_cloud_accelerator_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_accelerator_id">]
        member _.SpringCloudAcceleratorId(state: SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, Missing>, value: string) : SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, Present> =
            state.assignments.Add(fun config -> config.SpringCloudAcceleratorId <- value)
            ({ assignments = state.assignments } : SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_customized_accelerator#accelerator_tags-1">SpringCloudCustomizedAccelerator#accelerator_tags</a>.
        /// </summary>
        [<CustomOperation "accelerator_tags">]
        member _.AcceleratorTags(state: SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId>, value: seq<string>) : SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId> =
            state.assignments.Add(fun config -> config.AcceleratorTags <- (value |> Seq.toArray))
            state : SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_customized_accelerator#accelerator_type-1">SpringCloudCustomizedAccelerator#accelerator_type</a>.
        /// </summary>
        [<CustomOperation "accelerator_type">]
        member _.AcceleratorType(state: SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId>, value: string) : SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId> =
            state.assignments.Add(fun config -> config.AcceleratorType <- value)
            state : SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_customized_accelerator#description-1">SpringCloudCustomizedAccelerator#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId>, value: string) : SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_customized_accelerator#display_name-1">SpringCloudCustomizedAccelerator#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId>, value: string) : SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_customized_accelerator#icon_url-1">SpringCloudCustomizedAccelerator#icon_url</a>.
        /// </summary>
        [<CustomOperation "icon_url">]
        member _.IconUrl(state: SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId>, value: string) : SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId> =
            state.assignments.Add(fun config -> config.IconUrl <- value)
            state : SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_customized_accelerator#id-1">SpringCloudCustomizedAccelerator#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId>, value: string) : SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_customized_accelerator#timeouts-1">SpringCloudCustomizedAccelerator#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId>, value: azurerm.SpringCloudCustomizedAccelerator.SpringCloudCustomizedAcceleratorTimeouts) : SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudCustomizedAcceleratorState<'GitRepository, 'Name, 'SpringCloudAcceleratorId>

        member _.Run(state: SpringCloudCustomizedAcceleratorState<Present, Present, Present>) : azurerm.SpringCloudCustomizedAccelerator.SpringCloudCustomizedAccelerator =
            let config = azurerm.SpringCloudCustomizedAccelerator.SpringCloudCustomizedAcceleratorConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudCustomizedAccelerator.SpringCloudCustomizedAccelerator(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudCustomizedAccelerator: missing required arguments. Must call: git_repository, name, spring_cloud_accelerator_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudCustomizedAcceleratorState<_, _, _>) : azurerm.SpringCloudCustomizedAccelerator.SpringCloudCustomizedAccelerator =
            Unchecked.defaultof<azurerm.SpringCloudCustomizedAccelerator.SpringCloudCustomizedAccelerator>
