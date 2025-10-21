namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsImagebuilderImageRecipesState = { assignments: ResizeArray<aws.DataAwsImagebuilderImageRecipes.DataAwsImagebuilderImageRecipesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image_recipes">aws_imagebuilder_image_recipes</a>.
    /// </summary>
    type DataAwsImagebuilderImageRecipesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsImagebuilderImageRecipesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsImagebuilderImageRecipesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image_recipes#filter-1">DataAwsImagebuilderImageRecipes#filter</a> Accepts: aws.IResolvable | aws.DataAwsImagebuilderImageRecipes.DataAwsImagebuilderImageRecipesFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsImagebuilderImageRecipesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsImagebuilderImageRecipesState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsImagebuilderImageRecipesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image_recipes#id-1">DataAwsImagebuilderImageRecipes#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsImagebuilderImageRecipesState, value: string) : DataAwsImagebuilderImageRecipesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsImagebuilderImageRecipesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image_recipes#owner-1">DataAwsImagebuilderImageRecipes#owner</a>.
        /// </summary>
        [<CustomOperation "owner">]
        member _.Owner(state: DataAwsImagebuilderImageRecipesState, value: string) : DataAwsImagebuilderImageRecipesState =
            state.assignments.Add(fun config -> config.Owner <- value)
            state : DataAwsImagebuilderImageRecipesState

        member _.Run(state: DataAwsImagebuilderImageRecipesState) : aws.DataAwsImagebuilderImageRecipes.DataAwsImagebuilderImageRecipes =
            let config = aws.DataAwsImagebuilderImageRecipes.DataAwsImagebuilderImageRecipesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsImagebuilderImageRecipes.DataAwsImagebuilderImageRecipes(StackContext.get (), logicalId, config)
