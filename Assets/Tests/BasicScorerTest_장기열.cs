using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityDemo.Models;
using UnityDemo.Models.Scorers;
using UnityEngine;

public class BasicScorerTest_장기열 : MonoBehaviour
{
    [Test]
    public void 광땡으로_이긴경우()
    {
        Scorer scorer = new BasicScorer();
        Player p1 = new Player("1");
        p1.AddCard(new Card(1, true));
        p1.AddCard(new Card(3, true));//101점

        Player p2 = new Player("2");
        p2.AddCard(new Card(10, false));
        p2.AddCard(new Card(10, false));//100점

        Player winner = scorer.GetWinner(p1, p2);

        Assert.AreEqual(p1, winner);
    }

    [Test]
    public void 땡으로_이긴경우()
    {
        Scorer scorer = new BasicScorer();
        Player p1 = new Player("1");
        p1.AddCard(new Card(1, true));
        p1.AddCard(new Card(2, false));//3점

        Player p2 = new Player("2");
        p2.AddCard(new Card(10, false));
        p2.AddCard(new Card(10, false));//100점

        Player winner = scorer.GetWinner(p1, p2);

        Assert.AreEqual(p2, winner);
    }

    [Test]
    public void 끗으로_이긴경우()
    {
        Scorer scorer = new BasicScorer();
        Player p1 = new Player("1");
        p1.AddCard(new Card(1, true));
        p1.AddCard(new Card(7, false));//8점

        Player p2 = new Player("2");
        p2.AddCard(new Card(3, false));
        p2.AddCard(new Card(8, false));//1점

        Player winner = scorer.GetWinner(p1, p2);

        Assert.AreEqual(p1, winner);
    }
}
