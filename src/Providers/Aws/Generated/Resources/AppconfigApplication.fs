namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppconfigApplicationState<'Name> = { assignments: ResizeArray<aws.AppconfigApplication.AppconfigApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_application">aws_appconfig_application</a>.
    /// </summary>
    type AppconfigApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppconfigApplicationState<Missing> =
            ({ assignments = ResizeArray() } : AppconfigApplicationState<Missing>)

        member _.Zero(()) : AppconfigApplicationState<Missing> =
            ({ assignments = ResizeArray() } : AppconfigApplicationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_application#name-1">AppconfigApplication#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppconfigApplicationState<Missing>, value: string) : AppconfigApplicationState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppconfigApplicationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_application#description-1">AppconfigApplication#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AppconfigApplicationState<'Name>, value: string) : AppconfigApplicationState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AppconfigApplicationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_application#id-1">AppconfigApplication#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppconfigApplicationState<'Name>, value: string) : AppconfigApplicationState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppconfigApplicationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_application#tags-1">AppconfigApplication#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppconfigApplicationState<'Name>, value: seq<string * string>) : AppconfigApplicationState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppconfigApplicationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_application#tags_all-1">AppconfigApplication#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AppconfigApplicationState<'Name>, value: seq<string * string>) : AppconfigApplicationState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AppconfigApplicationState<'Name>

        member _.Run(state: AppconfigApplicationState<Present>) : aws.AppconfigApplication.AppconfigApplication =
            let config = aws.AppconfigApplication.AppconfigApplicationConfig()
            for setter in state.assignments do
                setter config
            aws.AppconfigApplication.AppconfigApplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appconfigApplication: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: AppconfigApplicationState<_>) : aws.AppconfigApplication.AppconfigApplication =
            Unchecked.defaultof<aws.AppconfigApplication.AppconfigApplication>
