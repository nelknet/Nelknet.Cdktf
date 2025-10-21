namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRoute53ProfilesProfilesState = { assignments: ResizeArray<aws.DataAwsRoute53ProfilesProfiles.DataAwsRoute53ProfilesProfilesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53profiles_profiles">aws_route53profiles_profiles</a>.
    /// </summary>
    type DataAwsRoute53ProfilesProfilesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRoute53ProfilesProfilesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsRoute53ProfilesProfilesState =
            { assignments = ResizeArray() }



        member _.Run(state: DataAwsRoute53ProfilesProfilesState) : aws.DataAwsRoute53ProfilesProfiles.DataAwsRoute53ProfilesProfiles =
            let config = aws.DataAwsRoute53ProfilesProfiles.DataAwsRoute53ProfilesProfilesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRoute53ProfilesProfiles.DataAwsRoute53ProfilesProfiles(StackContext.get (), logicalId, config)
