namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlueUserDefinedFunctionState<'ClassName, 'DatabaseName, 'Name, 'OwnerName, 'OwnerType> = { assignments: ResizeArray<aws.GlueUserDefinedFunction.GlueUserDefinedFunctionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_user_defined_function">aws_glue_user_defined_function</a>.
    /// </summary>
    type GlueUserDefinedFunctionBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlueUserDefinedFunctionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueUserDefinedFunctionState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : GlueUserDefinedFunctionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueUserDefinedFunctionState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_user_defined_function#class_name-1">GlueUserDefinedFunction#class_name</a>.
        /// </summary>
        [<CustomOperation "class_name">]
        member _.ClassName(state: GlueUserDefinedFunctionState<Missing, 'DatabaseName, 'Name, 'OwnerName, 'OwnerType>, value: string) : GlueUserDefinedFunctionState<Present, 'DatabaseName, 'Name, 'OwnerName, 'OwnerType> =
            state.assignments.Add(fun config -> config.ClassName <- value)
            ({ assignments = state.assignments } : GlueUserDefinedFunctionState<Present, 'DatabaseName, 'Name, 'OwnerName, 'OwnerType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_user_defined_function#database_name-1">GlueUserDefinedFunction#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: GlueUserDefinedFunctionState<'ClassName, Missing, 'Name, 'OwnerName, 'OwnerType>, value: string) : GlueUserDefinedFunctionState<'ClassName, Present, 'Name, 'OwnerName, 'OwnerType> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : GlueUserDefinedFunctionState<'ClassName, Present, 'Name, 'OwnerName, 'OwnerType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_user_defined_function#name-1">GlueUserDefinedFunction#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GlueUserDefinedFunctionState<'ClassName, 'DatabaseName, Missing, 'OwnerName, 'OwnerType>, value: string) : GlueUserDefinedFunctionState<'ClassName, 'DatabaseName, Present, 'OwnerName, 'OwnerType> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GlueUserDefinedFunctionState<'ClassName, 'DatabaseName, Present, 'OwnerName, 'OwnerType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_user_defined_function#owner_name-1">GlueUserDefinedFunction#owner_name</a>.
        /// </summary>
        [<CustomOperation "owner_name">]
        member _.OwnerName(state: GlueUserDefinedFunctionState<'ClassName, 'DatabaseName, 'Name, Missing, 'OwnerType>, value: string) : GlueUserDefinedFunctionState<'ClassName, 'DatabaseName, 'Name, Present, 'OwnerType> =
            state.assignments.Add(fun config -> config.OwnerName <- value)
            ({ assignments = state.assignments } : GlueUserDefinedFunctionState<'ClassName, 'DatabaseName, 'Name, Present, 'OwnerType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_user_defined_function#owner_type-1">GlueUserDefinedFunction#owner_type</a>.
        /// </summary>
        [<CustomOperation "owner_type">]
        member _.OwnerType(state: GlueUserDefinedFunctionState<'ClassName, 'DatabaseName, 'Name, 'OwnerName, Missing>, value: string) : GlueUserDefinedFunctionState<'ClassName, 'DatabaseName, 'Name, 'OwnerName, Present> =
            state.assignments.Add(fun config -> config.OwnerType <- value)
            ({ assignments = state.assignments } : GlueUserDefinedFunctionState<'ClassName, 'DatabaseName, 'Name, 'OwnerName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_user_defined_function#catalog_id-1">GlueUserDefinedFunction#catalog_id</a>.
        /// </summary>
        [<CustomOperation "catalog_id">]
        member _.CatalogId(state: GlueUserDefinedFunctionState<'ClassName, 'DatabaseName, 'Name, 'OwnerName, 'OwnerType>, value: string) : GlueUserDefinedFunctionState<'ClassName, 'DatabaseName, 'Name, 'OwnerName, 'OwnerType> =
            state.assignments.Add(fun config -> config.CatalogId <- value)
            state : GlueUserDefinedFunctionState<'ClassName, 'DatabaseName, 'Name, 'OwnerName, 'OwnerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_user_defined_function#id-1">GlueUserDefinedFunction#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlueUserDefinedFunctionState<'ClassName, 'DatabaseName, 'Name, 'OwnerName, 'OwnerType>, value: string) : GlueUserDefinedFunctionState<'ClassName, 'DatabaseName, 'Name, 'OwnerName, 'OwnerType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlueUserDefinedFunctionState<'ClassName, 'DatabaseName, 'Name, 'OwnerName, 'OwnerType>

        /// <summary>
        /// resource_uris block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_user_defined_function#resource_uris-1">GlueUserDefinedFunction#resource_uris</a> Accepts: aws.IResolvable | aws.GlueUserDefinedFunction.GlueUserDefinedFunctionResourceUris[]
        /// </summary>
        [<CustomOperation "resource_uris">]
        member _.ResourceUris(state: GlueUserDefinedFunctionState<'ClassName, 'DatabaseName, 'Name, 'OwnerName, 'OwnerType>, value: HashiCorp.Cdktf.IResolvable) : GlueUserDefinedFunctionState<'ClassName, 'DatabaseName, 'Name, 'OwnerName, 'OwnerType> =
            state.assignments.Add(fun config -> config.ResourceUris <- value)
            state : GlueUserDefinedFunctionState<'ClassName, 'DatabaseName, 'Name, 'OwnerName, 'OwnerType>

        member _.Run(state: GlueUserDefinedFunctionState<Present, Present, Present, Present, Present>) : aws.GlueUserDefinedFunction.GlueUserDefinedFunction =
            let config = aws.GlueUserDefinedFunction.GlueUserDefinedFunctionConfig()
            for setter in state.assignments do
                setter config
            aws.GlueUserDefinedFunction.GlueUserDefinedFunction(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.glueUserDefinedFunction: missing required arguments. Must call: class_name, database_name, name, owner_name, owner_type.", 9999, IsError = true)>]
        member _.Run(_: GlueUserDefinedFunctionState<_, _, _, _, _>) : aws.GlueUserDefinedFunction.GlueUserDefinedFunction =
            Unchecked.defaultof<aws.GlueUserDefinedFunction.GlueUserDefinedFunction>
