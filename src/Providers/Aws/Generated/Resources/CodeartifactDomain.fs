namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodeartifactDomainState<'Domain> = { assignments: ResizeArray<aws.CodeartifactDomain.CodeartifactDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_domain">aws_codeartifact_domain</a>.
    /// </summary>
    type CodeartifactDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodeartifactDomainState<Missing> =
            ({ assignments = ResizeArray() } : CodeartifactDomainState<Missing>)

        member _.Zero(()) : CodeartifactDomainState<Missing> =
            ({ assignments = ResizeArray() } : CodeartifactDomainState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_domain#domain-1">CodeartifactDomain#domain</a>.
        /// </summary>
        [<CustomOperation "domain">]
        member _.Domain(state: CodeartifactDomainState<Missing>, value: string) : CodeartifactDomainState<Present> =
            state.assignments.Add(fun config -> config.Domain <- value)
            ({ assignments = state.assignments } : CodeartifactDomainState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_domain#encryption_key-1">CodeartifactDomain#encryption_key</a>.
        /// </summary>
        [<CustomOperation "encryption_key">]
        member _.EncryptionKey(state: CodeartifactDomainState<'Domain>, value: string) : CodeartifactDomainState<'Domain> =
            state.assignments.Add(fun config -> config.EncryptionKey <- value)
            state : CodeartifactDomainState<'Domain>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_domain#id-1">CodeartifactDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodeartifactDomainState<'Domain>, value: string) : CodeartifactDomainState<'Domain> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodeartifactDomainState<'Domain>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_domain#tags-1">CodeartifactDomain#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CodeartifactDomainState<'Domain>, value: seq<string * string>) : CodeartifactDomainState<'Domain> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CodeartifactDomainState<'Domain>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_domain#tags_all-1">CodeartifactDomain#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CodeartifactDomainState<'Domain>, value: seq<string * string>) : CodeartifactDomainState<'Domain> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CodeartifactDomainState<'Domain>

        member _.Run(state: CodeartifactDomainState<Present>) : aws.CodeartifactDomain.CodeartifactDomain =
            let config = aws.CodeartifactDomain.CodeartifactDomainConfig()
            for setter in state.assignments do
                setter config
            aws.CodeartifactDomain.CodeartifactDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codeartifactDomain: missing required arguments. Must call: domain.", 9999, IsError = true)>]
        member _.Run(_: CodeartifactDomainState<_>) : aws.CodeartifactDomain.CodeartifactDomain =
            Unchecked.defaultof<aws.CodeartifactDomain.CodeartifactDomain>
