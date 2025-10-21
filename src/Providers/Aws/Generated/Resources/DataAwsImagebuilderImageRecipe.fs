namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsImagebuilderImageRecipeState<'Arn> = { assignments: ResizeArray<aws.DataAwsImagebuilderImageRecipe.DataAwsImagebuilderImageRecipeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image_recipe">aws_imagebuilder_image_recipe</a>.
    /// </summary>
    type DataAwsImagebuilderImageRecipeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsImagebuilderImageRecipeState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsImagebuilderImageRecipeState<Missing>)

        member _.Zero(()) : DataAwsImagebuilderImageRecipeState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsImagebuilderImageRecipeState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image_recipe#arn-1">DataAwsImagebuilderImageRecipe#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsImagebuilderImageRecipeState<Missing>, value: string) : DataAwsImagebuilderImageRecipeState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsImagebuilderImageRecipeState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image_recipe#id-1">DataAwsImagebuilderImageRecipe#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsImagebuilderImageRecipeState<'Arn>, value: string) : DataAwsImagebuilderImageRecipeState<'Arn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsImagebuilderImageRecipeState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image_recipe#tags-1">DataAwsImagebuilderImageRecipe#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsImagebuilderImageRecipeState<'Arn>, value: seq<string * string>) : DataAwsImagebuilderImageRecipeState<'Arn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsImagebuilderImageRecipeState<'Arn>

        member _.Run(state: DataAwsImagebuilderImageRecipeState<Present>) : aws.DataAwsImagebuilderImageRecipe.DataAwsImagebuilderImageRecipe =
            let config = aws.DataAwsImagebuilderImageRecipe.DataAwsImagebuilderImageRecipeConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsImagebuilderImageRecipe.DataAwsImagebuilderImageRecipe(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsImagebuilderImageRecipe: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsImagebuilderImageRecipeState<_>) : aws.DataAwsImagebuilderImageRecipe.DataAwsImagebuilderImageRecipe =
            Unchecked.defaultof<aws.DataAwsImagebuilderImageRecipe.DataAwsImagebuilderImageRecipe>
