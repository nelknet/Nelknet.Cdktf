namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsImagebuilderContainerRecipesState = { assignments: ResizeArray<aws.DataAwsImagebuilderContainerRecipes.DataAwsImagebuilderContainerRecipesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_container_recipes">aws_imagebuilder_container_recipes</a>.
    /// </summary>
    type DataAwsImagebuilderContainerRecipesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsImagebuilderContainerRecipesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsImagebuilderContainerRecipesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_container_recipes#filter-1">DataAwsImagebuilderContainerRecipes#filter</a> Accepts: aws.IResolvable | aws.DataAwsImagebuilderContainerRecipes.DataAwsImagebuilderContainerRecipesFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsImagebuilderContainerRecipesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsImagebuilderContainerRecipesState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsImagebuilderContainerRecipesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_container_recipes#id-1">DataAwsImagebuilderContainerRecipes#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsImagebuilderContainerRecipesState, value: string) : DataAwsImagebuilderContainerRecipesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsImagebuilderContainerRecipesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_container_recipes#owner-1">DataAwsImagebuilderContainerRecipes#owner</a>.
        /// </summary>
        [<CustomOperation "owner">]
        member _.Owner(state: DataAwsImagebuilderContainerRecipesState, value: string) : DataAwsImagebuilderContainerRecipesState =
            state.assignments.Add(fun config -> config.Owner <- value)
            state : DataAwsImagebuilderContainerRecipesState

        member _.Run(state: DataAwsImagebuilderContainerRecipesState) : aws.DataAwsImagebuilderContainerRecipes.DataAwsImagebuilderContainerRecipes =
            let config = aws.DataAwsImagebuilderContainerRecipes.DataAwsImagebuilderContainerRecipesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsImagebuilderContainerRecipes.DataAwsImagebuilderContainerRecipes(StackContext.get (), logicalId, config)
