namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsImagebuilderContainerRecipeState<'Arn> = { assignments: ResizeArray<aws.DataAwsImagebuilderContainerRecipe.DataAwsImagebuilderContainerRecipeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_container_recipe">aws_imagebuilder_container_recipe</a>.
    /// </summary>
    type DataAwsImagebuilderContainerRecipeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsImagebuilderContainerRecipeState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsImagebuilderContainerRecipeState<Missing>)

        member _.Zero(()) : DataAwsImagebuilderContainerRecipeState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsImagebuilderContainerRecipeState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_container_recipe#arn-1">DataAwsImagebuilderContainerRecipe#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsImagebuilderContainerRecipeState<Missing>, value: string) : DataAwsImagebuilderContainerRecipeState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsImagebuilderContainerRecipeState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_container_recipe#id-1">DataAwsImagebuilderContainerRecipe#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsImagebuilderContainerRecipeState<'Arn>, value: string) : DataAwsImagebuilderContainerRecipeState<'Arn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsImagebuilderContainerRecipeState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_container_recipe#tags-1">DataAwsImagebuilderContainerRecipe#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsImagebuilderContainerRecipeState<'Arn>, value: seq<string * string>) : DataAwsImagebuilderContainerRecipeState<'Arn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsImagebuilderContainerRecipeState<'Arn>

        member _.Run(state: DataAwsImagebuilderContainerRecipeState<Present>) : aws.DataAwsImagebuilderContainerRecipe.DataAwsImagebuilderContainerRecipe =
            let config = aws.DataAwsImagebuilderContainerRecipe.DataAwsImagebuilderContainerRecipeConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsImagebuilderContainerRecipe.DataAwsImagebuilderContainerRecipe(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsImagebuilderContainerRecipe: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsImagebuilderContainerRecipeState<_>) : aws.DataAwsImagebuilderContainerRecipe.DataAwsImagebuilderContainerRecipe =
            Unchecked.defaultof<aws.DataAwsImagebuilderContainerRecipe.DataAwsImagebuilderContainerRecipe>
