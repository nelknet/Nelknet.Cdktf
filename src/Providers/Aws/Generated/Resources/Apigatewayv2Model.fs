namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Apigatewayv2ModelState<'ApiId, 'ContentType, 'Name, 'Schema> = { assignments: ResizeArray<aws.Apigatewayv2Model.Apigatewayv2ModelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_model">aws_apigatewayv2_model</a>.
    /// </summary>
    type Apigatewayv2ModelBuilder(logicalId: string) =
        member _.Yield(_: unit) : Apigatewayv2ModelState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2ModelState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : Apigatewayv2ModelState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2ModelState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_model#api_id-1">Apigatewayv2Model#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: Apigatewayv2ModelState<Missing, 'ContentType, 'Name, 'Schema>, value: string) : Apigatewayv2ModelState<Present, 'ContentType, 'Name, 'Schema> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : Apigatewayv2ModelState<Present, 'ContentType, 'Name, 'Schema>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_model#content_type-1">Apigatewayv2Model#content_type</a>.
        /// </summary>
        [<CustomOperation "content_type">]
        member _.ContentType(state: Apigatewayv2ModelState<'ApiId, Missing, 'Name, 'Schema>, value: string) : Apigatewayv2ModelState<'ApiId, Present, 'Name, 'Schema> =
            state.assignments.Add(fun config -> config.ContentType <- value)
            ({ assignments = state.assignments } : Apigatewayv2ModelState<'ApiId, Present, 'Name, 'Schema>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_model#name-1">Apigatewayv2Model#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Apigatewayv2ModelState<'ApiId, 'ContentType, Missing, 'Schema>, value: string) : Apigatewayv2ModelState<'ApiId, 'ContentType, Present, 'Schema> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Apigatewayv2ModelState<'ApiId, 'ContentType, Present, 'Schema>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_model#schema-1">Apigatewayv2Model#schema</a>.
        /// </summary>
        [<CustomOperation "schema">]
        member _.Schema(state: Apigatewayv2ModelState<'ApiId, 'ContentType, 'Name, Missing>, value: string) : Apigatewayv2ModelState<'ApiId, 'ContentType, 'Name, Present> =
            state.assignments.Add(fun config -> config.Schema <- value)
            ({ assignments = state.assignments } : Apigatewayv2ModelState<'ApiId, 'ContentType, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_model#description-1">Apigatewayv2Model#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Apigatewayv2ModelState<'ApiId, 'ContentType, 'Name, 'Schema>, value: string) : Apigatewayv2ModelState<'ApiId, 'ContentType, 'Name, 'Schema> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Apigatewayv2ModelState<'ApiId, 'ContentType, 'Name, 'Schema>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_model#id-1">Apigatewayv2Model#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Apigatewayv2ModelState<'ApiId, 'ContentType, 'Name, 'Schema>, value: string) : Apigatewayv2ModelState<'ApiId, 'ContentType, 'Name, 'Schema> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Apigatewayv2ModelState<'ApiId, 'ContentType, 'Name, 'Schema>

        member _.Run(state: Apigatewayv2ModelState<Present, Present, Present, Present>) : aws.Apigatewayv2Model.Apigatewayv2Model =
            let config = aws.Apigatewayv2Model.Apigatewayv2ModelConfig()
            for setter in state.assignments do
                setter config
            aws.Apigatewayv2Model.Apigatewayv2Model(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apigatewayv2Model: missing required arguments. Must call: api_id, content_type, name, schema.", 9999, IsError = true)>]
        member _.Run(_: Apigatewayv2ModelState<_, _, _, _>) : aws.Apigatewayv2Model.Apigatewayv2Model =
            Unchecked.defaultof<aws.Apigatewayv2Model.Apigatewayv2Model>
