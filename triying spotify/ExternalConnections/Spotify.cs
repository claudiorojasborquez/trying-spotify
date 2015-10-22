using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;


namespace triying_spotify.ExternalConnections
{
    public static class Spotify
    {
        private const string search_base = @"http://ws.spotify.com/search/1/";
        private const string lookup_base = @"http://ws.spotify.com/lookup/1/";

        private static string QuerySpotify(string url)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    return client.DownloadString(url);
                }
                catch (WebException e)
                {
                    //TODO: Check status code
                    throw e;
                }
            }
        }

        public enum QueryKind
        {
            Artist,
            Album,
            Track,
        }

        public static object Search(string name, QueryKind kind)
        {
            string url = search_base;
            string response;
            switch (kind)
            {
                case QueryKind.Artist:
                    url += @"artist?q=" + HttpUtility.UrlDecode(name);
                    break;
                case QueryKind.Album:
                    url += @"album?q=" + HttpUtility.UrlDecode(name);
                    break;
                case QueryKind.Track:
                    url += @"track?q=" + HttpUtility.UrlDecode(name);
                    break;
                default:
                    throw new ArgumentException("Kind provided is not a recognized one");
            }
            response = QuerySpotify(url);
            return ProcessSearchResponse(response, kind);
        }


        private static object ProcessSearchResponse(string response, QueryKind kind)
        {
            //parse xml

            //do something else

            //bleh

            //really bleh

            return response;
        }

        public static void LookUp(string name, QueryKind kind)
        {
            switch (kind)
            {
                case QueryKind.Artist:

                    break;
                case QueryKind.Album:

                    break;
                case QueryKind.Track:

                    break;
                default:
                    throw new ArgumentException("Kind provided is not a recognized one");
            }


        }

        private static void ProcessLookUpResponse(object response, QueryKind kind)
        {
            return;
        }

    }
}